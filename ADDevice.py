import os
import clr
import sys
import time

os.system("clear")
# sys.path.append("C:\\Users\\User\\Desktop\\IronPython\\900MHz UHF Reader SDK(Standard)\\GUI\VS\dll")
sys.path.append("C:\\Users\\Technical\\Desktop\\IronPython\\900MHz UHF Reader SDK(Standard)\\GUI\\VS\\dll")
clr.AddReference("ADActiveX.dll")
clr.AddReference("ADBases.dll")
clr.AddReference("ADDevice.dll")
clr.AddReference("ADDeviceReader.dll")
clr.AddReference("ADInitializer.dll")
clr.AddReference("ADWifi.dll")

import ADSDK

adx = ADSDK.ADActiveX()

def showResultState(sString):
    print(sString)

def btnConnect_Click():
    if(not adx.IsConnected):
        adx.Connect("COM3", 9600, 0)
    else:
        adx.DisConnect()
    status = adx.IsConnected if adx.IsConnected else False
    print "Connection State:", status

def btnInformation_Click():
    address = 65535
    Fcount = adx.Information()
    if Fcount == 0:
        showResultState(adx.RecvString)


btnConnect_Click()
btnInformation_Click()

time.sleep(3)
btnConnect_Click()
