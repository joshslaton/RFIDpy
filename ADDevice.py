import os
import clr
import sys
import time
import inspect

os.system("cls")

dir = "C:\\Users\\User\\Desktop\\RFIDpy\\RFIDSoftwareSDK\\dll"
dlls = os.listdir("C:\\Users\\User\\Desktop\\RFIDpy\\RFIDSoftwareSDK\\dll")
for dll in dlls:
    if("dll" in dll):
        clr.AddReference(dir+"\\"+dll)
        # print(dir+"\\"+dll)

"""
- WorkMode
- 0=Command, 1-Active
"""
import ADSDK

adx = ADSDK.ADActiveX()
FCount = 1

def ShowResultState(sString):
    print(sString)

def btnConnect_Click():
    if(not adx.IsConnected):
        adx.Connect("COM5", 9600, 0)
    else:
        adx.DisConnect()
    status = adx.IsConnected if adx.IsConnected else False
    print ("Connection State:", status)

def btnInformation_Click():
    address = 65535
    FCount = adx.Information()
    if FCount == 0:
        showResultState(adx.RecvString)

def btnInitActive_Click():
    if(type(adx) == type(ADSDK.ActiveXANET())):
        bytdata = [0x1E, 0x01, 0x6E, 0x54, 0x5D,    # 30,  1,   110  84,  93
					0x66, 0x6F, 0x78, 0x82, 0x02,   # 102, 111, 120, 130, 2
					0x0A, 0x00, 0x03, 0x00, 0x1E,   # 10,  0,   3,   0,   30
					0x0A, 0x0F, 0x01, 0x10, 0x01,   # 10,  15,  1,   16,  1
					0x01, 0x02, 0x00, 0x02, 0x00,   # 1,   2,   0,   2,   0
					0x00, 0x00, 0x20]               # 0,   0,   32
    else:
        bytdata = [0x1E, 0x01, 0x6E, 0x54, 0x5D,    # 30,  1,   110, 84,  93
					0x66, 0x6F, 0x78, 0x82, 0x02,   # 102, 111, 120, 130, 2
					0x0A, 0x00, 0x01, 0x00, 0x1E,   # 10,  0,   1,   0,   30
					0x0A, 0x0F, 0x01, 0x10, 0x01,   # 10,  15,  1,   16,  1
					0x01, 0x02, 0x00, 0x02, 0x00,   # 1,   2,   0,   2,   0
					0x00, 0x00, 0x20]               # 0,   0,   32
    # FCount = adx.pSetConfig(bytdata)
    FCount = 0
    ShowResultState(adx.GetReturnCode(FCount))

def btnInitPassive_Click():
    bytdata = [0x1E, 0x01, 0x6E, 0x54, 0x5D,         # 30,  1,   110, 84,  93
                0x66, 0x6F, 0x78, 0x82, 0x03,       # 102, 111, 120, 130, 3
                0x0A, 0x00, 0x01, 0x00, 0x1E,       # 10,  0,   1,   0,   30
                0x0A, 0x0F, 0x01, 0x10, 0x01,       # 10,  15,  1,   16,  1
                0x01, 0x02, 0x00, 0x02, 0x00,       # 1,   2,   0,   2,   0
                0x00, 0x00, 0x20]                   # 0,   0,   32
    FCount = adx.pSetConfig(bytdata)
    print(FCount)
    ShowResultState(adx.GetReturnCode(FCount))

def btnIdentify_Click():
    print("Identifying....")
    Text = ""

    bytdata = bytearray()
    # print(bytdata)
    # mem = 0x01
    # state = 0x02
    # len = 0x0C
    # int, int, int, byte array[28]
    FCount = adx.pIdentify6C(bytdata)
    print(FCount)
    ShowResultState(adx.GetReturnCode(0))





btnConnect_Click()
# time.sleep(2)
# adxr = ADSDK.Device.Reader.
# ADSDK.Device.Reader.ABasicParameters().Buzzer = 0
# print(ADSDK.Device.Reader.ABasicParameters().Buzzer)
# btnInformation_Click()
# btnInitActive_Click()
btnIdentify_Click()
# btnInitPassive_Click()
btnConnect_Click()
