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


Module utils

    'check for valid name
    Public Function CheckIfValidName(name As String) As Boolean
        If name = "" Then
            MsgBox("Name cannot be empty")
            Return False
        End If

        If name.Length > 40 Then
            MsgBox("Name is too long (more than 40 characters)")
            Return False
        End If

        If name.Contains(" ") = True Then
            MsgBox("Name cannot have space character")
            Return False
        End If

        Return True
    End Function

    'check for valid rpi name
    Public Function CheckIfValidRPIName(name As String) As Boolean
        If name = "" Then
            MsgBox("rpi name cannot be empty")
            Return False
        End If

        If name.Length > 20 Then
            MsgBox("rpi name is too long (more than 20 characters)")
            Return False
        End If

        If name.Contains(" ") = True Then
            MsgBox("rpi name cannot have space character")
            Return False
        End If

        Return True
    End Function

End Module
