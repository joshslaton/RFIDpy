#include "frmMain.h"

using namespace ADSDKDemo;

[STAThread]

int main(array<System::String^>^args)
{
	Application::EnableVisualStyles();//���ÿ��ӻ�����,��Ȼ����ѿ�
	Application::Run(gcnew frmMain());//����һ������,��������Ϣѭ��
	return 0;
}