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


        'restore setup from files
        RestoreAppliances()
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'button
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'add appliace button click
    Private Sub AddApplianceButton_Click(sender As Object, e As EventArgs) Handles AddApplianceBt.Click
        If CheckIfValidApplianceName(ApplianceNameTb.Text) = False Then
            Exit Sub
        End If

        If CheckIfValidRPIName(ApplianceRpiTb.Text) = False Then
            Exit Sub
        End If

        ApplianceList.SelectedIndex = -1

        If CreateAppliances(ApplianceNameTb.Text,
                            ApplianceRpiTb.Text,
                            ApplianceGPIONm.Value,
                            ApplianceRoomNm.Value,
                            ApplianceTypeList.SelectedIndex,
                            AppliancePriority.Value) = False Then
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
            SpecialApplianceGrp.Enabled = .Item7
        End With
    End Sub

    'appliance type list
    Private Sub ApplianceTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApplianceTypeList.SelectedIndexChanged
        If ApplianceTypeList.SelectedIndex = -1 Then
            Exit Sub
        End If

        RGLEDList.Enabled = False
        ACList.Enabled = False
        SpeckerList.Enabled = False

        Dim name As String = ApplianceTypeList.SelectedItem.ToString

        RGLEDList.Enabled = (name = "RGB LED")
        ACList.Enabled = (name = "AC")
        SpeckerList.Enabled = (name = "Speaker")
    End Sub

End Class
