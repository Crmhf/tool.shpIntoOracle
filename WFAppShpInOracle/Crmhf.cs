using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using XMLConfig;
using System.Data.OleDb;

namespace WFAppShpInOracle
{
    public partial class Crmhf : Form
    {
        public Crmhf()
        {
            InitializeComponent();
            this.txtShpName.AllowDrop = true;
            this.txtShpName.DragDrop += new DragEventHandler(txtShpName_DragDrop);
            bg_worker.DoWork += new DoWorkEventHandler(bg_worker_DoWork);
            bg_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_worker_RunWorkerCompleted);
        }

        void bg_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.rtbLog.Text = rtbLog.Text + e.Result.ToString();
            this.rtbLog.SelectionStart = rtbLog.Text.Length;
            this.rtbLog.ScrollToCaret();
          //  btnOutputAllTable.Text = "导出所有表";
          //  btnOutputAllTable.Enabled = true;
        }

        void bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string command = e.Argument.ToString();
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;



            p.Start();
            p.StandardInput.WriteLine(command);
            p.StandardInput.WriteLine("exit");
            p.WaitForExit();
            string result=p.StandardOutput.ReadToEnd();
            p.Close();
            e.Result = result;           
        }

        void txtShpName_DragDrop(object sender, DragEventArgs e)
        {
            
        }
        /// <summary>
        /// 拖入SHP数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtShpName_DragEnter(object sender, DragEventArgs e)
        {
            if (txtShpName.Text != "") { txtShpName.Text = ""; }

            var strFileList = (string[])(e.Data.GetData(DataFormats.FileDrop));
           
            if (strFileList.Length>0)
            {
                foreach(string oneStr in strFileList)
                {
                    String[] splitArray = oneStr.Split('\\');

                    if (splitArray[splitArray.Length - 1].Length > 4 && splitArray[splitArray.Length - 1].Substring(splitArray[splitArray.Length - 1].Length - 4, 4) == ".shp")
                    {

                        txtShpName.Text += splitArray[splitArray.Length - 1].Substring(0, splitArray[splitArray.Length - 1].Length - 4) + ",";
                    }
                }
            }

            if(txtShpName.Text.Length>0)
            {
                txtShpName.Text = txtShpName.Text.Substring(0, txtShpName.Text.Length-1);
            }
            
            //string[] strFileList;
            //DataSet dsResult;
            //try{
            //    strFileList = (string[])(e.Data.GetData(DataFormats.FileDrop)); 
            //    //得到拖入的文件列表
            //    dsResult = GetAspControls.GetControlIdAndType(strFileList);
            //    if (!(dsResult == null || dsResult.Tables.Count == 0)){
            //        dtResult = dsResult.Tables[0];
            //        for (int i = 1; i < dsResult.Tables.Count; i++)
            //        {dtResult.Merge(dsResult.Tables[i]);}
            //        if (!(dtResult == null || dtResult.Rows.Count == 0))
            //        {dgv.DataSource = dtResult;dgv.AutoResizeColumns();}}
            //}catch (Exception ex)
            //{MessageBox.Show(ex.Message);}finally{dsResult = null;}

        }
