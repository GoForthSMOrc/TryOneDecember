
namespace TrainExam1
{
    partial class NewPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newpassUBox = new System.Windows.Forms.TextBox();
            this.newlogUBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddNewWorkerButton = new System.Windows.Forms.Button();
            this.newpassWBox = new System.Windows.Forms.TextBox();
            this.newlogWBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 369);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newpassUBox);
            this.tabPage1.Controls.Add(this.newlogUBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddNewUserButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новый пользователь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newpassUBox
            // 
            this.newpassUBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newpassUBox.Location = new System.Drawing.Point(131, 114);
            this.newpassUBox.Name = "newpassUBox";
            this.newpassUBox.Size = new System.Drawing.Size(356, 44);
            this.newpassUBox.TabIndex = 4;
            // 
            // newlogUBox
            // 
            this.newlogUBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newlogUBox.Location = new System.Drawing.Point(131, 64);
            this.newlogUBox.Name = "newlogUBox";
            this.newlogUBox.Size = new System.Drawing.Size(356, 44);
            this.newlogUBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-4, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewUserButton.Location = new System.Drawing.Point(145, 281);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(208, 60);
            this.AddNewUserButton.TabIndex = 0;
            this.AddNewUserButton.Text = "Добавить";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddNewWorkerButton);
            this.tabPage2.Controls.Add(this.newpassWBox);
            this.tabPage2.Controls.Add(this.newlogWBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новый работник";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // AddNewWorkerButton
            // 
            this.AddNewWorkerButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewWorkerButton.Location = new System.Drawing.Point(145, 281);
            this.AddNewWorkerButton.Name = "AddNewWorkerButton";
            this.AddNewWorkerButton.Size = new System.Drawing.Size(208, 60);
            this.AddNewWorkerButton.TabIndex = 9;
            this.AddNewWorkerButton.Text = "Добавить";
            this.AddNewWorkerButton.UseVisualStyleBackColor = true;
            this.AddNewWorkerButton.Click += new System.EventHandler(this.AddNewWorkerButton_Click);
            // 
            // newpassWBox
            // 
            this.newpassWBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newpassWBox.Location = new System.Drawing.Point(131, 114);
            this.newpassWBox.Name = "newpassWBox";
            this.newpassWBox.Size = new System.Drawing.Size(356, 44);
            this.newpassWBox.TabIndex = 8;
            // 
            // newlogWBox
            // 
            this.newlogWBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newlogWBox.Location = new System.Drawing.Point(131, 64);
            this.newlogWBox.Name = "newlogWBox";
            this.newlogWBox.Size = new System.Drawing.Size(356, 44);
            this.newlogWBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Логин";
            // 
            // NewPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewPeople";
            this.Text = "NewPeople";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox newpassUBox;
        private System.Windows.Forms.TextBox newlogUBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddNewWorkerButton;
        private System.Windows.Forms.TextBox newpassWBox;
        private System.Windows.Forms.TextBox newlogWBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}