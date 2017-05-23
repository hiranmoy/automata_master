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


Public Class Camera

    'name
    Private mName As String

    'rpi
    Private mRPI As String

    'room no
    Private mRoom As Integer

    'camera index
    Private mPriority As Integer


    Public Sub New(name As String,
                   rpi As String,
                   room As Integer,
                   priority As Integer)
        mName = name
        Debug.Assert(Not mName.Contains(" "))

        mRPI = rpi
        Debug.Assert(Not mRPI.Contains(" "))

        Debug.Assert(mRoom >= 0)
        mRoom = room

        Debug.Assert(priority >= 0)
        mPriority = priority
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

    'get priority
    Public Function GetPriority() As Integer
        Return mPriority
    End Function


    'set rpi
    Public Sub SetRPI(rpi As String)
        mRPI = rpi
    End Sub

    'set room
    Public Sub SetRoom(room As Integer)
        mRoom = room
    End Sub

    'set priority
    Public Sub SetPriority(priority As Integer)
        mPriority = priority
    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'save/restore functions
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'save
    Public Overridable Sub Save(fileIdx As Integer)
        Print(fileIdx, mName.ToString + "                                        : name" + Environment.NewLine)
        Print(fileIdx, mRPI.ToString + "                                        : rpi name" + Environment.NewLine)
        Print(fileIdx, mRoom.ToString + "                                        : room no" + Environment.NewLine)
        Print(fileIdx, mPriority.ToString + "                                        : priority" + Environment.NewLine)
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

        'priority
        data = LineInput(fileIdx)
        mPriority = CInt(data.Substring(0, 40))

        'end line
        data = LineInput(fileIdx)
        Debug.Assert(data = "--------------------------------------------------")
    End Sub

End Class



Module CameraHelper

    'create camera
    Public Function CreateCameras(name As String,
                                  rpi As String,
                                  room As Integer,
                                  priority As Integer) As Boolean
        Dim cam As Camera

        'check if this camera already exists
        For camIdx = 0 To gCameras.Count - 1
            cam = gCameras(camIdx)
            If cam.GetName() = name Then
                cam.SetRPI(rpi)
                cam.SetRoom(room)
                cam.SetPriority(priority)

                SaveCameras()
                Return False
            End If
        Next

        cam = New Camera(name, rpi, room, priority)
        gCameras.Add(cam)

        SaveCameras()
        Return True
    End Function

    'load camera
    Public Function LoadCamera(camIdx As Integer) As Tuple(Of String, String, Integer, Integer)
        Dim cam As Camera = gCameras(camIdx)

        Return New Tuple(Of String, String, Integer, Integer) _
            (cam.GetName(),
             cam.GetRPI(),
             cam.GetRoom(),
             cam.GetPriority())
    End Function

    'delete camera
    Public Sub DeleteCamera(camIdx As Integer)
        gCameras.RemoveAt(camIdx)

        SaveCameras()
    End Sub

    'save camera
    Public Sub SaveCameras()
        FileOpen(1, gCameraSettingsFile, OpenMode.Output)

        For camIdx = 0 To gCameras.Count - 1
            Dim cam As Camera = gCameras(camIdx)
            cam.Save(1)
        Next

        FileClose(1)
    End Sub

    'restore camera
    Public Sub RestoreCameras()
        If My.Computer.FileSystem.FileExists(gCameraSettingsFile) = False Then
            Exit Sub
        End If

        FileOpen(1, gCameraSettingsFile, OpenMode.Input)

        Do While Not EOF(1)
            Dim cam As Camera = New Camera(1)
            gCameras.Add(cam)

            'update control
            ConfigMod.CameraList.Items.Add(cam.GetName())
        Loop

        FileClose(1)
    End Sub

End Module
