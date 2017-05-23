' -*- Visual basic -*-

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


Public Class Sensor

    'name
    Private mName As String

    'rpi
    Private mRPI As String

    'room no
    Private mRoom As Integer

    'type
    Private mType As SensorType


    Public Sub New(name As String,
                   rpi As String,
                   room As Integer,
                   type As SensorType)
        mName = name
        Debug.Assert(Not mName.Contains(" "))

        mRPI = rpi
        Debug.Assert(Not mRPI.Contains(" "))

        Debug.Assert(mRoom >= 0)
        mRoom = room

        Debug.Assert(type >= -1)
        mType = type
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

    'get room no
    Public Function GetRoom() As Integer
        Return mRoom
    End Function

    'get type
    Public Function GetSensorType() As SensorType
        Return mType
    End Function


    'set rpi
    Public Sub SetRPI(rpi As String)
        mRPI = rpi
    End Sub

    'set room
    Public Sub SetRoom(room As Integer)
        mRoom = room
    End Sub

    'set type
    Public Sub SetType(type As SensorType)
        mType = type
    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'save/restore functions
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'save
    Public Overridable Sub Save(fileIdx As Integer)
        Print(fileIdx, mName.ToString + "                                        : name" + Environment.NewLine)
        Print(fileIdx, mRPI.ToString + "                                        : rpi name" + Environment.NewLine)
        Print(fileIdx, mRoom.ToString + "                                        : room no" + Environment.NewLine)
        Print(fileIdx, mType.ToString + "                                        : type" + Environment.NewLine)
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

        'room no
        data = LineInput(fileIdx)
        mRoom = CInt(data.Substring(0, 40))

        'type
        data = LineInput(fileIdx)
        mType = DirectCast([Enum].Parse(GetType(SensorType), data.Substring(0, 40)), SensorType)

        'end line
        data = LineInput(fileIdx)
        Debug.Assert(data = "--------------------------------------------------")
    End Sub

End Class



Module SensorHelper

    'create sensor
    Public Function CreateSensors(name As String,
                                  rpi As String,
                                  room As Integer,
                                  type As Integer) As Boolean
        Dim sense As Sensor

        'check if this camera already exists
        For senseIdx = 0 To gSensors.Count - 1
            sense = gSensors(senseIdx)
            If sense.GetName() = name Then
                sense.SetRPI(rpi)
                sense.SetRoom(room)
                sense.SetType(type)

                SaveSensors()
                Return False
            End If
        Next

        sense = New Sensor(name, rpi, room, type)
        gSensors.Add(sense)

        SaveSensors()
        Return True
    End Function

    'load sensor
    Public Function LoadSensor(senseIdx As Integer) As Tuple(Of String, String, Integer, Integer)
        Dim sense As Sensor = gSensors(senseIdx)

        Return New Tuple(Of String, String, Integer, Integer) _
            (sense.GetName(),
             sense.GetRPI(),
             sense.GetRoom(),
             sense.GetSensorType())
    End Function

    'delete sensor
    Public Sub DeleteSensor(senseIdx As Integer)
        gSensors.RemoveAt(senseIdx)

        SaveSensors()
    End Sub

    'save sensor
    Public Sub SaveSensors()
        FileOpen(1, gSensorSettingsFile, OpenMode.Output)

        For senseIdx = 0 To gSensors.Count - 1
            Dim sense As Sensor = gSensors(senseIdx)
            sense.Save(1)
        Next

        FileClose(1)
    End Sub

    'restore sensor
    Public Sub RestoreSensors()
        If My.Computer.FileSystem.FileExists(gSensorSettingsFile) = False Then
            Exit Sub
        End If

        FileOpen(1, gSensorSettingsFile, OpenMode.Input)

        Do While Not EOF(1)
            Dim sense As Sensor = New Sensor(1)
            gSensors.Add(sense)

            'update control
            ConfigMod.SensorList.Items.Add(sense.GetName())
        Loop

        FileClose(1)
    End Sub

End Module
