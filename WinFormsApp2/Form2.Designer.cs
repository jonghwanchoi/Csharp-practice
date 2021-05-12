
namespace WinFormsApp2
{
    partial class Form2
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
            this.button_Create = new System.Windows.Forms.Button();
            this.listBox_getMethod = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listBox_getType = new System.Windows.Forms.ListBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.paramBox1 = new System.Windows.Forms.TextBox();
            this.paramBox2 = new System.Windows.Forms.TextBox();
            this.param1 = new System.Windows.Forms.Label();
            this.param2 = new System.Windows.Forms.Label();
            this.methodList = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.selectedTypeBox = new System.Windows.Forms.TextBox();
            this.selectedType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Create.ForeColor = System.Drawing.Color.Black;
            this.button_Create.Location = new System.Drawing.Point(494, 30);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(125, 57);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "버튼 생성";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // listBox_getMethod
            // 
            this.listBox_getMethod.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox_getMethod.ForeColor = System.Drawing.Color.Chocolate;
            this.listBox_getMethod.FormattingEnabled = true;
            this.listBox_getMethod.ItemHeight = 25;
            this.listBox_getMethod.Location = new System.Drawing.Point(81, 56);
            this.listBox_getMethod.Name = "listBox_getMethod";
            this.listBox_getMethod.Size = new System.Drawing.Size(186, 129);
            this.listBox_getMethod.TabIndex = 1;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Delete.ForeColor = System.Drawing.Color.Black;
            this.button_Delete.Location = new System.Drawing.Point(494, 127);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(125, 57);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "초기화";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // listBox_getType
            // 
            this.listBox_getType.FormattingEnabled = true;
            this.listBox_getType.ItemHeight = 25;
            this.listBox_getType.Items.AddRange(new object[] {
            "Profile",
            "Team"});
            this.listBox_getType.Location = new System.Drawing.Point(287, 130);
            this.listBox_getType.Name = "listBox_getType";
            this.listBox_getType.Size = new System.Drawing.Size(186, 54);
            this.listBox_getType.TabIndex = 3;
            this.listBox_getType.SelectedIndexChanged += new System.EventHandler(this.listBox_getType_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.Menu;
            this.resultBox.ForeColor = System.Drawing.Color.Chocolate;
            this.resultBox.Location = new System.Drawing.Point(81, 297);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(392, 128);
            this.resultBox.TabIndex = 4;
            // 
            // paramBox1
            // 
            this.paramBox1.Location = new System.Drawing.Point(81, 241);
            this.paramBox1.Name = "paramBox1";
            this.paramBox1.Size = new System.Drawing.Size(186, 31);
            this.paramBox1.TabIndex = 5;
            // 
            // paramBox2
            // 
            this.paramBox2.Location = new System.Drawing.Point(287, 241);
            this.paramBox2.Name = "paramBox2";
            this.paramBox2.Size = new System.Drawing.Size(186, 31);
            this.paramBox2.TabIndex = 6;
            // 
            // param1
            // 
            this.param1.AutoSize = true;
            this.param1.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.param1.ForeColor = System.Drawing.Color.Black;
            this.param1.Location = new System.Drawing.Point(81, 212);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(0, 23);
            this.param1.TabIndex = 7;
            // 
            // param2
            // 
            this.param2.AutoSize = true;
            this.param2.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.param2.ForeColor = System.Drawing.Color.Black;
            this.param2.Location = new System.Drawing.Point(287, 213);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(0, 23);
            this.param2.TabIndex = 8;
            // 
            // methodList
            // 
            this.methodList.AutoSize = true;
            this.methodList.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.methodList.ForeColor = System.Drawing.Color.Black;
            this.methodList.Location = new System.Drawing.Point(81, 28);
            this.methodList.Name = "methodList";
            this.methodList.Size = new System.Drawing.Size(0, 23);
            this.methodList.TabIndex = 9;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(287, 102);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(117, 23);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "클래스 리스트";
            // 
            // selectedTypeBox
            // 
            this.selectedTypeBox.BackColor = System.Drawing.SystemColors.Menu;
            this.selectedTypeBox.ForeColor = System.Drawing.Color.Chocolate;
            this.selectedTypeBox.Location = new System.Drawing.Point(287, 57);
            this.selectedTypeBox.Name = "selectedTypeBox";
            this.selectedTypeBox.Size = new System.Drawing.Size(186, 31);
            this.selectedTypeBox.TabIndex = 11;
            // 
            // selectedType
            // 
            this.selectedType.AutoSize = true;
            this.selectedType.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedType.ForeColor = System.Drawing.Color.Black;
            this.selectedType.Location = new System.Drawing.Point(287, 30);
            this.selectedType.Name = "selectedType";
            this.selectedType.Size = new System.Drawing.Size(117, 23);
            this.selectedType.TabIndex = 12;
            this.selectedType.Text = "선택한 클래스";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.selectedType);
            this.Controls.Add(this.selectedTypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.methodList);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.paramBox2);
            this.Controls.Add(this.paramBox1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.listBox_getType);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.listBox_getMethod);
            this.Controls.Add(this.button_Create);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoke Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ListBox listBox_getMethod;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ListBox listBox_getType;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox paramBox1;
        private System.Windows.Forms.TextBox paramBox2;
        private System.Windows.Forms.Label param1;
        private System.Windows.Forms.Label param2;
        private System.Windows.Forms.Label methodList;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox selectedTypeBox;
        private System.Windows.Forms.Label selectedType;
    }
}

