namespace arm_machine
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.baudrate = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_wl = new System.Windows.Forms.RadioButton();
            this.radioButton_wc = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deactivateSucker = new System.Windows.Forms.Button();
            this.activateSucker = new System.Windows.Forms.Button();
            this.liftup = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.target_theta = new System.Windows.Forms.TextBox();
            this.target_distance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.target_X = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.targetX = new System.Windows.Forms.TextBox();
            this.targetY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baudrate
            // 
            this.baudrate.Location = new System.Drawing.Point(25, 135);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(121, 25);
            this.baudrate.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 394);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(898, 17);
            this.progressBar1.TabIndex = 2;
            // 
            // serialport
            // 
            this.serialport.FormattingEnabled = true;
            this.serialport.Location = new System.Drawing.Point(25, 44);
            this.serialport.Name = "serialport";
            this.serialport.Size = new System.Drawing.Size(121, 23);
            this.serialport.TabIndex = 3;
            this.serialport.SelectedIndexChanged += new System.EventHandler(this.serialport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "baudrate";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(6, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 105);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_wl);
            this.groupBox1.Controls.Add(this.radioButton_wc);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serialport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 364);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialport";
            // 
            // radioButton_wl
            // 
            this.radioButton_wl.AutoSize = true;
            this.radioButton_wl.Checked = true;
            this.radioButton_wl.Location = new System.Drawing.Point(25, 260);
            this.radioButton_wl.Name = "radioButton_wl";
            this.radioButton_wl.Size = new System.Drawing.Size(92, 19);
            this.radioButton_wl.TabIndex = 8;
            this.radioButton_wl.TabStop = true;
            this.radioButton_wl.Text = "wireless";
            this.radioButton_wl.UseVisualStyleBackColor = true;
            // 
            // radioButton_wc
            // 
            this.radioButton_wc.AutoSize = true;
            this.radioButton_wc.Location = new System.Drawing.Point(25, 234);
            this.radioButton_wc.Name = "radioButton_wc";
            this.radioButton_wc.Size = new System.Drawing.Size(108, 19);
            this.radioButton_wc.TabIndex = 7;
            this.radioButton_wc.Text = "with cable";
            this.radioButton_wc.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deactivateSucker);
            this.groupBox2.Controls.Add(this.activateSucker);
            this.groupBox2.Controls.Add(this.liftup);
            this.groupBox2.Controls.Add(this.dropdown);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(239, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 364);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // deactivateSucker
            // 
            this.deactivateSucker.Location = new System.Drawing.Point(135, 314);
            this.deactivateSucker.Name = "deactivateSucker";
            this.deactivateSucker.Size = new System.Drawing.Size(115, 23);
            this.deactivateSucker.TabIndex = 9;
            this.deactivateSucker.Text = "Deactivate";
            this.deactivateSucker.UseVisualStyleBackColor = true;
            this.deactivateSucker.Click += new System.EventHandler(this.deactivateSucker_Click);
            // 
            // activateSucker
            // 
            this.activateSucker.Location = new System.Drawing.Point(135, 285);
            this.activateSucker.Name = "activateSucker";
            this.activateSucker.Size = new System.Drawing.Size(115, 23);
            this.activateSucker.TabIndex = 8;
            this.activateSucker.Text = "Activate";
            this.activateSucker.UseVisualStyleBackColor = true;
            this.activateSucker.Click += new System.EventHandler(this.button5_Click);
            // 
            // liftup
            // 
            this.liftup.Location = new System.Drawing.Point(7, 314);
            this.liftup.Name = "liftup";
            this.liftup.Size = new System.Drawing.Size(115, 23);
            this.liftup.TabIndex = 7;
            this.liftup.Text = "liftup";
            this.liftup.UseVisualStyleBackColor = true;
            this.liftup.Click += new System.EventHandler(this.liftup_Click);
            // 
            // dropdown
            // 
            this.dropdown.Location = new System.Drawing.Point(7, 285);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(115, 23);
            this.dropdown.TabIndex = 6;
            this.dropdown.Text = "dropdown";
            this.dropdown.UseVisualStyleBackColor = true;
            this.dropdown.Click += new System.EventHandler(this.dropdown_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.target_theta);
            this.panel2.Controls.Add(this.target_distance);
            this.panel2.Location = new System.Drawing.Point(6, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 124);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "theta(deg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "distance(mm)";
            // 
            // target_theta
            // 
            this.target_theta.Location = new System.Drawing.Point(129, 18);
            this.target_theta.Name = "target_theta";
            this.target_theta.Size = new System.Drawing.Size(100, 25);
            this.target_theta.TabIndex = 0;
            // 
            // target_distance
            // 
            this.target_distance.Location = new System.Drawing.Point(129, 49);
            this.target_distance.Name = "target_distance";
            this.target_distance.Size = new System.Drawing.Size(100, 25);
            this.target_distance.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.target_X);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.targetX);
            this.panel1.Controls.Add(this.targetY);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 124);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // target_X
            // 
            this.target_X.AutoSize = true;
            this.target_X.Location = new System.Drawing.Point(22, 20);
            this.target_X.Name = "target_X";
            this.target_X.Size = new System.Drawing.Size(47, 15);
            this.target_X.TabIndex = 2;
            this.target_X.Text = "x(mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "y(mm)";
            // 
            // targetX
            // 
            this.targetX.Location = new System.Drawing.Point(129, 17);
            this.targetX.Name = "targetX";
            this.targetX.Size = new System.Drawing.Size(100, 25);
            this.targetX.TabIndex = 0;
            this.targetX.TextChanged += new System.EventHandler(this.targetX_TextChanged);
            // 
            // targetY
            // 
            this.targetY.Location = new System.Drawing.Point(129, 49);
            this.targetY.Name = "targetY";
            this.targetY.Size = new System.Drawing.Size(100, 25);
            this.targetY.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(524, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 364);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "cmd pannel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox baudrate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox serialport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox target_theta;
        private System.Windows.Forms.TextBox target_distance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label target_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetX;
        private System.Windows.Forms.TextBox targetY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deactivateSucker;
        private System.Windows.Forms.Button activateSucker;
        private System.Windows.Forms.Button liftup;
        private System.Windows.Forms.Button dropdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_wl;
        private System.Windows.Forms.RadioButton radioButton_wc;
    }
}

