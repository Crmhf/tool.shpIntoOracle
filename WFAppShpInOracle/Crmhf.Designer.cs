namespace WFAppShpInOracle
{
    partial class Crmhf
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crmhf));
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOracleAddress = new System.Windows.Forms.TextBox();
            this.btnMakeSDO = new System.Windows.Forms.Button();
            this.btnMakeSQL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGEOM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtShpName = new System.Windows.Forms.TextBox();
            this.btnMakeTable = new System.Windows.Forms.Button();
            this.btnMakeIndex = new System.Windows.Forms.Button();
            this.btnMakeData = new System.Windows.Forms.Button();
            this.btnOutputTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestConnectSQL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnGetAllTableName = new System.Windows.Forms.Button();
            this.comBoxAllTableName = new System.Windows.Forms.ComboBox();
            this.btnDelSelectTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnIutputAllTable = new System.Windows.Forms.Button();
            this.txtInputTableUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInputLogFolder = new System.Windows.Forms.Button();
            this.txtInputLogName = new System.Windows.Forms.TextBox();
            this.txtInputLogFolder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInputTableName = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInputTableName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnOutputAllTable = new System.Windows.Forms.Button();
            this.txtOutputLog = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutputOracleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(684, 13);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "保存配置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(3, 422);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(789, 200);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(390, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 21);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据库地址：";
            // 
            // txtOracleAddress
            // 
            this.txtOracleAddress.Location = new System.Drawing.Point(88, 55);
            this.txtOracleAddress.Name = "txtOracleAddress";
            this.txtOracleAddress.Size = new System.Drawing.Size(458, 21);
            this.txtOracleAddress.TabIndex = 7;
            // 
            // btnMakeSDO
            // 
            this.btnMakeSDO.Location = new System.Drawing.Point(41, 172);
            this.btnMakeSDO.Name = "btnMakeSDO";
            this.btnMakeSDO.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSDO.TabIndex = 8;
            this.btnMakeSDO.Text = "创建文件";
            this.btnMakeSDO.UseVisualStyleBackColor = true;
            this.btnMakeSDO.Click += new System.EventHandler(this.btnMakeSDO_Click);
            // 
            // btnMakeSQL
            // 
            this.btnMakeSQL.Location = new System.Drawing.Point(122, 172);
            this.btnMakeSQL.Name = "btnMakeSQL";
            this.btnMakeSQL.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSQL.TabIndex = 9;
            this.btnMakeSQL.Text = "创建SQL";
            this.btnMakeSQL.UseVisualStyleBackColor = true;
            this.btnMakeSQL.Click += new System.EventHandler(this.btnMakeSQL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "坐标：";
            // 
            // txtGEOM
            // 
            this.txtGEOM.Location = new System.Drawing.Point(88, 90);
            this.txtGEOM.Name = "txtGEOM";
            this.txtGEOM.Size = new System.Drawing.Size(163, 21);
            this.txtGEOM.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "表前缀：";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(393, 94);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(153, 21);
            this.txtPrefix.TabIndex = 13;
            // 
            // txtShpName
            // 
            this.txtShpName.AllowDrop = true;
            this.txtShpName.Location = new System.Drawing.Point(88, 139);
            this.txtShpName.Name = "txtShpName";
            this.txtShpName.Size = new System.Drawing.Size(687, 21);
            this.txtShpName.TabIndex = 14;
            this.txtShpName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtShpName_DragDrop);
            this.txtShpName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtShpName_DragEnter);
            // 
            // btnMakeTable
            // 
            this.btnMakeTable.Location = new System.Drawing.Point(203, 173);
            this.btnMakeTable.Name = "btnMakeTable";
            this.btnMakeTable.Size = new System.Drawing.Size(75, 23);
            this.btnMakeTable.TabIndex = 15;
            this.btnMakeTable.Text = "创建表";
            this.btnMakeTable.UseVisualStyleBackColor = true;
            this.btnMakeTable.Click += new System.EventHandler(this.btnMakeTable_Click);
            // 
            // btnMakeIndex
            // 
            this.btnMakeIndex.Location = new System.Drawing.Point(284, 173);
            this.btnMakeIndex.Name = "btnMakeIndex";
            this.btnMakeIndex.Size = new System.Drawing.Size(93, 23);
            this.btnMakeIndex.TabIndex = 16;
            this.btnMakeIndex.Text = "创建空间索引";
            this.btnMakeIndex.UseVisualStyleBackColor = true;
            this.btnMakeIndex.Click += new System.EventHandler(this.btnMakeIndex_Click);
            // 
            // btnMakeData
            // 
            this.btnMakeData.Location = new System.Drawing.Point(383, 173);
            this.btnMakeData.Name = "btnMakeData";
            this.btnMakeData.Size = new System.Drawing.Size(75, 23);
            this.btnMakeData.TabIndex = 17;
            this.btnMakeData.Text = "插入数据";
            this.btnMakeData.UseVisualStyleBackColor = true;
            this.btnMakeData.Click += new System.EventHandler(this.btnMakeData_Click);
            // 
            // btnOutputTable
            // 
            this.btnOutputTable.Location = new System.Drawing.Point(638, 167);
            this.btnOutputTable.Name = "btnOutputTable";
            this.btnOutputTable.Size = new System.Drawing.Size(121, 23);
            this.btnOutputTable.TabIndex = 18;
            this.btnOutputTable.Text = "输出所有新增表名";
            this.btnOutputTable.UseVisualStyleBackColor = true;
            this.btnOutputTable.Click += new System.EventHandler(this.btnOutputTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestConnectSQL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnReadConfig);
            this.groupBox1.Controls.Add(this.btnOutputTable);
            this.groupBox1.Controls.Add(this.btnSaveConfig);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 200);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据入库";
            // 
            // btnTestConnectSQL
            // 
            this.btnTestConnectSQL.Location = new System.Drawing.Point(603, 49);
            this.btnTestConnectSQL.Name = "btnTestConnectSQL";
            this.btnTestConnectSQL.Size = new System.Drawing.Size(156, 23);
            this.btnTestConnectSQL.TabIndex = 21;
            this.btnTestConnectSQL.Text = "测试数据库连接";
            this.btnTestConnectSQL.UseVisualStyleBackColor = true;
            this.btnTestConnectSQL.Click += new System.EventHandler(this.btnTestConnectSQL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "请拖入Shp：";
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(603, 13);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(75, 23);
            this.btnReadConfig.TabIndex = 19;
            this.btnReadConfig.Text = "读取配置";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(706, 393);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 21;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnGetAllTableName
            // 
            this.btnGetAllTableName.Location = new System.Drawing.Point(9, 20);
            this.btnGetAllTableName.Name = "btnGetAllTableName";
            this.btnGetAllTableName.Size = new System.Drawing.Size(95, 23);
            this.btnGetAllTableName.TabIndex = 21;
            this.btnGetAllTableName.Text = "获取所有表";
            this.btnGetAllTableName.UseVisualStyleBackColor = true;
            this.btnGetAllTableName.Click += new System.EventHandler(this.btnGetAllTableName_Click);
            // 
            // comBoxAllTableName
            // 
            this.comBoxAllTableName.FormattingEnabled = true;
            this.comBoxAllTableName.Location = new System.Drawing.Point(110, 23);
            this.comBoxAllTableName.Name = "comBoxAllTableName";
            this.comBoxAllTableName.Size = new System.Drawing.Size(176, 20);
            this.comBoxAllTableName.TabIndex = 22;
            // 
            // btnDelSelectTable
            // 
            this.btnDelSelectTable.Location = new System.Drawing.Point(293, 19);
            this.btnDelSelectTable.Name = "btnDelSelectTable";
            this.btnDelSelectTable.Size = new System.Drawing.Size(75, 23);
            this.btnDelSelectTable.TabIndex = 23;
            this.btnDelSelectTable.Text = "删除选中表";
            this.btnDelSelectTable.UseVisualStyleBackColor = true;
            this.btnDelSelectTable.Click += new System.EventHandler(this.btnDelSelectTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelSelectTable);
            this.groupBox2.Controls.Add(this.comBoxAllTableName);
            this.groupBox2.Controls.Add(this.btnGetAllTableName);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 137);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oracle数据库操作";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 212);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(769, 175);
            this.tabControl.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "获取所有表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnIutputAllTable);
            this.tabPage2.Controls.Add(this.txtInputTableUser);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnInputLogFolder);
            this.tabPage2.Controls.Add(this.txtInputLogName);
            this.tabPage2.Controls.Add(this.txtInputLogFolder);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnInputTableName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtInputTableName);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnOutputFolder);
            this.tabPage2.Controls.Add(this.txtOutputFolder);
            this.tabPage2.Controls.Add(this.btnOutputAllTable);
            this.tabPage2.Controls.Add(this.txtOutputLog);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtOutputOracleName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据库导出导入";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnIutputAllTable
            // 
            this.btnIutputAllTable.Location = new System.Drawing.Point(484, 119);
            this.btnIutputAllTable.Name = "btnIutputAllTable";
            this.btnIutputAllTable.Size = new System.Drawing.Size(75, 23);
            this.btnIutputAllTable.TabIndex = 18;
            this.btnIutputAllTable.Text = "导入所有表";
            this.btnIutputAllTable.UseVisualStyleBackColor = true;
            this.btnIutputAllTable.Click += new System.EventHandler(this.btnIutputAllTable_Click);
            // 
            // txtInputTableUser
            // 
            this.txtInputTableUser.Location = new System.Drawing.Point(484, 86);
            this.txtInputTableUser.Name = "txtInputTableUser";
            this.txtInputTableUser.Size = new System.Drawing.Size(158, 21);
            this.txtInputTableUser.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "导入表用户名：";
            // 
            // btnInputLogFolder
            // 
            this.btnInputLogFolder.Location = new System.Drawing.Point(648, 37);
            this.btnInputLogFolder.Name = "btnInputLogFolder";
            this.btnInputLogFolder.Size = new System.Drawing.Size(64, 23);
            this.btnInputLogFolder.TabIndex = 15;
            this.btnInputLogFolder.Text = "请选择";
            this.btnInputLogFolder.UseVisualStyleBackColor = true;
            this.btnInputLogFolder.Click += new System.EventHandler(this.btnInputLogFolder_Click);
            // 
            // txtInputLogName
            // 
            this.txtInputLogName.Location = new System.Drawing.Point(484, 63);
            this.txtInputLogName.Name = "txtInputLogName";
            this.txtInputLogName.Size = new System.Drawing.Size(158, 21);
            this.txtInputLogName.TabIndex = 10;
            // 
            // txtInputLogFolder
            // 
            this.txtInputLogFolder.Location = new System.Drawing.Point(484, 35);
            this.txtInputLogFolder.Name = "txtInputLogFolder";
            this.txtInputLogFolder.Size = new System.Drawing.Size(158, 21);
            this.txtInputLogFolder.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "输入日志文件名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "输入日志文件夹：";
            // 
            // btnInputTableName
            // 
            this.btnInputTableName.Location = new System.Drawing.Point(648, 8);
            this.btnInputTableName.Name = "btnInputTableName";
            this.btnInputTableName.Size = new System.Drawing.Size(64, 23);
            this.btnInputTableName.TabIndex = 12;
            this.btnInputTableName.Text = "请选择";
            this.btnInputTableName.UseVisualStyleBackColor = true;
            this.btnInputTableName.Click += new System.EventHandler(this.btnInputTableName_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "导入表文件：";
            // 
            // txtInputTableName
            // 
            this.txtInputTableName.Location = new System.Drawing.Point(484, 8);
            this.txtInputTableName.Name = "txtInputTableName";
            this.txtInputTableName.Size = new System.Drawing.Size(158, 21);
            this.txtInputTableName.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "导出文件夹：";
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(255, 79);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(64, 23);
            this.btnOutputFolder.TabIndex = 6;
            this.btnOutputFolder.Text = "请选择";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(104, 80);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(131, 21);
            this.txtOutputFolder.TabIndex = 5;
            // 
            // btnOutputAllTable
            // 
            this.btnOutputAllTable.Location = new System.Drawing.Point(104, 119);
            this.btnOutputAllTable.Name = "btnOutputAllTable";
            this.btnOutputAllTable.Size = new System.Drawing.Size(75, 23);
            this.btnOutputAllTable.TabIndex = 4;
            this.btnOutputAllTable.Text = "导出所有表";
            this.btnOutputAllTable.UseVisualStyleBackColor = true;
            this.btnOutputAllTable.Click += new System.EventHandler(this.btnOutputAllTable_Click);
            // 
            // txtOutputLog
            // 
            this.txtOutputLog.Location = new System.Drawing.Point(104, 44);
            this.txtOutputLog.Name = "txtOutputLog";
            this.txtOutputLog.Size = new System.Drawing.Size(131, 21);
            this.txtOutputLog.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "导出日志名：";
            // 
            // txtOutputOracleName
            // 
            this.txtOutputOracleName.Location = new System.Drawing.Point(104, 8);
            this.txtOutputOracleName.Name = "txtOutputOracleName";
            this.txtOutputOracleName.Size = new System.Drawing.Size(131, 21);
            this.txtOutputOracleName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "导出文件名：";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 393);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Text = "查看帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Crmhf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 624);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnMakeData);
            this.Controls.Add(this.btnMakeIndex);
            this.Controls.Add(this.btnMakeTable);
            this.Controls.Add(this.txtShpName);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGEOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeSQL);
            this.Controls.Add(this.btnMakeSDO);
            this.Controls.Add(this.txtOracleAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crmhf";
            this.Text = "Kotei Oracle Tool - 0.5";
            this.Load += new System.EventHandler(this.Crmhf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOracleAddress;
        private System.Windows.Forms.Button btnMakeSDO;
        private System.Windows.Forms.Button btnMakeSQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGEOM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtShpName;
        private System.Windows.Forms.Button btnMakeTable;
        private System.Windows.Forms.Button btnMakeIndex;
        private System.Windows.Forms.Button btnMakeData;
        private System.Windows.Forms.Button btnOutputTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetAllTableName;
        private System.Windows.Forms.ComboBox comBoxAllTableName;
        private System.Windows.Forms.Button btnDelSelectTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOutputLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutputOracleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOutputAllTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnInputLogFolder;
        private System.Windows.Forms.TextBox txtInputLogName;
        private System.Windows.Forms.TextBox txtInputLogFolder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInputTableName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInputTableName;
        private System.Windows.Forms.TextBox txtInputTableUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnIutputAllTable;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTestConnectSQL;
    }
}

