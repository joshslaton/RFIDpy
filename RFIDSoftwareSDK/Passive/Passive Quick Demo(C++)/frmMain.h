#pragma once

namespace ADSDKDemo {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace ADSDK;
	using namespace ADSDK::Device;
	using namespace ADSDK::Device::Reader::Passive;
	using namespace std;


	/// <summary>
	/// frmMain 摘要
	/// </summary>
	public ref class frmMain : public System::Windows::Forms::Form
	{
	public:
		frmMain(void)
		{
			InitializeComponent();
			//
			//TODO:  在此处添加构造函数代码
			//
		}

	protected:
		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		~frmMain()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnIdentify6B;
	protected:
	private: System::Windows::Forms::TextBox^  ltxtWriteLength;
	private: System::Windows::Forms::TextBox^  txtport;
	private: System::Windows::Forms::GroupBox^  grbRead;
	private: System::Windows::Forms::TextBox^  ltxtReadLength;
	private: System::Windows::Forms::TextBox^  ltxtReadAddress;
	private: System::Windows::Forms::TextBox^  utxtReadData;
	private: System::Windows::Forms::Button^  btnRead;
	private: System::Windows::Forms::ComboBox^  cmbReadBlock;
	private: System::Windows::Forms::Label^  lblReadBlock;
	private: System::Windows::Forms::Label^  lblReadMark;
	private: System::Windows::Forms::Label^  lblReadAddress;
	private: System::Windows::Forms::Label^  lblReadData;
	private: System::Windows::Forms::Label^  lblReadLength;
	private: System::Windows::Forms::GroupBox^  grbWrite;
	private: System::Windows::Forms::TextBox^  ltxtWriteAddress;
	private: System::Windows::Forms::TextBox^  utxtWriteData;
	private: System::Windows::Forms::Button^  btnWrite;
	private: System::Windows::Forms::ComboBox^  cmbWriteBlock;
	private: System::Windows::Forms::Label^  lblWriteBlock;
	private: System::Windows::Forms::Label^  lblWriteMark;
	private: System::Windows::Forms::Label^  lblWriteAddress;
	private: System::Windows::Forms::Label^  lblWriteLength;
	private: System::Windows::Forms::Label^  lblWriteData;
	private: System::Windows::Forms::GroupBox^  grbIdentify;
	private: System::Windows::Forms::TextBox^  utxtCard;
	private: System::Windows::Forms::Label^  lblCard;
	private: System::Windows::Forms::Button^  btnIdentify;
	private: System::Windows::Forms::Panel^  pnlTitle;
	private: System::Windows::Forms::Button^  btnGetConfig;
	private: System::Windows::Forms::Button^  btnInitPassive;
	private: System::Windows::Forms::Button^  btnInitActive;
	private: System::Windows::Forms::Button^  btnInformation;
	private: System::Windows::Forms::TextBox^  txtIP;
	private: System::Windows::Forms::Button^  btnConnect;
	private: System::Windows::Forms::TextBox^  txtRes;
	private: System::Windows::Forms::Panel^  pnlBody;
	private: System::Windows::Forms::GroupBox^  groupBox3;
	private: System::Windows::Forms::TextBox^  ltxtWriteLength6B;
	private: System::Windows::Forms::TextBox^  ltxtWriteAddress6B;
	private: System::Windows::Forms::TextBox^  utxtWriteData6B;
	private: System::Windows::Forms::Button^  btnWrite6B;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::GroupBox^  groupBox2;
	private: System::Windows::Forms::TextBox^  ltxtReadLength6B;
	private: System::Windows::Forms::TextBox^  ltxtReadAddress6B;
	private: System::Windows::Forms::TextBox^  utxtReadData6B;
	private: System::Windows::Forms::Button^  btnRead6B;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::TextBox^  utxtCard6B;
	private: System::Windows::Forms::Label^  label1;

	protected:

	private:

		ADActiveX ^adx = gcnew ADActiveX();      //通用版

		int FCount = 0;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnIdentify6B = (gcnew System::Windows::Forms::Button());
			this->ltxtWriteLength = (gcnew System::Windows::Forms::TextBox());
			this->txtport = (gcnew System::Windows::Forms::TextBox());
			this->grbRead = (gcnew System::Windows::Forms::GroupBox());
			this->ltxtReadLength = (gcnew System::Windows::Forms::TextBox());
			this->ltxtReadAddress = (gcnew System::Windows::Forms::TextBox());
			this->utxtReadData = (gcnew System::Windows::Forms::TextBox());
			this->btnRead = (gcnew System::Windows::Forms::Button());
			this->cmbReadBlock = (gcnew System::Windows::Forms::ComboBox());
			this->lblReadBlock = (gcnew System::Windows::Forms::Label());
			this->lblReadMark = (gcnew System::Windows::Forms::Label());
			this->lblReadAddress = (gcnew System::Windows::Forms::Label());
			this->lblReadData = (gcnew System::Windows::Forms::Label());
			this->lblReadLength = (gcnew System::Windows::Forms::Label());
			this->grbWrite = (gcnew System::Windows::Forms::GroupBox());
			this->ltxtWriteAddress = (gcnew System::Windows::Forms::TextBox());
			this->utxtWriteData = (gcnew System::Windows::Forms::TextBox());
			this->btnWrite = (gcnew System::Windows::Forms::Button());
			this->cmbWriteBlock = (gcnew System::Windows::Forms::ComboBox());
			this->lblWriteBlock = (gcnew System::Windows::Forms::Label());
			this->lblWriteMark = (gcnew System::Windows::Forms::Label());
			this->lblWriteAddress = (gcnew System::Windows::Forms::Label());
			this->lblWriteLength = (gcnew System::Windows::Forms::Label());
			this->lblWriteData = (gcnew System::Windows::Forms::Label());
			this->grbIdentify = (gcnew System::Windows::Forms::GroupBox());
			this->utxtCard = (gcnew System::Windows::Forms::TextBox());
			this->lblCard = (gcnew System::Windows::Forms::Label());
			this->btnIdentify = (gcnew System::Windows::Forms::Button());
			this->pnlTitle = (gcnew System::Windows::Forms::Panel());
			this->btnGetConfig = (gcnew System::Windows::Forms::Button());
			this->btnInitPassive = (gcnew System::Windows::Forms::Button());
			this->btnInitActive = (gcnew System::Windows::Forms::Button());
			this->btnInformation = (gcnew System::Windows::Forms::Button());
			this->txtIP = (gcnew System::Windows::Forms::TextBox());
			this->btnConnect = (gcnew System::Windows::Forms::Button());
			this->txtRes = (gcnew System::Windows::Forms::TextBox());
			this->pnlBody = (gcnew System::Windows::Forms::Panel());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->ltxtWriteLength6B = (gcnew System::Windows::Forms::TextBox());
			this->ltxtWriteAddress6B = (gcnew System::Windows::Forms::TextBox());
			this->utxtWriteData6B = (gcnew System::Windows::Forms::TextBox());
			this->btnWrite6B = (gcnew System::Windows::Forms::Button());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->ltxtReadLength6B = (gcnew System::Windows::Forms::TextBox());
			this->ltxtReadAddress6B = (gcnew System::Windows::Forms::TextBox());
			this->utxtReadData6B = (gcnew System::Windows::Forms::TextBox());
			this->btnRead6B = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->utxtCard6B = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->grbRead->SuspendLayout();
			this->grbWrite->SuspendLayout();
			this->grbIdentify->SuspendLayout();
			this->pnlTitle->SuspendLayout();
			this->pnlBody->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// btnIdentify6B
			// 
			this->btnIdentify6B->Location = System::Drawing::Point(634, 15);
			this->btnIdentify6B->Name = L"btnIdentify6B";
			this->btnIdentify6B->Size = System::Drawing::Size(120, 30);
			this->btnIdentify6B->TabIndex = 1;
			this->btnIdentify6B->TabStop = false;
			this->btnIdentify6B->Text = L"&Identify";
			this->btnIdentify6B->UseVisualStyleBackColor = true;
			this->btnIdentify6B->Click += gcnew System::EventHandler(this, &frmMain::btnIdentify6B_Click);
			// 
			// ltxtWriteLength
			// 
			this->ltxtWriteLength->Location = System::Drawing::Point(424, 18);
			this->ltxtWriteLength->Name = L"ltxtWriteLength";
			this->ltxtWriteLength->Size = System::Drawing::Size(100, 21);
			this->ltxtWriteLength->TabIndex = 13;
			this->ltxtWriteLength->Text = L"12";
			// 
			// txtport
			// 
			this->txtport->Location = System::Drawing::Point(278, 17);
			this->txtport->Name = L"txtport";
			this->txtport->Size = System::Drawing::Size(74, 21);
			this->txtport->TabIndex = 2;
			this->txtport->Text = L"9600";
			// 
			// grbRead
			// 
			this->grbRead->Controls->Add(this->ltxtReadLength);
			this->grbRead->Controls->Add(this->ltxtReadAddress);
			this->grbRead->Controls->Add(this->utxtReadData);
			this->grbRead->Controls->Add(this->btnRead);
			this->grbRead->Controls->Add(this->cmbReadBlock);
			this->grbRead->Controls->Add(this->lblReadBlock);
			this->grbRead->Controls->Add(this->lblReadMark);
			this->grbRead->Controls->Add(this->lblReadAddress);
			this->grbRead->Controls->Add(this->lblReadData);
			this->grbRead->Controls->Add(this->lblReadLength);
			this->grbRead->Dock = System::Windows::Forms::DockStyle::Top;
			this->grbRead->Location = System::Drawing::Point(0, 52);
			this->grbRead->Name = L"grbRead";
			this->grbRead->Size = System::Drawing::Size(770, 82);
			this->grbRead->TabIndex = 4;
			this->grbRead->TabStop = false;
			this->grbRead->Text = L"EPC(GEN 2) Read";
			// 
			// ltxtReadLength
			// 
			this->ltxtReadLength->Location = System::Drawing::Point(424, 17);
			this->ltxtReadLength->Name = L"ltxtReadLength";
			this->ltxtReadLength->Size = System::Drawing::Size(100, 21);
			this->ltxtReadLength->TabIndex = 12;
			this->ltxtReadLength->Text = L"12";
			// 
			// ltxtReadAddress
			// 
			this->ltxtReadAddress->Location = System::Drawing::Point(250, 18);
			this->ltxtReadAddress->Name = L"ltxtReadAddress";
			this->ltxtReadAddress->Size = System::Drawing::Size(100, 21);
			this->ltxtReadAddress->TabIndex = 11;
			this->ltxtReadAddress->Text = L"02";
			// 
			// utxtReadData
			// 
			this->utxtReadData->Location = System::Drawing::Point(100, 49);
			this->utxtReadData->Name = L"utxtReadData";
			this->utxtReadData->Size = System::Drawing::Size(528, 21);
			this->utxtReadData->TabIndex = 10;
			// 
			// btnRead
			// 
			this->btnRead->Location = System::Drawing::Point(634, 45);
			this->btnRead->Name = L"btnRead";
			this->btnRead->Size = System::Drawing::Size(120, 30);
			this->btnRead->TabIndex = 4;
			this->btnRead->TabStop = false;
			this->btnRead->Text = L"&Read";
			this->btnRead->UseVisualStyleBackColor = true;
			this->btnRead->Click += gcnew System::EventHandler(this, &frmMain::btnRead_Click);
			// 
			// cmbReadBlock
			// 
			this->cmbReadBlock->FormattingEnabled = true;
			this->cmbReadBlock->Items->AddRange(gcnew cli::array< System::Object^  >(4) { L"0-Reserved", L"1-EPC", L"2-TID", L"3-User" });
			this->cmbReadBlock->Location = System::Drawing::Point(100, 18);
			this->cmbReadBlock->Name = L"cmbReadBlock";
			this->cmbReadBlock->Size = System::Drawing::Size(86, 20);
			this->cmbReadBlock->TabIndex = 0;
			this->cmbReadBlock->TabStop = false;
			this->cmbReadBlock->Text = L"1-EPC";
			// 
			// lblReadBlock
			// 
			this->lblReadBlock->AutoSize = true;
			this->lblReadBlock->Location = System::Drawing::Point(12, 22);
			this->lblReadBlock->Name = L"lblReadBlock";
			this->lblReadBlock->Size = System::Drawing::Size(41, 12);
			this->lblReadBlock->TabIndex = 5;
			this->lblReadBlock->Text = L"Block:";
			// 
			// lblReadMark
			// 
			this->lblReadMark->AutoSize = true;
			this->lblReadMark->Location = System::Drawing::Point(549, 22);
			this->lblReadMark->Name = L"lblReadMark";
			this->lblReadMark->Size = System::Drawing::Size(125, 12);
			this->lblReadMark->TabIndex = 8;
			this->lblReadMark->Text = L"(Length not more 16)";
			// 
			// lblReadAddress
			// 
			this->lblReadAddress->AutoSize = true;
			this->lblReadAddress->Location = System::Drawing::Point(194, 22);
			this->lblReadAddress->Name = L"lblReadAddress";
			this->lblReadAddress->Size = System::Drawing::Size(53, 12);
			this->lblReadAddress->TabIndex = 6;
			this->lblReadAddress->Text = L"Address:";
			// 
			// lblReadData
			// 
			this->lblReadData->AutoSize = true;
			this->lblReadData->Location = System::Drawing::Point(12, 52);
			this->lblReadData->Name = L"lblReadData";
			this->lblReadData->Size = System::Drawing::Size(35, 12);
			this->lblReadData->TabIndex = 9;
			this->lblReadData->Text = L"Data:";
			// 
			// lblReadLength
			// 
			this->lblReadLength->AutoSize = true;
			this->lblReadLength->Location = System::Drawing::Point(371, 22);
			this->lblReadLength->Name = L"lblReadLength";
			this->lblReadLength->Size = System::Drawing::Size(47, 12);
			this->lblReadLength->TabIndex = 7;
			this->lblReadLength->Text = L"Length:";
			// 
			// grbWrite
			// 
			this->grbWrite->Controls->Add(this->ltxtWriteLength);
			this->grbWrite->Controls->Add(this->ltxtWriteAddress);
			this->grbWrite->Controls->Add(this->utxtWriteData);
			this->grbWrite->Controls->Add(this->btnWrite);
			this->grbWrite->Controls->Add(this->cmbWriteBlock);
			this->grbWrite->Controls->Add(this->lblWriteBlock);
			this->grbWrite->Controls->Add(this->lblWriteMark);
			this->grbWrite->Controls->Add(this->lblWriteAddress);
			this->grbWrite->Controls->Add(this->lblWriteLength);
			this->grbWrite->Controls->Add(this->lblWriteData);
			this->grbWrite->Dock = System::Windows::Forms::DockStyle::Top;
			this->grbWrite->Location = System::Drawing::Point(0, 134);
			this->grbWrite->Name = L"grbWrite";
			this->grbWrite->Size = System::Drawing::Size(770, 82);
			this->grbWrite->TabIndex = 5;
			this->grbWrite->TabStop = false;
			this->grbWrite->Text = L"EPC(GEN 2) Write";
			// 
			// ltxtWriteAddress
			// 
			this->ltxtWriteAddress->Location = System::Drawing::Point(253, 19);
			this->ltxtWriteAddress->Name = L"ltxtWriteAddress";
			this->ltxtWriteAddress->Size = System::Drawing::Size(100, 21);
			this->ltxtWriteAddress->TabIndex = 12;
			this->ltxtWriteAddress->Text = L"02";
			// 
			// utxtWriteData
			// 
			this->utxtWriteData->Location = System::Drawing::Point(100, 49);
			this->utxtWriteData->Name = L"utxtWriteData";
			this->utxtWriteData->Size = System::Drawing::Size(528, 21);
			this->utxtWriteData->TabIndex = 10;
			// 
			// btnWrite
			// 
			this->btnWrite->Location = System::Drawing::Point(634, 45);
			this->btnWrite->Name = L"btnWrite";
			this->btnWrite->Size = System::Drawing::Size(120, 30);
			this->btnWrite->TabIndex = 4;
			this->btnWrite->TabStop = false;
			this->btnWrite->Text = L"Writ&e";
			this->btnWrite->UseVisualStyleBackColor = true;
			this->btnWrite->Click += gcnew System::EventHandler(this, &frmMain::btnWrite_Click);
			// 
			// cmbWriteBlock
			// 
			this->cmbWriteBlock->FormattingEnabled = true;
			this->cmbWriteBlock->Items->AddRange(gcnew cli::array< System::Object^  >(4) { L"0-Reserved", L"1-EPC", L"2-TID", L"3-User" });
			this->cmbWriteBlock->Location = System::Drawing::Point(100, 18);
			this->cmbWriteBlock->Name = L"cmbWriteBlock";
			this->cmbWriteBlock->Size = System::Drawing::Size(86, 20);
			this->cmbWriteBlock->TabIndex = 0;
			this->cmbWriteBlock->TabStop = false;
			this->cmbWriteBlock->Text = L"1-EPC";
			// 
			// lblWriteBlock
			// 
			this->lblWriteBlock->AutoSize = true;
			this->lblWriteBlock->Location = System::Drawing::Point(12, 22);
			this->lblWriteBlock->Name = L"lblWriteBlock";
			this->lblWriteBlock->Size = System::Drawing::Size(41, 12);
			this->lblWriteBlock->TabIndex = 5;
			this->lblWriteBlock->Text = L"Block:";
			// 
			// lblWriteMark
			// 
			this->lblWriteMark->AutoSize = true;
			this->lblWriteMark->Location = System::Drawing::Point(549, 22);
			this->lblWriteMark->Name = L"lblWriteMark";
			this->lblWriteMark->Size = System::Drawing::Size(221, 12);
			this->lblWriteMark->TabIndex = 8;
			this->lblWriteMark->Text = L"(Address start 2,Length not more 16)";
			// 
			// lblWriteAddress
			// 
			this->lblWriteAddress->AutoSize = true;
			this->lblWriteAddress->Location = System::Drawing::Point(194, 22);
			this->lblWriteAddress->Name = L"lblWriteAddress";
			this->lblWriteAddress->Size = System::Drawing::Size(53, 12);
			this->lblWriteAddress->TabIndex = 6;
			this->lblWriteAddress->Text = L"Address:";
			// 
			// lblWriteLength
			// 
			this->lblWriteLength->AutoSize = true;
			this->lblWriteLength->Location = System::Drawing::Point(371, 22);
			this->lblWriteLength->Name = L"lblWriteLength";
			this->lblWriteLength->Size = System::Drawing::Size(47, 12);
			this->lblWriteLength->TabIndex = 7;
			this->lblWriteLength->Text = L"Length:";
			// 
			// lblWriteData
			// 
			this->lblWriteData->AutoSize = true;
			this->lblWriteData->Location = System::Drawing::Point(12, 52);
			this->lblWriteData->Name = L"lblWriteData";
			this->lblWriteData->Size = System::Drawing::Size(35, 12);
			this->lblWriteData->TabIndex = 9;
			this->lblWriteData->Text = L"Data:";
			// 
			// grbIdentify
			// 
			this->grbIdentify->Controls->Add(this->utxtCard);
			this->grbIdentify->Controls->Add(this->lblCard);
			this->grbIdentify->Controls->Add(this->btnIdentify);
			this->grbIdentify->Dock = System::Windows::Forms::DockStyle::Top;
			this->grbIdentify->Location = System::Drawing::Point(0, 0);
			this->grbIdentify->Name = L"grbIdentify";
			this->grbIdentify->Size = System::Drawing::Size(770, 52);
			this->grbIdentify->TabIndex = 3;
			this->grbIdentify->TabStop = false;
			this->grbIdentify->Text = L"EPC(GEN 2) Identify";
			// 
			// utxtCard
			// 
			this->utxtCard->Location = System::Drawing::Point(100, 19);
			this->utxtCard->Name = L"utxtCard";
			this->utxtCard->Size = System::Drawing::Size(528, 21);
			this->utxtCard->TabIndex = 3;
			// 
			// lblCard
			// 
			this->lblCard->AutoSize = true;
			this->lblCard->Location = System::Drawing::Point(12, 22);
			this->lblCard->Name = L"lblCard";
			this->lblCard->Size = System::Drawing::Size(53, 12);
			this->lblCard->TabIndex = 2;
			this->lblCard->Text = L"Card No:";
			// 
			// btnIdentify
			// 
			this->btnIdentify->Location = System::Drawing::Point(634, 15);
			this->btnIdentify->Name = L"btnIdentify";
			this->btnIdentify->Size = System::Drawing::Size(120, 30);
			this->btnIdentify->TabIndex = 1;
			this->btnIdentify->TabStop = false;
			this->btnIdentify->Text = L"&Identify";
			this->btnIdentify->UseVisualStyleBackColor = true;
			this->btnIdentify->Click += gcnew System::EventHandler(this, &frmMain::btnIdentify_Click);
			// 
			// pnlTitle
			// 
			this->pnlTitle->AutoSize = true;
			this->pnlTitle->Controls->Add(this->btnGetConfig);
			this->pnlTitle->Controls->Add(this->btnInitPassive);
			this->pnlTitle->Controls->Add(this->btnInitActive);
			this->pnlTitle->Controls->Add(this->btnInformation);
			this->pnlTitle->Controls->Add(this->txtport);
			this->pnlTitle->Controls->Add(this->txtIP);
			this->pnlTitle->Controls->Add(this->btnConnect);
			this->pnlTitle->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnlTitle->Location = System::Drawing::Point(0, 0);
			this->pnlTitle->Name = L"pnlTitle";
			this->pnlTitle->Size = System::Drawing::Size(770, 45);
			this->pnlTitle->TabIndex = 5;
			// 
			// btnGetConfig
			// 
			this->btnGetConfig->Location = System::Drawing::Point(661, 12);
			this->btnGetConfig->Name = L"btnGetConfig";
			this->btnGetConfig->Size = System::Drawing::Size(95, 30);
			this->btnGetConfig->TabIndex = 6;
			this->btnGetConfig->TabStop = false;
			this->btnGetConfig->Text = L"GetConfig";
			this->btnGetConfig->UseVisualStyleBackColor = true;
			this->btnGetConfig->Click += gcnew System::EventHandler(this, &frmMain::btnGetConfig_Click);
			// 
			// btnInitPassive
			// 
			this->btnInitPassive->Location = System::Drawing::Point(560, 12);
			this->btnInitPassive->Name = L"btnInitPassive";
			this->btnInitPassive->Size = System::Drawing::Size(95, 30);
			this->btnInitPassive->TabIndex = 5;
			this->btnInitPassive->TabStop = false;
			this->btnInitPassive->Text = L"Init Passive";
			this->btnInitPassive->UseVisualStyleBackColor = true;
			this->btnInitPassive->Click += gcnew System::EventHandler(this, &frmMain::btnInitPassive_Click);
			// 
			// btnInitActive
			// 
			this->btnInitActive->Location = System::Drawing::Point(459, 12);
			this->btnInitActive->Name = L"btnInitActive";
			this->btnInitActive->Size = System::Drawing::Size(95, 30);
			this->btnInitActive->TabIndex = 4;
			this->btnInitActive->TabStop = false;
			this->btnInitActive->Text = L"Init Active";
			this->btnInitActive->UseVisualStyleBackColor = true;
			this->btnInitActive->Click += gcnew System::EventHandler(this, &frmMain::btnInitActive_Click);
			// 
			// btnInformation
			// 
			this->btnInformation->Location = System::Drawing::Point(358, 12);
			this->btnInformation->Name = L"btnInformation";
			this->btnInformation->Size = System::Drawing::Size(95, 30);
			this->btnInformation->TabIndex = 3;
			this->btnInformation->TabStop = false;
			this->btnInformation->Text = L"Information";
			this->btnInformation->UseVisualStyleBackColor = true;
			this->btnInformation->Click += gcnew System::EventHandler(this, &frmMain::btnInformation_Click);
			// 
			// txtIP
			// 
			this->txtIP->Location = System::Drawing::Point(133, 17);
			this->txtIP->Name = L"txtIP";
			this->txtIP->Size = System::Drawing::Size(139, 21);
			this->txtIP->TabIndex = 1;
			this->txtIP->Text = L"COM1";
			// 
			// btnConnect
			// 
			this->btnConnect->Location = System::Drawing::Point(12, 12);
			this->btnConnect->Name = L"btnConnect";
			this->btnConnect->Size = System::Drawing::Size(115, 30);
			this->btnConnect->TabIndex = 0;
			this->btnConnect->Text = L"Connect";
			this->btnConnect->UseVisualStyleBackColor = true;
			this->btnConnect->Click += gcnew System::EventHandler(this, &frmMain::btnConnect_Click);
			// 
			// txtRes
			// 
			this->txtRes->Dock = System::Windows::Forms::DockStyle::Fill;
			this->txtRes->Location = System::Drawing::Point(0, 432);
			this->txtRes->Multiline = true;
			this->txtRes->Name = L"txtRes";
			this->txtRes->Size = System::Drawing::Size(770, 106);
			this->txtRes->TabIndex = 9;
			// 
			// pnlBody
			// 
			this->pnlBody->Controls->Add(this->txtRes);
			this->pnlBody->Controls->Add(this->groupBox3);
			this->pnlBody->Controls->Add(this->groupBox2);
			this->pnlBody->Controls->Add(this->groupBox1);
			this->pnlBody->Controls->Add(this->grbWrite);
			this->pnlBody->Controls->Add(this->grbRead);
			this->pnlBody->Controls->Add(this->grbIdentify);
			this->pnlBody->Dock = System::Windows::Forms::DockStyle::Fill;
			this->pnlBody->Location = System::Drawing::Point(0, 45);
			this->pnlBody->Name = L"pnlBody";
			this->pnlBody->Size = System::Drawing::Size(770, 538);
			this->pnlBody->TabIndex = 4;
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->ltxtWriteLength6B);
			this->groupBox3->Controls->Add(this->ltxtWriteAddress6B);
			this->groupBox3->Controls->Add(this->utxtWriteData6B);
			this->groupBox3->Controls->Add(this->btnWrite6B);
			this->groupBox3->Controls->Add(this->label7);
			this->groupBox3->Controls->Add(this->label8);
			this->groupBox3->Controls->Add(this->label9);
			this->groupBox3->Controls->Add(this->label10);
			this->groupBox3->Controls->Add(this->label11);
			this->groupBox3->Dock = System::Windows::Forms::DockStyle::Top;
			this->groupBox3->Location = System::Drawing::Point(0, 350);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(770, 82);
			this->groupBox3->TabIndex = 8;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"6B Write";
			// 
			// ltxtWriteLength6B
			// 
			this->ltxtWriteLength6B->Location = System::Drawing::Point(424, 18);
			this->ltxtWriteLength6B->Name = L"ltxtWriteLength6B";
			this->ltxtWriteLength6B->Size = System::Drawing::Size(100, 21);
			this->ltxtWriteLength6B->TabIndex = 13;
			this->ltxtWriteLength6B->Text = L"12";
			// 
			// ltxtWriteAddress6B
			// 
			this->ltxtWriteAddress6B->Location = System::Drawing::Point(253, 19);
			this->ltxtWriteAddress6B->Name = L"ltxtWriteAddress6B";
			this->ltxtWriteAddress6B->Size = System::Drawing::Size(100, 21);
			this->ltxtWriteAddress6B->TabIndex = 12;
			this->ltxtWriteAddress6B->Text = L"18";
			// 
			// utxtWriteData6B
			// 
			this->utxtWriteData6B->Location = System::Drawing::Point(100, 49);
			this->utxtWriteData6B->Name = L"utxtWriteData6B";
			this->utxtWriteData6B->Size = System::Drawing::Size(528, 21);
			this->utxtWriteData6B->TabIndex = 10;
			// 
			// btnWrite6B
			// 
			this->btnWrite6B->Location = System::Drawing::Point(634, 45);
			this->btnWrite6B->Name = L"btnWrite6B";
			this->btnWrite6B->Size = System::Drawing::Size(120, 30);
			this->btnWrite6B->TabIndex = 4;
			this->btnWrite6B->TabStop = false;
			this->btnWrite6B->Text = L"Writ&e";
			this->btnWrite6B->UseVisualStyleBackColor = true;
			this->btnWrite6B->Click += gcnew System::EventHandler(this, &frmMain::btnWrite6B_Click);
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(12, 22);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(41, 12);
			this->label7->TabIndex = 5;
			this->label7->Text = L"Block:";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(549, 22);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(221, 12);
			this->label8->TabIndex = 8;
			this->label8->Text = L"(Address start 2,Length not more 16)";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(194, 22);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(53, 12);
			this->label9->TabIndex = 6;
			this->label9->Text = L"Address:";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(371, 22);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(47, 12);
			this->label10->TabIndex = 7;
			this->label10->Text = L"Length:";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(12, 52);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(35, 12);
			this->label11->TabIndex = 9;
			this->label11->Text = L"Data:";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->ltxtReadLength6B);
			this->groupBox2->Controls->Add(this->ltxtReadAddress6B);
			this->groupBox2->Controls->Add(this->utxtReadData6B);
			this->groupBox2->Controls->Add(this->btnRead6B);
			this->groupBox2->Controls->Add(this->label2);
			this->groupBox2->Controls->Add(this->label3);
			this->groupBox2->Controls->Add(this->label4);
			this->groupBox2->Controls->Add(this->label5);
			this->groupBox2->Controls->Add(this->label6);
			this->groupBox2->Dock = System::Windows::Forms::DockStyle::Top;
			this->groupBox2->Location = System::Drawing::Point(0, 268);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(770, 82);
			this->groupBox2->TabIndex = 7;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"6B Read";
			// 
			// ltxtReadLength6B
			// 
			this->ltxtReadLength6B->Location = System::Drawing::Point(424, 17);
			this->ltxtReadLength6B->Name = L"ltxtReadLength6B";
			this->ltxtReadLength6B->Size = System::Drawing::Size(100, 21);
			this->ltxtReadLength6B->TabIndex = 12;
			this->ltxtReadLength6B->Text = L"12";
			// 
			// ltxtReadAddress6B
			// 
			this->ltxtReadAddress6B->Location = System::Drawing::Point(250, 18);
			this->ltxtReadAddress6B->Name = L"ltxtReadAddress6B";
			this->ltxtReadAddress6B->Size = System::Drawing::Size(100, 21);
			this->ltxtReadAddress6B->TabIndex = 11;
			this->ltxtReadAddress6B->Text = L"18";
			// 
			// utxtReadData6B
			// 
			this->utxtReadData6B->Location = System::Drawing::Point(100, 49);
			this->utxtReadData6B->Name = L"utxtReadData6B";
			this->utxtReadData6B->Size = System::Drawing::Size(528, 21);
			this->utxtReadData6B->TabIndex = 10;
			// 
			// btnRead6B
			// 
			this->btnRead6B->Location = System::Drawing::Point(634, 45);
			this->btnRead6B->Name = L"btnRead6B";
			this->btnRead6B->Size = System::Drawing::Size(120, 30);
			this->btnRead6B->TabIndex = 4;
			this->btnRead6B->TabStop = false;
			this->btnRead6B->Text = L"&Read";
			this->btnRead6B->UseVisualStyleBackColor = true;
			this->btnRead6B->Click += gcnew System::EventHandler(this, &frmMain::btnRead6B_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 22);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(41, 12);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Block:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(549, 22);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(125, 12);
			this->label3->TabIndex = 8;
			this->label3->Text = L"(Length not more 16)";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(194, 22);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(53, 12);
			this->label4->TabIndex = 6;
			this->label4->Text = L"Address:";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(12, 52);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(35, 12);
			this->label5->TabIndex = 9;
			this->label5->Text = L"Data:";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(371, 22);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(47, 12);
			this->label6->TabIndex = 7;
			this->label6->Text = L"Length:";
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->utxtCard6B);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Controls->Add(this->btnIdentify6B);
			this->groupBox1->Dock = System::Windows::Forms::DockStyle::Top;
			this->groupBox1->Location = System::Drawing::Point(0, 216);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(770, 52);
			this->groupBox1->TabIndex = 6;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"6B Identify";
			// 
			// utxtCard6B
			// 
			this->utxtCard6B->Location = System::Drawing::Point(100, 19);
			this->utxtCard6B->Name = L"utxtCard6B";
			this->utxtCard6B->Size = System::Drawing::Size(528, 21);
			this->utxtCard6B->TabIndex = 3;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 22);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(53, 12);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Card No:";
			// 
			// frmMain
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(770, 583);
			this->Controls->Add(this->pnlBody);
			this->Controls->Add(this->pnlTitle);
			this->Name = L"frmMain";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Passive Quick Demo";
			this->Load += gcnew System::EventHandler(this, &frmMain::frmMain_Load);
			this->grbRead->ResumeLayout(false);
			this->grbRead->PerformLayout();
			this->grbWrite->ResumeLayout(false);
			this->grbWrite->PerformLayout();
			this->grbIdentify->ResumeLayout(false);
			this->grbIdentify->PerformLayout();
			this->pnlTitle->ResumeLayout(false);
			this->pnlTitle->PerformLayout();
			this->pnlBody->ResumeLayout(false);
			this->pnlBody->PerformLayout();
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		void OnRxRspParsed(System::Object ^sender, ADSDK::Device::ProtocolEventArg ^e);
		void OnStatusConnected(System::Object ^sender, ADSDK::Device::ConnectEventArg ^e);
		delegate void ShowResultStateDelegate(String ^str);

	private: System::Void frmMain_Load(System::Object^  sender, System::EventArgs^  e) {
		adx->RxRspParsed += gcnew ADSDK::Device::ProtocolEventHandler(this, &frmMain::OnRxRspParsed);
		adx->StatusConnected += gcnew ADSDK::Device::ConnectEventHandler(this, &frmMain::OnStatusConnected);
	}

			 
	private: Void ShowResultState(String ^str)
	{
		if (txtRes->Lines->Length > 5000)
		{
			txtRes->Clear();
		}
		txtRes->Text += DateTime::Now + " " + str + Environment::NewLine;

		txtRes->SelectionStart = txtRes->TextLength;
		txtRes->ScrollToCaret();
	}

	private: System::Void btnConnect_Click(System::Object^  sender, System::EventArgs^  e) {

		if (!adx->IsConnected)
		{
			adx->Connect(txtIP->Text, Convert::ToInt32(txtport->Text), 0);
		}
		else
		{
			adx->DisConnect();
		}
		btnConnect->Text = adx->IsConnected ? "DisConnect" : "Connect";
	}

	private: System::Void btnInformation_Click(System::Object^  sender, System::EventArgs^  e) {

		int cAddress = 65535;
		//FCount = adx->Information(ref cAddress, ref cVersion, ref cMode);
		FCount = adx->Information();
		if (FCount == 0)
		{
			ShowResultState(adx->RecvString);
		}
	}

	private: System::Void btnInitActive_Click(System::Object^  sender, System::EventArgs^  e) {

		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);

		if (adx->GetType() == (gcnew ActiveXANET())->GetType())
		{
			//Reference communication protocol
			bytdata = gcnew array<unsigned char>(28) {
				0x1E, 0x01, 0x6E, 0x54, 0x5D,
					0x66, 0x6F, 0x78, 0x82, 0x02,
					0x0A, 0x00, 0x03, 0x00, 0x1E,
					0x0A, 0x0F, 0x01, 0x10, 0x01,
					0x01, 0x02, 0x00, 0x02, 0x00,
					0x00, 0x00, 0x20
			};
		}
		else
		{
			//Reference communication protocol
			bytdata = gcnew array<unsigned char>(28) {
				0x1E, 0x01, 0x6E, 0x54, 0x5D,
					0x66, 0x6F, 0x78, 0x82, 0x02,
					0x0A, 0x00, 0x01, 0x00, 0x1E,
					0x0A, 0x0F, 0x01, 0x10, 0x01,
					0x01, 0x02, 0x00, 0x02, 0x00,
					0x00, 0x00, 0x20
			};
		}
		FCount = adx->pSetConfig(bytdata);

		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnInitPassive_Click(System::Object^  sender, System::EventArgs^  e) {

		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);

		//Reference communication protocol
		bytdata = gcnew array<unsigned char>(28) {
			0x1E, 0x01, 0x6E, 0x54, 0x5D,
				0x66, 0x6F, 0x78, 0x82, 0x03,
				0x0A, 0x00, 0x01, 0x00, 0x1E,
				0x0A, 0x0F, 0x01, 0x10, 0x01,
				0x01, 0x02, 0x00, 0x02, 0x00,
				0x00, 0x00, 0x20
		};
		FCount = adx->pSetConfig(bytdata);

		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnGetConfig_Click(System::Object^  sender, System::EventArgs^  e) {

		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);
		FCount = adx->pGetConfig(bytdata);
		if (FCount == 0)
		{
			ShowResultState(ByteBuilder::ByteArrayToHexString(bytdata));
		}
		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnIdentify_Click(System::Object^  sender, System::EventArgs^  e) {
		utxtCard->Text = "";
		Application::DoEvents();
		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);
		String ^sRst = "";
		FCount = adx->pIdentify6C(bytdata);
		if (FCount == 0)
		{
			utxtCard->Text = ByteBuilder::ByteArrayToHexString(bytdata)->Substring(2);
		}
		else
		{
			utxtCard->Text = adx->GetReturnCode(FCount);
		}
		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnRead_Click(System::Object^  sender, System::EventArgs^  e) {
		utxtReadData->Text = "";
		Application::DoEvents();
		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);

		unsigned char mem = Convert::ToByte(cmbReadBlock->SelectedIndex);
		unsigned char state = Convert::ToByte(ltxtReadAddress->Text);
		unsigned char len = Convert::ToByte(ltxtReadLength->Text);

		FCount = adx->pRead6C(mem, state, len, bytdata);
		if (FCount == 0)
		{
			utxtReadData->Text = ByteBuilder::ByteArrayToHexString(bytdata)->Substring(2);
		}
		else
		{
			utxtReadData->Text = adx->GetReturnCode(FCount);
		}
		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnWrite_Click(System::Object^  sender, System::EventArgs^  e) {
		unsigned char mem = Convert::ToByte(cmbWriteBlock->SelectedIndex);
		unsigned char state = Convert::ToByte(ltxtWriteAddress->Text);
		unsigned char len = Convert::ToByte(ltxtWriteLength->Text);
		array<unsigned char> ^sndData = gcnew array<unsigned char>(28);
		sndData = ByteBuilder::HexStringToByteArray(utxtWriteData->Text->Replace("-", ""));

		FCount = adx->pWrite6C(mem, state, len, sndData);

		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnIdentify6B_Click(System::Object^  sender, System::EventArgs^  e) {
		utxtCard6B->Text = "";
		Application::DoEvents();
		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);

		FCount = adx->pIdentify6B(bytdata);
		if (FCount == 0)
		{
			utxtCard6B->Text = ByteBuilder::ByteArrayToHexString(bytdata)->Substring(2);
		}
		else
		{
			utxtCard6B->Text = adx->GetReturnCode(FCount);
		}

		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnRead6B_Click(System::Object^  sender, System::EventArgs^  e) {
		utxtReadData6B->Text = "";
		Application::DoEvents();
		array<unsigned char> ^bytdata = gcnew array<unsigned char>(28);

		unsigned char state = Convert::ToByte(ltxtReadAddress6B->Text);
		unsigned char len = Convert::ToByte(ltxtReadLength6B->Text);

		FCount = adx->pRead6B(state, len, bytdata);
		if (FCount == 0)
		{
			utxtReadData6B->Text = ByteBuilder::ByteArrayToHexString(bytdata)->Substring(2);
		}
		else
		{
			utxtReadData6B->Text = adx->GetReturnCode(FCount);
		}

		ShowResultState(adx->GetReturnCode(FCount));
	}
	private: System::Void btnWrite6B_Click(System::Object^  sender, System::EventArgs^  e) {
		unsigned char state = Convert::ToByte(ltxtWriteAddress6B->Text);
		unsigned char len = Convert::ToByte(ltxtWriteLength6B->Text);
		array<unsigned char> ^sndData = gcnew array<unsigned char>(28);
		sndData = ByteBuilder::HexStringToByteArray(utxtWriteData6B->Text->Replace("-", ""));


		FCount = adx->pWrite6B(state, len, sndData);

		ShowResultState(adx->GetReturnCode(FCount));
	}
};
}


