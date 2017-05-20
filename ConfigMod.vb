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

    Private Sub ConfigMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'position the window in the middle
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - Me.Height / 2
    End Sub

End Class
