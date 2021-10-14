
namespace TrainExam1
{
    partial class UpdateUser
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
            this.logUBox = new System.Windows.Forms.TextBox();
            this.passUBox = new System.Windows.Forms.TextBox();
            this.numberUBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateUButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logUBox
            // 
            this.logUBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logUBox.Location = new System.Drawing.Point(174, 44);
            this.logUBox.Name = "logUBox";
            this.logUBox.Size = new System.Drawing.Size(304, 44);
            this.logUBox.TabIndex = 13;
            // 
            // passUBox
            // 
            this.passUBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passUBox.Location = new System.Drawing.Point(484, 44);
            this.passUBox.Name = "passUBox";
            this.passUBox.Size = new System.Drawing.Size(304, 44);
            this.passUBox.TabIndex = 12;
            // 
            // numberUBox
            // 
            this.numberUBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberUBox.Location = new System.Drawing.Point(39, 44);
            this.numberUBox.Name = "numberUBox";
            this.numberUBox.Size = new System.Drawing.Size(100, 44);
            this.numberUBox.TabIndex = 11;
            this.numberUBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(215, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(547, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "№";
            // 
            // UpdateUButton
            // 
            this.UpdateUButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateUButton.Location = new System.Drawing.Point(274, 109);
            this.UpdateUButton.Name = "UpdateUButton";
            this.UpdateUButton.Size = new System.Drawing.Size(230, 71);
            this.UpdateUButton.TabIndex = 7;
            this.UpdateUButton.Text = "Обновить";
            this.UpdateUButton.UseVisualStyleBackColor = true;
            this.UpdateUButton.Click += new System.EventHandler(this.UpdateUButton_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.logUBox);
            this.Controls.Add(this.passUBox);
            this.Controls.Add(this.numberUBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateUButton);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logUBox;
        private System.Windows.Forms.TextBox passUBox;
        private System.Windows.Forms.TextBox numberUBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateUButton;
    }
}