/*
    //dosCommand Dos命令语句   
       public string Execute(string dosCommand)  
       {  
           return Execute(dosCommand, 10);  
       }  
       /// <summary>   
       /// 执行DOS命令，返回DOS命令的输出   
       /// </summary>   
       /// <param name="dosCommand">dos命令</param>   
       /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），   
       /// 如果设定为0，则无限等待</param>   
       /// <returns>返回DOS命令的输出</returns>   
       public static string Execute(string command, int seconds)  
       {  
           string output = ""; //输出字符串   
           if (command != null && !command.Equals(""))  
           {  
               Process process = new Process();//创建进程对象   
               ProcessStartInfo startInfo = new ProcessStartInfo();  
               startInfo.FileName = "cmd.exe";//设定需要执行的命令   
               startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出   
               startInfo.UseShellExecute = false;//不使用系统外壳程序启动   
               startInfo.RedirectStandardInput = false;//不重定向输入   
               startInfo.RedirectStandardOutput = true; //重定向输出   
               startInfo.CreateNoWindow = true;//不创建窗口   
               process.StartInfo = startInfo;  
               try  
               {  
                   if (process.Start())//开始进程   
                   {  
                       if (seconds == 0)  
                       {  
                           process.WaitForExit();//这里无限等待进程结束   
                       }  
                       else  
                       {  
                           process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒   
                       }  
                       output = process.StandardOutput.ReadToEnd();//读取进程的输出   
                   }  
               }  
               catch  
               {  
               }  
               finally  
               {  
                   if (process != null)  
                       process.Close();  
               }  
           }  
           return output;  
       }  */
        BackgroundWorker bg_worker = new BackgroundWorker();
        // 执行CMD命令啊
        public void ExecuteCmdBack(string command)
        {
            if (!bg_worker.IsBusy)
           {
               bg_worker.RunWorkerAsync(command);
              
           }
        }


        public void ExecuteCmd(string cmdtext)
        {
            Process MyProcess = new Process();
            //设定程序名 
            MyProcess.StartInfo.FileName = "cmd.exe";
            //关闭Shell的使用 
            MyProcess.StartInfo.UseShellExecute = false;
            //重定向标准输入 
            MyProcess.StartInfo.RedirectStandardInput = true;
            //重定向标准输出 
            MyProcess.StartInfo.RedirectStandardOutput = true;
            //重定向错误输出 
            MyProcess.StartInfo.RedirectStandardError = true;
            //设置不显示窗口 
            MyProcess.StartInfo.CreateNoWindow = true;
            //执行VER命令 
            MyProcess.Start();
            MyProcess.StandardInput.WriteLine(cmdtext);
            MyProcess.StandardInput.WriteLine("exit");
            //从输出流获取命令执行结果， 
            //string exepath = Application.StartupPath; 
            //把返回的DOS信息读出来 
           
            String StrInfo = MyProcess.StandardOutput.ReadToEnd();
            this.rtbLog.Text = rtbLog.Text + StrInfo;
            
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }
        //调用函数,
        public void Exe(string args)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = args;
            //将cmd的标准输入和输出全部重定向到.NET的程序里 
            cmd.StartInfo.RedirectStandardInput = true;//标准输入 
            cmd.StartInfo.RedirectStandardOutput = true;//标准输出 
            cmd.StartInfo.UseShellExecute = false;//此处必须为false否则引发异常 
            //
            cmd.StartInfo.CreateNoWindow = true;//不显示命令行窗口
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
           
            ThreadPool.QueueUserWorkItem(new WaitCallback(ExeThread), cmd);
        }
        private void ExeThread(object obj)
        {
            Process cmd = obj as Process;
            cmd.Start();
            cmd.OutputDataReceived += new DataReceivedEventHandler(cmd_OutputDataReceived);
            cmd.BeginOutputReadLine();
            //
            Application.DoEvents();
            cmd.WaitForExit();
            if (cmd.ExitCode != 0)
            {
                ShowMessage(cmd.StandardOutput.ReadToEnd());
            }
            cmd.Close();
        }
        void cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            ShowMessage(e.Data);
        }
        private delegate void ShowMessageHandler(string msg);
        private void ShowMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ShowMessageHandler(ShowMessage), new object[] { msg });
            }
            else
            {
                if (msg != null)
                {
                    rtbLog.AppendText(msg + "/r/n");
                }
            }
        }


        private void btnMakeSDO_Click(object sender, EventArgs e)
        {
            string[] shpNameList = txtShpName.Text.Split(',');
            for (var i = 0; i < shpNameList.Length; i++) {
                ExecuteCmdBack("shp2sdo " + shpNameList[i] + " " + txtPrefix.Text + "_" + shpNameList[i] + " -i gid -s " + txtGEOM.Text + " -g LOCATION -d");
            }
        }


        /// <summary>
        /// 创建SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeSQL_Click(object sender, EventArgs e)
        {
            ExecuteCmd("if exist run.sql del run.sql");          
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("run.sql", true);
                string[] shpNameList = txtShpName.Text.Split(',');
                for (var i = 0; i < shpNameList.Length; i++)
                {
                    file.WriteLine("@" + txtPrefix.Text + "_" + shpNameList[i] + ".sql");
                }
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMakeTable_Click(object sender, EventArgs e)
        {
            ExecuteCmd("sqlplus " + txtName.Text + "/" + txtPassword.Text + "@" + txtOracleAddress.Text + " <run.sql>  sqlplus.log");
            
        }


        /// <summary>
        /// 创建空间索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeIndex_Click(object sender, EventArgs e)
        {

            ExecuteCmd("if exist runIndex.sql del runIndex.sql");
            System.IO.StreamWriter file = new System.IO.StreamWriter("runIndex.sql", true);
                       
            string[] shpNameList = txtShpName.Text.Split(',');
            for (var i = 0; i < shpNameList.Length; i++)
            {
                file.WriteLine("CREATE INDEX " + txtPrefix.Text+ "_" +shpNameList[i] + "_spatial ON "+ txtPrefix.Text+ "_" +shpNameList[i]+"(LOCATION)  INDEXTYPE IS MDSYS.SPATIAL_INDEX;");
            }          
            file.Close();
            Thread.Sleep(1000);
            ExecuteCmd("sqlplus " + txtName.Text + "/" + txtPassword.Text + "@" + txtOracleAddress.Text + " <runIndex.sql>  createIndex.log");
            /*
            string[] shpNameList = txtShpName.Text.Split(',');
            for (var i = 0; i < shpNameList.Length; i++)
            {
                String commandText = "CREATE INDEX " + txtPrefix.Text + "_" + shpNameList[i] + "_spatial ON " + txtPrefix.Text + "_" + shpNameList[i] + "(LOCATION)  INDEXTYPE IS MDSYS.SPATIAL_INDEX;";
                int SpatialIndex = DBHelperOracle.ExecuteNonQuery(commandText);
            }*/

        }
        /// <summary>
        /// 插入空间数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeData_Click(object sender, EventArgs e)
        {
            string[] shpNameList = txtShpName.Text.Split(',');
            for (var i = 0; i < shpNameList.Length; i++)
            {
                ExecuteCmd("sqlldr " + txtName.Text + "/" + txtPassword.Text + "@" + txtOracleAddress.Text + " " + txtPrefix.Text + "_" + shpNameList[i]);
            }
        }

        /// <summary>
        /// 输出所有新增空间数据的表名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutputTable_Click(object sender, EventArgs e)
        {
            ExecuteCmd("if exist AllTable.txt del AllTable.txt");
            System.IO.StreamWriter file = new System.IO.StreamWriter("AllTable.txt", true);
            string[] shpNameList = txtShpName.Text.Split(',');
            for (var i = 0; i < shpNameList.Length; i++)
            {
                file.WriteLine(txtPrefix.Text + "_" + shpNameList[i]);
            }

            file.Close();
        }

        /// <summary>
        /// 获取Oracle数据库中所有的表名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetTableNamesOracle()
        {
            List<string> tblist = new List<string>();

            try
            {
                string selectTables = @" select t.tbname,b.comments from ( 
                                        select View_Name as tbname from  user_views
                                        union
                                        select Table_Name as tbname from  user_tables) t
                                        left join USER_TAB_COMMENTS b on b.TABLE_NAME=t.tbname order by t.tbname asc";

                /*OleDbDataAdapter da = new OleDbDataAdapter(selectTables, tempmyConn);
                DataTable dt = new DataTable();
                da.Fill(dt);*/

                DataSet ds = DBHelperOracle.GetDataSet(selectTables);
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        string tname = dr["tbname"].ToString();
                        string comment = dr["comments"] == null ? "" : dr["comments"].ToString();
                        if (string.IsNullOrWhiteSpace(comment))
                        {
                            tblist.Add(tname);
                        }
                        else
                        {
                            tblist.Add(tname + "(" + comment + ")");
                        }
                    }
                }
            }
            catch (Exception exp)
            {
 //               TxtLogHelper.m_CreateErrorLogTxt("0", exp.Message);
              
            }
            finally
            {
            }

            return tblist;
        }
        DBHelperOracle dbHelper;
        private void btnGetAllTableName_Click(object sender, EventArgs e)
        {
            dbHelper = new DBHelperOracle(txtOracleAddress.Text, txtName.Text, txtPassword.Text);
            List<string> tableName = GetTableNamesOracle();
            this.comBoxAllTableName.DataSource = tableName;
         }
 
        /// <summary>
        /// 写入项目的XML配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名");
                this.txtName.Focus();
                return;
            }
            if (this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码");
                this.txtPassword.Focus();
                return;
            }
            if (this.txtOracleAddress.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入数据库访问地址");
                this.txtOracleAddress.Focus();
                return;
            }
            if (this.txtGEOM.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入空间坐标");
                this.txtGEOM.Focus();
                return;
            }

            //保存
            SystemConfig.WriteConfigData("UserName", this.txtName.Text.Trim());
            SystemConfig.WriteConfigData("Password", this.txtPassword.Text.Trim());
            SystemConfig.WriteConfigData("OracleDatebase", this.txtOracleAddress.Text.Trim());
            SystemConfig.WriteConfigData("GEOM", this.txtGEOM.Text.Trim());
            SystemConfig.WriteConfigData("TablePrefix", this.txtPrefix.Text.Trim());
            SystemConfig.WriteConfigData("ShpName", this.txtShpName.Text.Trim());

            MessageBox.Show("成功保存到配置文件" + Application.StartupPath + "SystemConfig.xml \n点击【读取配置】按钮进行读取!");

        }

        /// <summary>
        /// 读取项目的XML配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadConfig_Click(object sender, EventArgs e)
        {

            txtName.Text = SystemConfig.GetConfigData("UserName", string.Empty);
            txtPassword.Text = SystemConfig.GetConfigData("Password", string.Empty);
            txtOracleAddress.Text = SystemConfig.GetConfigData("OracleDatebase", string.Empty);
            txtGEOM.Text = SystemConfig.GetConfigData("GEOM", string.Empty);
            txtPrefix.Text = SystemConfig.GetConfigData("TablePrefix", string.Empty);
            txtShpName.Text = SystemConfig.GetConfigData("ShpName", string.Empty);
        }
        /// <summary>
        /// 清空系统日志文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbLog.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }


        

        private void Crmhf_Load(object sender, EventArgs e)
        {
            btnReadConfig_Click(null,null);
        }

        private void btnDelSelectTable_Click(object sender, EventArgs e)
        {   

            string tableName = this.comBoxAllTableName.Text.Split('(')[0];
            string commandText = "drop table " + tableName;
            int delTable = DBHelperOracle.ExecuteNonQuery(commandText);
//           TxtLogHelper.m_CreateErrorLogTxt("1", commandText);

            dbHelper = new DBHelperOracle(txtOracleAddress.Text, txtName.Text, txtPassword.Text);
            List<string> allTableName = GetTableNamesOracle();
            this.comBoxAllTableName.DataSource = allTableName;       
        }

        /// <summary>
       /// 选择输出表的文件夹
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog 黄为 = new FolderBrowserDialog();
            if (黄为.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutputFolder.Text = 黄为.SelectedPath;
            }

        }
        /// <summary>
        ///  导出所有表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutputAllTable_Click(object sender, EventArgs e)
        {
            if (this.txtOutputFolder.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择要输出数据库的地址啊，亲!");
                return;
            }
            string x = "exp " + txtName.Text + "/" + txtPassword.Text + "@" + txtOracleAddress.Text + " file=" + txtOutputFolder.Text + "\\" + txtOutputOracleName.Text + ".dmp log=" + txtOutputFolder.Text + "\\" + txtOutputLog.Text + ".log owner =" + txtName.Text;
            //ExecuteCmd(x);
            //btnOutputAllTable.Text = "正在导出表..";
            //btnOutputAllTable.Enabled = false;
            ExecuteCmdBack(x);
           // Exe(x);
           // MessageBox.Show("ORACLE数据库备份完成！", "提示");
        

        }
        /// <summary>
        /// 导入所有的表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputTableName_Click(object sender, EventArgs e)
        {
            OpenFileDialog 黄为 = new OpenFileDialog();
            if (黄为.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputTableName.Text = 黄为.FileName;
            }
        }
        /// <summary>
        /// 选择导入日志文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputLogFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog 黄为 = new FolderBrowserDialog();
            if (黄为.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputLogFolder.Text = 黄为.SelectedPath;
            }
        }

        /// <summary>
        /// 导入所有表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIutputAllTable_Click(object sender, EventArgs e)
        {
            if (this.txtInputTableName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择要输入数据库文件啊，亲!");
                return;
            }
            if (this.txtInputLogFolder.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择要输入日志地址啊，亲!");
                return;
            }
            if (this.txtInputLogName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入日志名称啊，亲！");
                this.txtInputLogName.Focus();
                return;
            }
            if (this.txtInputTableUser.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入你要导入数据库的原始用户名啊，亲！");
                this.txtInputTableUser.Focus();
                return;
            }
            string x = "imp " + txtName.Text + "/" + txtPassword.Text + "@" + txtOracleAddress.Text + " file=" + txtInputTableName.Text + " log=" + txtInputLogFolder.Text + "\\" + txtInputLogName.Text + ".log fromuser =" + txtInputTableUser.Text + " touser=" + txtName.Text;
            ExecuteCmdBack(x);

        }

        /// <summary>
        /// 系统帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            String help = SystemConfig.GetConfigData("help", string.Empty);
           MessageBox.Show(help, "帮助-By rongc,光光聂",MessageBoxButtons.OK);
        }
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestConnectSQL_Click(object sender, EventArgs e)
        {   
            try 
	            {

                    dbHelper = new DBHelperOracle(txtOracleAddress.Text, txtName.Text, txtPassword.Text);
                    DBHelperOracle.init();
                    MessageBox.Show("数据库连接成功!", "测试结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            }
	            catch (Exception ex)
	            {
                    MessageBox.Show("连接失败: " + ex.Message, "测试结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
            /*
            Try

            'get the selected connection
            Dim strFullConn As String = Me.cboConnections.SelectedItem.ToString
            Dim arrayFullConn() As String = strFullConn.Split("|")
            Dim strDBType As String = arrayFullConn(0).ToUpper
            Dim strDBConnOrig As String = arrayFullConn(1)
            Dim strDBConn As String = arrayFullConn(1)

            'check password
            If Not CheckPassword(strDBConn) Then Exit Sub

            'open the connection based on the connection type
            Dim connSQLServer As SqlConnection = Nothing
            Dim connOracle As OracleConnection = Nothing
            If strDBType = "SQLSERVER" Then
                connSQLServer = New SqlConnection(strDBConn)
                connSQLServer.Open()
                connSQLServer.Close()
            ElseIf strDBType = "ORACLE" Then
                connOracle = New OracleConnection(strDBConn)
                connOracle.Open()
                connOracle.Close()
            End If

            'connection worked - store password
            If Not m_hashPasswords.Contains(strDBConnOrig) Then
                m_hashPasswords.Add(strDBConnOrig, m_strPassword)
            End If

            MessageBox.Show("Connection succeeded", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Connection Failed: " + ex.Message, "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try*/

        }

    }
}
