#include "frmMain.h"

using namespace ADSDKDemo;

[STAThread]

int main(array<System::String^>^args)
{
	Application::EnableVisualStyles();//启用可视化界面,不然会很难看
	Application::Run(gcnew frmMain());//创建一个窗体,并进入消息循环
	return 0;
}