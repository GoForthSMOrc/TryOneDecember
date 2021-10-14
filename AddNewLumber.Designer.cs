
namespace TrainExam1
{
    partial class AddNewLumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.newlumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewLumberButton = new System.Windows.Forms.Button();
            this.newsizeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пиломатериал";
            // 
            // newlumberBox
            // 
            this.newlumberBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newlumberBox.Location = new System.Drawing.Point(248, 12);
            this.newlumberBox.Name = "newlumberBox";
            this.newlumberBox.Size = new System.Drawing.Size(344, 44);
            this.newlumberBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер,См";
            // 
            // AddNewLumberButton
            // 
            this.AddNewLumberButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewLumberButton.Location = new System.Drawing.Point(196, 212);
            this.AddNewLumberButton.Name = "AddNewLumberButton";
            this.AddNewLumberButton.Size = new System.Drawing.Size(211, 54);
            this.AddNewLumberButton.TabIndex = 5;
            this.AddNewLumberButton.Text = "Добавить";
            this.AddNewLumberButton.UseVisualStyleBackColor = true;
            this.AddNewLumberButton.Click += new System.EventHandler(this.AddNewLumberButton_Click);
            // 
            // newsizeBox
            // 
            this.newsizeBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newsizeBox.FormattingEnabled = true;
            this.newsizeBox.Items.AddRange(new object[] {
            "50",
            "100",
            "150"});
            this.newsizeBox.Location = new System.Drawing.Point(248, 72);
            this.newsizeBox.Name = "newsizeBox";
            this.newsizeBox.Size = new System.Drawing.Size(344, 44);
            this.newsizeBox.TabIndex = 6;
            // 
            // AddNewLumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 278);
            this.Controls.Add(this.newsizeBox);
            this.Controls.Add(this.AddNewLumberButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newlumberBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewLumber";
            this.Text = "AddNewLumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newlumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNewLumberButton;
        private System.Windows.Forms.ComboBox newsizeBox;
    }
}