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


Public Module enums

    Public Enum ApplianceType
        cOthers = -1
        cBrightLight = 0
        cFan
        cSmallLight
        cMosquitoRepeller
        cPlug
        cAC
        cSpeaker
    End Enum


    Public Enum AttributeType
        cNone = -1
        cVoltas_Window_AC_3Star_2014 = 0
        cF_AND_D_F550X
        cFlood_Light_10W
    End Enum


    Public Enum SensorType
        cNone = -1
        cSenseHat
        cMotionSensor
        cGasSensors
    End Enum

End Module
