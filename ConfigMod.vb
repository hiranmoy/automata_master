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


Imports System.IO


Public Class ConfigMod

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'form
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'form loading
    Private Sub ConfigMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'position the window in the middle
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - Me.Height / 2


        'initalize comboxes
        ApplianceTypeList.SelectedIndex = 0
        RGLEDList.SelectedIndex = 0
        ACList.SelectedIndex = 0
        SpeakerList.SelectedIndex = 0
        SensorTypeList.SelectedIndex = 0


        'restore setup from files
        RestoreAppliances()
        RestoreCameras()
        RestoreSensors()
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'button
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'add appliace button
    Private Sub AddApplianceButton_Click(sender As Object, e As EventArgs) Handles AddApplianceBt.Click
        If CheckIfValidName(ApplianceNameTb.Text) = False Then
            Exit Sub
        End If

        If CheckIfValidRPIName(ApplianceRpiTb.Text) = False Then
            Exit Sub
        End If

        Dim attribute As AttributeType = AttributeType.cNone

        If RGLEDList.Enabled Then
            Select Case RGLEDList.SelectedIndex
                Case 0 : attribute = AttributeType.cFlood_Light_10W
            End Select
        ElseIf ACList.Enabled Then
            Select Case ACList.SelectedIndex
                Case 0 : attribute = AttributeType.cVoltas_Window_AC_3Star_2014
            End Select
        ElseIf SpeakerList.Enabled Then
            Select Case SpeakerList.SelectedIndex
                Case 0 : attribute = AttributeType.cF_AND_D_F550X
            End Select
        End If

        ApplianceList.SelectedIndex = -1

        If CreateAppliances(ApplianceNameTb.Text, ApplianceRpiTb.Text, ApplianceGPIONm.Value, ApplianceRoomNm.Value, ApplianceTypeList.SelectedIndex, AppliancePriority.Value, attribute) = False Then
            Exit Sub
        End If
        ApplianceList.Items.Add(ApplianceNameTb.Text)
    End Sub

    'delete appliance
    Private Sub ApplianceDeleteBt_Click(sender As Object, e As EventArgs) Handles ApplianceDeleteBt.Click
        If ApplianceList.SelectedIndex < 0 Then
            Exit Sub
        End If

        DeleteAppliance(ApplianceList.SelectedIndex)

        ApplianceList.Items.RemoveAt(ApplianceList.SelectedIndex)

        'reset appliance controls
        ApplianceList.ResetText()
        ApplianceNameTb.Clear()
        ApplianceRpiTb.Clear()
        ApplianceGPIONm.Value = 21
        ApplianceRoomNm.Value = 0
        ApplianceTypeList.SelectedIndex = 0
        AppliancePriority.Value = 0

        RGLEDList.SelectedIndex = 0
        ACList.SelectedIndex = 0
        SpeakerList.SelectedIndex = 0
    End Sub

    'add camera button
    Private Sub AddCameraBt_Click(sender As Object, e As EventArgs) Handles AddCameraBt.Click
        If CheckIfValidName(CameraNameTb.Text) = False Then
            Exit Sub
        End If

        If CheckIfValidRPIName(CameraRpiTb.Text) = False Then
            Exit Sub
        End If

        If CreateCameras(CameraNameTb.Text, CameraRpiTb.Text, CameraRoomNm.Value, CameraPriority.Value) = False Then
            Exit Sub
        End If
        CameraList.Items.Add(CameraNameTb.Text)
    End Sub

    'delete camera
    Private Sub CameraDeleteBt_Click(sender As Object, e As EventArgs) Handles CameraDeleteBt.Click
        If CameraList.SelectedIndex < 0 Then
            Exit Sub
        End If

        DeleteCamera(CameraList.SelectedIndex)

        CameraList.Items.RemoveAt(CameraList.SelectedIndex)

        'reset appliance controls
        CameraList.ResetText()
        CameraNameTb.Clear()
        CameraRpiTb.Clear()
        CameraRoomNm.Value = 0
        CameraPriority.Value = 0
    End Sub

    'add sensor button
    Private Sub AddSensorBt_Click(sender As Object, e As EventArgs) Handles AddSensorBt.Click
        If CheckIfValidName(SensorNameTb.Text) = False Then
            Exit Sub
        End If

        If CheckIfValidRPIName(SensorRpiTb.Text) = False Then
            Exit Sub
        End If

        If CreateSensors(SensorNameTb.Text, SensorRpiTb.Text, SensorRoomNm.Value, SensorTypeList.SelectedIndex) = False Then
            Exit Sub
        End If
        SensorList.Items.Add(SensorNameTb.Text)
    End Sub

    'delete sensor
    Private Sub SensorDeleteBt_Click(sender As Object, e As EventArgs) Handles SensorDeleteBt.Click
        If SensorList.SelectedIndex < 0 Then
            Exit Sub
        End If

        DeleteSensor(SensorList.SelectedIndex)

        SensorList.Items.RemoveAt(SensorList.SelectedIndex)

        'reset appliance controls
        SensorList.ResetText()
        SensorNameTb.Clear()
        SensorRpiTb.Clear()
        SensorRoomNm.Value = 0
        SensorTypeList.SelectedIndex = -1
    End Sub

    'config done
    Private Sub ConfigDone_Click(sender As Object, e As EventArgs) Handles ConfigDone.Click
        My.Forms.Controller.Show()
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'combobox
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'appliance list
    Private Sub ApplianceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApplianceList.SelectedIndexChanged
        If ApplianceList.SelectedIndex < 0 Then
            Exit Sub
        End If

        With LoadAppliance(ApplianceList.SelectedIndex)
            ApplianceNameTb.Text = .Item1
            ApplianceRpiTb.Text = .Item2
            ApplianceGPIONm.Value = .Item3
            ApplianceRoomNm.Value = .Item4
            ApplianceTypeList.SelectedIndex = .Item5
            AppliancePriority.Value = .Item6

            If .Item7 < 0 Then
                SpecialApplianceGrp.Enabled = False
            Else
                SpecialApplianceGrp.Enabled = True

                RGLEDList.Enabled = False
                ACList.Enabled = False
                SpeakerList.Enabled = False

                Select Case .Item7
                    Case AttributeType.cVoltas_Window_AC_3Star_2014 : ACList.Enabled = True
                    Case AttributeType.cF_AND_D_F550X : SpeakerList.Enabled = True
                    Case AttributeType.cFlood_Light_10W : RGLEDList.Enabled = True
                End Select
            End If
        End With
    End Sub

    'appliance type list
    Private Sub ApplianceTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApplianceTypeList.SelectedIndexChanged
        If ApplianceTypeList.SelectedIndex = -1 Then
            Exit Sub
        End If

        RGLEDList.Enabled = False
        ACList.Enabled = False
        SpeakerList.Enabled = False

        Dim type As String = ApplianceTypeList.SelectedItem.ToString

        RGLEDList.Enabled = (type = "RGB LED")
        ACList.Enabled = (type = "AC")
        SpeakerList.Enabled = (type = "Speaker")
    End Sub

    'camera list
    Private Sub CameraList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CameraList.SelectedIndexChanged
        If CameraList.SelectedIndex < 0 Then
            Exit Sub
        End If

        With LoadCamera(CameraList.SelectedIndex)
            CameraNameTb.Text = .Item1
            CameraRpiTb.Text = .Item2
            CameraRoomNm.Value = .Item3
            CameraPriority.Value = .Item4
        End With
    End Sub

    'sensor list
    Private Sub SensorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SensorList.SelectedIndexChanged
        If SensorList.SelectedIndex < 0 Then
            Exit Sub
        End If

        With LoadSensor(SensorList.SelectedIndex)
            SensorNameTb.Text = .Item1
            SensorRpiTb.Text = .Item2
            SensorRoomNm.Value = .Item3
            SensorTypeList.SelectedIndex = .Item4
        End With
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'timer
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        'check if settings file(s) exist
        Dim settingsDir As DirectoryInfo = New DirectoryInfo(gCurArea)
        Dim settingFiles() As FileInfo = settingsDir.GetFiles("*.ini")
        If settingFiles.Length > 0 Then
            My.Forms.Controller.Show()
        End If
    End Sub

End Class
