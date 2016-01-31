namespace KeySimulater
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.status1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comm1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_comport_bitrate = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.comboBox_comport_choose = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.log1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_savetofile = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_clr = new System.Windows.Forms.Button();
            this.button_esc = new System.Windows.Forms.Button();
            this.button_pwr = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.start_avaid_repeat = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.status1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.status1.Location = new System.Drawing.Point(0, 451);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(673, 22);
            this.status1.TabIndex = 0;
            this.status1.Text = "statusStrip1";
            this.status1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.status1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // comm1
            // 
            this.comm1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comm1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_comport_bitrate);
            this.panel1.Controls.Add(this.button_start);
            this.panel1.Controls.Add(this.comboBox_comport_choose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 42);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_comport_bitrate
            // 
            this.comboBox_comport_bitrate.FormattingEnabled = true;
            this.comboBox_comport_bitrate.Location = new System.Drawing.Point(124, 12);
            this.comboBox_comport_bitrate.Name = "comboBox_comport_bitrate";
            this.comboBox_comport_bitrate.Size = new System.Drawing.Size(93, 20);
            this.comboBox_comport_bitrate.TabIndex = 2;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(243, 10);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "打开串口";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // comboBox_comport_choose
            // 
            this.comboBox_comport_choose.FormattingEnabled = true;
            this.comboBox_comport_choose.Location = new System.Drawing.Point(12, 12);
            this.comboBox_comport_choose.Name = "comboBox_comport_choose";
            this.comboBox_comport_choose.Size = new System.Drawing.Size(93, 20);
            this.comboBox_comport_choose.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 409);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 409);
            this.panel2.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.log1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 369);
            this.panel6.TabIndex = 1;
            // 
            // log1
            // 
            this.log1.BackColor = System.Drawing.SystemColors.Info;
            this.log1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log1.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log1.Location = new System.Drawing.Point(0, 0);
            this.log1.Name = "log1";
            this.log1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log1.Size = new System.Drawing.Size(355, 369);
            this.log1.TabIndex = 7;
            this.log1.Text = "";
            this.log1.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_savetofile);
            this.panel5.Controls.Add(this.button_clear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 40);
            this.panel5.TabIndex = 0;
            // 
            // button_savetofile
            // 
            this.button_savetofile.Location = new System.Drawing.Point(113, 6);
            this.button_savetofile.Name = "button_savetofile";
            this.button_savetofile.Size = new System.Drawing.Size(75, 23);
            this.button_savetofile.TabIndex = 1;
            this.button_savetofile.Text = "保存为文件";
            this.button_savetofile.UseVisualStyleBackColor = true;
            this.button_savetofile.Click += new System.EventHandler(this.button_savetofile_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(20, 6);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "清除LOG";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_clr);
            this.panel4.Controls.Add(this.button_esc);
            this.panel4.Controls.Add(this.button_pwr);
            this.panel4.Controls.Add(this.button_right);
            this.panel4.Controls.Add(this.button_menu);
            this.panel4.Controls.Add(this.button_left);
            this.panel4.Controls.Add(this.button_down);
            this.panel4.Controls.Add(this.button_up);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 409);
            this.panel4.TabIndex = 7;
            // 
            // button_clr
            // 
            this.button_clr.Location = new System.Drawing.Point(227, 279);
            this.button_clr.Name = "button_clr";
            this.button_clr.Size = new System.Drawing.Size(60, 60);
            this.button_clr.TabIndex = 7;
            this.button_clr.Text = "清零";
            this.button_clr.UseVisualStyleBackColor = true;
            this.button_clr.Click += new System.EventHandler(this.button_clr_Click);
            // 
            // button_esc
            // 
            this.button_esc.Location = new System.Drawing.Point(22, 279);
            this.button_esc.Name = "button_esc";
            this.button_esc.Size = new System.Drawing.Size(60, 60);
            this.button_esc.TabIndex = 6;
            this.button_esc.Text = "返回";
            this.button_esc.UseVisualStyleBackColor = true;
            this.button_esc.Click += new System.EventHandler(this.button_esc_Click);
            // 
            // button_pwr
            // 
            this.button_pwr.Location = new System.Drawing.Point(124, 320);
            this.button_pwr.Name = "button_pwr";
            this.button_pwr.Size = new System.Drawing.Size(60, 60);
            this.button_pwr.TabIndex = 5;
            this.button_pwr.Text = "开关机";
            this.button_pwr.UseVisualStyleBackColor = true;
            this.button_pwr.Click += new System.EventHandler(this.button_pwr_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(215, 113);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(60, 60);
            this.button_right.TabIndex = 4;
            this.button_right.Text = "向右";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(124, 113);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(60, 60);
            this.button_menu.TabIndex = 3;
            this.button_menu.Text = "确定";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(32, 113);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(60, 60);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "向左";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(124, 190);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(60, 60);
            this.button_down.TabIndex = 1;
            this.button_down.Text = "向下";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(124, 35);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(60, 60);
            this.button_up.TabIndex = 0;
            this.button_up.Text = " 向上";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // start_avaid_repeat
            // 
            this.start_avaid_repeat.Interval = 500;
            this.start_avaid_repeat.Tick += new System.EventHandler(this.start_avaid_repeat_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "TXT";
            this.saveFileDialog1.FileName = "log.TXT";
            this.saveFileDialog1.Filter = "\"仪表log文件|*.txt\"";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status1);
            this.Name = "FrmMain";
            this.Text = "按键模拟器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.status1.ResumeLayout(false);
            this.status1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status1;
        private System.IO.Ports.SerialPort comm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_comport_choose;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ComboBox comboBox_comport_bitrate;
        private System.Windows.Forms.Timer start_avaid_repeat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_clr;
        private System.Windows.Forms.Button button_esc;
        private System.Windows.Forms.Button button_pwr;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox log1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_savetofile;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

