
namespace AsyncFileOWinForm
{
    partial class MainForm
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
            this.Page1_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Page2_ButtonP = new System.Windows.Forms.Button();
            this.Page2_ButtonN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Page3_ButtonP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page1_Button
            // 
            this.Page1_Button.Location = new System.Drawing.Point(661, 326);
            this.Page1_Button.Name = "Page1_Button";
            this.Page1_Button.Size = new System.Drawing.Size(108, 65);
            this.Page1_Button.TabIndex = 2;
            this.Page1_Button.Text = "Next";
            this.Page1_Button.UseVisualStyleBackColor = true;
            this.Page1_Button.Click += new System.EventHandler(this.Page1_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 263);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(194, 326);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(412, 64);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Page2_ButtonN);
            this.panel1.Controls.Add(this.Page2_ButtonP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "페이지2";
            // 
            // Page2_ButtonP
            // 
            this.Page2_ButtonP.Location = new System.Drawing.Point(90, 313);
            this.Page2_ButtonP.Name = "Page2_ButtonP";
            this.Page2_ButtonP.Size = new System.Drawing.Size(124, 62);
            this.Page2_ButtonP.TabIndex = 1;
            this.Page2_ButtonP.Text = "Previous";
            this.Page2_ButtonP.UseVisualStyleBackColor = true;
            this.Page2_ButtonP.Click += new System.EventHandler(this.Page2_ButtonP_Click);
            // 
            // Page2_ButtonN
            // 
            this.Page2_ButtonN.Location = new System.Drawing.Point(612, 313);
            this.Page2_ButtonN.Name = "Page2_ButtonN";
            this.Page2_ButtonN.Size = new System.Drawing.Size(124, 62);
            this.Page2_ButtonN.TabIndex = 2;
            this.Page2_ButtonN.Text = "Next";
            this.Page2_ButtonN.UseVisualStyleBackColor = true;
            this.Page2_ButtonN.Click += new System.EventHandler(this.Page2_ButtonN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Page3_ButtonP);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "페이지3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 134);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Page3_ButtonP
            // 
            this.Page3_ButtonP.Location = new System.Drawing.Point(81, 323);
            this.Page3_ButtonP.Name = "Page3_ButtonP";
            this.Page3_ButtonP.Size = new System.Drawing.Size(113, 51);
            this.Page3_ButtonP.TabIndex = 2;
            this.Page3_ButtonP.Text = "Previous";
            this.Page3_ButtonP.UseVisualStyleBackColor = true;
            this.Page3_ButtonP.Click += new System.EventHandler(this.Page3_ButtonP_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Page1_Button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Page1_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Page2_ButtonN;
        private System.Windows.Forms.Button Page2_ButtonP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Page3_ButtonP;
    }
}

