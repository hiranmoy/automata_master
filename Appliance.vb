﻿' -*- Visual basic -*-

'*****************************************************************
'
'              Copyright 2017 Hiranmoy Basak
'
'                  All Rights Reserved.
'
'           THIS WORK CONTAINS TRADE SECRET And
'       PROPRIETARY INFORMATION WHICH Is THE PROPERTY
'            OF HIRANMOY BASAK OR ITS LICENSOR
'            AND IS SUBJECT TO LICENSE TERMS.
'
'*****************************************************************/
'
' No part of this file may be reproduced, stored in a retrieval system,
' Or transmitted in any form Or by any means --- electronic, mechanical,
' photocopying, recording, Or otherwise --- without prior written permission
' of Hiranmoy Basak.
'
' WARRANTY:
' Use all material in this file at your own risk. Hiranmoy Basak.
' makes no claims about any material contained in this file.
' 
' Author: Hiranmoy Basak (hiranmoy.iitkgp@gmail.com)


Public Class Appliance

    'name
    Private mName As String

    'rpi
    Private mRPI As String

    'GPIO
    Private mGPIO As Integer

    'room no
    Private mRoom As Integer

    'type
    Private mType As ApplianceType

    'appliance index
    Private mPriority As Integer

    'indicates whether it is a special appliance
    Private mAttribute As AttributeType


    Public Sub New(name As String,
                   rpi As String,
                   gpio As Integer,
                   room As Integer,
                   type As ApplianceType,
                   priority As Integer,
                   attribute As Integer)
        Debug.Assert(Not mName.Contains(" "))
        mName = name

        Debug.Assert(Not mRPI.Contains(" "))
        mRPI = rpi

        mGPIO = gpio

        Debug.Assert(mRoom >= 0)
        mRoom = room

        Debug.Assert(type >= 0)
        mType = type

        Debug.Assert(priority >= 0)
        mPriority = priority

        Debug.Assert(attribute >= -1)
        mAttribute = attribute
        Debug.Assert(CStr(mAttribute) < 40)
    End Sub

    Public Sub New(fileIdx As Integer)
        Restore(fileIdx)
    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'get/set functions
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'get name
    Public Function GetName() As String
        Return mName
    End Function

    'get rpi name
    Public Function GetRPI() As String
        Return mRPI
    End Function

    'get gpio name
    Public Function GetGPIO() As Integer
        Return mGPIO
    End Function

    'get room no
    Public Function GetRoom() As Integer
        Return mRoom
    End Function

    'get type
    Public Function GetApplianceType() As ApplianceType
        Return mType
    End Function

    'get priority
    Public Function GetPriority() As Integer
        Return mPriority
    End Function

    'get attribute
    Public Function GetAttribute() As AttributeType
        Return mAttribute
    End Function


    'set rpi
    Public Sub SetRPI(rpi As String)
        mRPI = rpi
    End Sub

    'set gpio
    Public Sub SetGPIO(gpio As Integer)
        mGPIO = gpio
    End Sub

    'set room
    Public Sub SetRoom(room As Integer)
        mRoom = room
    End Sub

    'set type
    Public Sub SetType(type As ApplianceType)
        mType = type
    End Sub

    'set priority
    Public Sub SetPriority(priority As Integer)
        mPriority = priority
    End Sub

    'set attribute
    Public Sub SetAttribute(attribute As Boolean)
        mAttribute = attribute
    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'save/restore functions
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'save
    Public Overridable Sub Save(fileIdx As Integer)
        Print(fileIdx, mName.ToString + "                                        : name" + Environment.NewLine)
        Print(fileIdx, mRPI.ToString + "                                        : rpi name" + Environment.NewLine)
        Print(fileIdx, mGPIO.ToString + "                                        : gpio" + Environment.NewLine)
        Print(fileIdx, mRoom.ToString + "                                        : room no" + Environment.NewLine)
        Print(fileIdx, mType.ToString + "                                        : type" + Environment.NewLine)
        Print(fileIdx, mPriority.ToString + "                                        : priority" + Environment.NewLine)
        Print(fileIdx, mAttribute.ToString + "                                        : attribute" + Environment.NewLine)
        Print(fileIdx, "--------------------------------------------------" + Environment.NewLine)
    End Sub

    'restore
    Public Sub Restore(fileIdx As Integer)
        'name
        Dim data As String = LineInput(fileIdx)
        Dim spaceChar As Integer = data.Substring(0, 40).IndexOf(" ")
        mName = data.Substring(0, spaceChar)

        'rpi name
        data = LineInput(fileIdx)
        spaceChar = data.Substring(0, 40).IndexOf(" ")
        mRPI = data.Substring(0, spaceChar)

        'gpio
        data = LineInput(fileIdx)
        mGPIO = CInt(data.Substring(0, 40))

        'room no
        data = LineInput(fileIdx)
        mRoom = CInt(data.Substring(0, 40))

        'type
        data = LineInput(fileIdx)
        mType = DirectCast([Enum].Parse(GetType(ApplianceType), data.Substring(0, 40)), ApplianceType)

        'priority
        data = LineInput(fileIdx)
        mPriority = CInt(data.Substring(0, 40))

        'attribute
        data = LineInput(fileIdx)
        mAttribute = DirectCast([Enum].Parse(GetType(AttributeType), data.Substring(0, 40)), AttributeType)

        'end line
        data = LineInput(fileIdx)
        Debug.Assert(data = "--------------------------------------------------")
    End Sub

