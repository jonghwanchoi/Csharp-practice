
namespace ServerApp
{
    partial class Server
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
            this.Openbtn = new System.Windows.Forms.Button();
            this.IpText = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.IpTextLabel = new System.Windows.Forms.Label();
            this.Serverbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ReceiveBar = new System.Windows.Forms.ProgressBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Openbtn
            // 
            this.Openbtn.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Openbtn.Location = new System.Drawing.Point(342, 27);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(150, 40);
            this.Openbtn.TabIndex = 0;
            this.Openbtn.Text = "Set";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // IpText
            // 
            this.IpText.Location = new System.Drawing.Point(183, 27);
            this.IpText.Multiline = true;
            this.IpText.Name = "IpText";
            this.IpText.Size = new System.Drawing.Size(150, 40);
            this.IpText.TabIndex = 1;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(42, 86);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(450, 205);
            this.resultBox.TabIndex = 2;
            // 
            // IpTextLabel
            // 
            this.IpTextLabel.AutoSize = true;
            this.IpTextLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IpTextLabel.Location = new System.Drawing.Point(42, 31);
            this.IpTextLabel.Name = "IpTextLabel";
            this.IpTextLabel.Size = new System.Drawing.Size(132, 32);
            this.IpTextLabel.TabIndex = 3;
            this.IpTextLabel.Text = "경로 설정 :";
            // 
            // Serverbtn
            // 
            this.Serverbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serverbtn.Location = new System.Drawing.Point(42, 354);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(312, 51);
            this.Serverbtn.TabIndex = 4;
            this.Serverbtn.Text = "Start";
            this.Serverbtn.UseVisualStyleBackColor = true;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clearbtn.Location = new System.Drawing.Point(360, 354);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(132, 51);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "CLS";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressLabel.Location = new System.Drawing.Point(42, 305);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(124, 25);
            this.ProgressLabel.TabIndex = 6;
            this.ProgressLabel.Text = "File Receive :";
            // 
            // ReceiveBar
            // 
            this.ReceiveBar.Location = new System.Drawing.Point(172, 305);
            this.ReceiveBar.Name = "ReceiveBar";
            this.ReceiveBar.Size = new System.Drawing.Size(320, 25);
            this.ReceiveBar.TabIndex = 7;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(74, 46);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 45);
            this.TimeLabel.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceiveBar);
            this.groupBox1.Controls.Add(this.ProgressLabel);
            this.groupBox1.Controls.Add(this.Clearbtn);
            this.groupBox1.Controls.Add(this.Serverbtn);
            this.groupBox1.Controls.Add(this.IpTextLabel);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.IpText);
            this.groupBox1.Controls.Add(this.Openbtn);
            this.groupBox1.Location = new System.Drawing.Point(74, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 430);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeLabel);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.TextBox IpText;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label IpTextLabel;
        private System.Windows.Forms.Button Serverbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ProgressBar ReceiveBar;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

