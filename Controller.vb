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


Imports System.ComponentModel

Public Class Controller

    'form loading
    Private Sub Controller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.ConfigMod.Hide()
    End Sub

    'form closing
    Private Sub Controller_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Forms.ConfigMod.Close()
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'button
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'config button
    Private Sub ConfigBt_Click(sender As Object, e As EventArgs) Handles ConfigBt.Click
        My.Forms.ConfigMod.Show()
        Me.Hide()
    End Sub

End Class