void ADSDKDemo::frmMain::OnRxRspParsed(System::Object ^sender, ADSDK::Device::ProtocolEventArg ^e)
{
	switch (e->Protocol.Code)
	{
	case PassiveRcp::RCP_CMD_ISO6B_IDEN:
	case PassiveRcp::RCP_CMD_EPC_IDEN:
		if (e->Protocol.Length > 0 && e->Protocol.Type == 0x32)
		{
			array<Object^>^myArray = gcnew array<Object^>(1);
			myArray[0] = ByteBuilder::ByteArrayToHexString(e->Protocol.Payload, 1, e->Protocol.Length - 1);
			this->BeginInvoke(gcnew ShowResultStateDelegate(this, &frmMain::ShowResultState), myArray);
		}
		break;
	}
}


void ADSDKDemo::frmMain::OnStatusConnected(System::Object ^sender, ADSDK::Device::ConnectEventArg ^e)
{
	String^ sMsg = "";
	switch (e->Status)
	{
	case CommState::CONNECT_OK:
		sMsg = "通讯连接正常,设备未确定连接成功,需要发送通讯指令有回复确定!!";
		break;
	case CommState::DISCONNECT_OK:
		sMsg = "断开链接成功!";
		break;
	case CommState::CONNECT_FAIL:
		sMsg = "链接失败!";
		break;
	case CommState::DISCONNECT_FAIL:
		sMsg = "断开成功!";
		break;
	case CommState::DISCONNECT_EXCEPT:
		sMsg = "远程异常断开!";
		break;
	default:
		sMsg = "Others Error!";
		break;
	}
	try
	{
		array<Object^>^myArray = gcnew array<Object^>(1);
		myArray[0] = sMsg;
		this->BeginInvoke(gcnew ShowResultStateDelegate(this, &frmMain::ShowResultState), myArray);
	}
	catch(...)
	{

	}
}
