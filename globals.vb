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


Module globals

    'file/folder paths
    '------------------------------------------------------------------------------------------------------------------------------------------------

    'appliance settings file path
    Public gApplianceSettingsFile = My.Application.Info.DirectoryPath + "\ApplianceSettings.ini"

    'camera settings file path
    Public gCameraSettingsFile = My.Application.Info.DirectoryPath + "\CameraSettings.ini"

    'sensor settings file path
    Public gSensorSettingsFile = My.Application.Info.DirectoryPath + "\SensorSettings.ini"



    'data structures
    '------------------------------------------------------------------------------------------------------------------------------------------------

    'appliance list
    Public gAppliances As List(Of Appliance) = New List(Of Appliance)

    'camera list
    Public gCameras As List(Of Camera) = New List(Of Camera)

    'sensor list
    Public gSensors As List(Of Sensor) = New List(Of Sensor)

End Module
