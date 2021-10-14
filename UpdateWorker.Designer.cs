
namespace TrainExam1
{
    partial class UpdateWorker
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
            this.logWBox = new System.Windows.Forms.TextBox();
            this.passWBox = new System.Windows.Forms.TextBox();
            this.numberWBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logWBox
            // 
            this.logWBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logWBox.Location = new System.Drawing.Point(163, 52);
            this.logWBox.Name = "logWBox";
            this.logWBox.Size = new System.Drawing.Size(304, 44);
            this.logWBox.TabIndex = 20;
            // 
            // passWBox
            // 
            this.passWBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passWBox.Location = new System.Drawing.Point(473, 52);
            this.passWBox.Name = "passWBox";
            this.passWBox.Size = new System.Drawing.Size(304, 44);
            this.passWBox.TabIndex = 19;
            // 
            // numberWBox
            // 
            this.numberWBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberWBox.Location = new System.Drawing.Point(28, 52);
            this.numberWBox.Name = "numberWBox";
            this.numberWBox.Size = new System.Drawing.Size(100, 44);
            this.numberWBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(536, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "№";
            // 
            // UpdateWButton
            // 
            this.UpdateWButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateWButton.Location = new System.Drawing.Point(263, 117);
            this.UpdateWButton.Name = "UpdateWButton";
            this.UpdateWButton.Size = new System.Drawing.Size(230, 71);
            this.UpdateWButton.TabIndex = 14;
            this.UpdateWButton.Text = "Обновить";
            this.UpdateWButton.UseVisualStyleBackColor = true;
            this.UpdateWButton.Click += new System.EventHandler(this.UpdateWButton_Click);
            // 
            // UpdateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.logWBox);
            this.Controls.Add(this.passWBox);
            this.Controls.Add(this.numberWBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateWButton);
            this.Name = "UpdateWorker";
            this.Text = "UpdateWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logWBox;
        private System.Windows.Forms.TextBox passWBox;
        private System.Windows.Forms.TextBox numberWBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateWButton;
    }
}