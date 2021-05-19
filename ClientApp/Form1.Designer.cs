
namespace ClientApp
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IpBox = new System.Windows.Forms.TextBox();
            this.IpSetbtn = new System.Windows.Forms.Button();
            this.IpLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.Findbtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.sendBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(39, 40);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 45);
            this.TimeLabel.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(134, 41);
            this.IpBox.Multiline = true;
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(204, 37);
            this.IpBox.TabIndex = 0;
            // 
            // IpSetbtn
            // 
            this.IpSetbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IpSetbtn.Location = new System.Drawing.Point(344, 41);
            this.IpSetbtn.Name = "IpSetbtn";
            this.IpSetbtn.Size = new System.Drawing.Size(149, 37);
            this.IpSetbtn.TabIndex = 1;
            this.IpSetbtn.Text = "Set";
            this.IpSetbtn.UseVisualStyleBackColor = true;
            this.IpSetbtn.Click += new System.EventHandler(this.IpSetbtn_Click);
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IpLabel.Location = new System.Drawing.Point(28, 47);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(100, 25);
            this.IpLabel.TabIndex = 2;
            this.IpLabel.Text = "Server IP :";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(31, 90);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(97, 25);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "File Path :";
            // 
            // Findbtn
            // 
            this.Findbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Findbtn.Location = new System.Drawing.Point(134, 84);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(102, 37);
            this.Findbtn.TabIndex = 4;
            this.Findbtn.Text = "Find";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(31, 127);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(644, 31);
            this.pathBox.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(31, 183);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(522, 196);
            this.resultBox.TabIndex = 6;
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Startbtn.Location = new System.Drawing.Point(576, 183);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(99, 93);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clearbtn.Location = new System.Drawing.Point(576, 286);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(99, 93);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "CLS";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // sendBar
            // 
            this.sendBar.Location = new System.Drawing.Point(134, 397);
            this.sendBar.Name = "sendBar";
            this.sendBar.Size = new System.Drawing.Size(419, 30);
            this.sendBar.TabIndex = 9;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressLabel.Location = new System.Drawing.Point(28, 397);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(100, 25);
            this.ProgressLabel.TabIndex = 10;
            this.ProgressLabel.Text = "File Send :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgressLabel);
            this.groupBox1.Controls.Add(this.sendBar);
            this.groupBox1.Controls.Add(this.Clearbtn);
            this.groupBox1.Controls.Add(this.Startbtn);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.pathBox);
            this.groupBox1.Controls.Add(this.Findbtn);
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Controls.Add(this.IpLabel);
            this.groupBox1.Controls.Add(this.IpSetbtn);
            this.groupBox1.Controls.Add(this.IpBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 465);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeLabel);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.Button IpSetbtn;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.ProgressBar sendBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