End Class



Module ApplianceHelper

    'create appliance
    Public Function CreateAppliances(name As String,
                                     rpi As String,
                                     gpio As Integer,
                                     room As Integer,
                                     type As Integer,
                                     priority As Integer,
                                     attribute As Integer) As Boolean
        Dim device As Appliance

        'check if this appliance already exists
        For applanceIdx = 0 To gAppliances.Count - 1
            device = gAppliances(applanceIdx)
            If device.GetName() = name Then
                device.SetRPI(rpi)
                device.SetGPIO(gpio)
                device.SetRoom(room)
                device.SetType(type)
                device.SetPriority(priority)
                device.SetAttribute(attribute)

                SaveAppliances()
                Return False
            End If
        Next

        device = New Appliance(name, rpi, gpio, room, type, priority, attribute)
        gAppliances.Add(device)

        SaveAppliances()
        Return True
    End Function

    'load appliance
    Public Function LoadAppliance(applanceIdx As Integer) As Tuple(Of String, String, Integer, Integer, ApplianceType, Integer, Integer)
        Dim device As Appliance = gAppliances(applanceIdx)

        Return New Tuple(Of String, String, Integer, Integer, ApplianceType, Integer, Integer) _
            (device.GetName(),
             device.GetRPI(),
             device.GetGPIO(),
             device.GetRoom(),
             device.GetApplianceType(),
             device.GetPriority(),
             device.GetAttribute())
    End Function

    'delete appliance
    Public Sub DeleteAppliance(applanceIdx As Integer)
        gAppliances.RemoveAt(applanceIdx)

        SaveAppliances()
    End Sub

    'save appliances
    Public Sub SaveAppliances()
        FileOpen(1, gApplianceSettingsFile, OpenMode.Output)

        For applanceIdx = 0 To gAppliances.Count - 1
            Dim device As Appliance = gAppliances(applanceIdx)
            device.Save(1)
        Next

        FileClose(1)
    End Sub

    'restore appliances
    Public Sub RestoreAppliances()
        If My.Computer.FileSystem.FileExists(gApplianceSettingsFile) = False Then
            Exit Sub
        End If

        FileOpen(1, gApplianceSettingsFile, OpenMode.Input)

        Do While Not EOF(1)
            Dim device As Appliance = New Appliance(1)
            gAppliances.Add(device)

            'update control
            ConfigMod.ApplianceList.Items.Add(device.GetName())
        Loop

        FileClose(1)
    End Sub

End Module
