
namespace TrainExam1
{
    partial class AdminMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.NewLumberButton = new System.Windows.Forms.Button();
            this.RefreshLumbersButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpdateUButton = new System.Windows.Forms.Button();
            this.searchUBox = new System.Windows.Forms.TextBox();
            this.searchUButton = new System.Windows.Forms.Button();
            this.deleteUBox = new System.Windows.Forms.TextBox();
            this.deleteUButton = new System.Windows.Forms.Button();
            this.RefreshUsersDBButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UpdateWButton = new System.Windows.Forms.Button();
            this.searchWBox = new System.Windows.Forms.TextBox();
            this.searchWButton = new System.Windows.Forms.Button();
            this.deleteWBox = new System.Windows.Forms.TextBox();
            this.deleteWButton = new System.Windows.Forms.Button();
            this.RefreshWorkersDBButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 429);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Пиломатериал";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Размер,См";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 34);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(324, 430);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "№";
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Пользователь";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Пароль";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(0, 34);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(324, 430);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "№";
            this.columnHeader7.Width = 30;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Работник";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Пароль";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список пиломатериалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список пользователей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список работников";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 492);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.SearchButton);
            this.tabPage1.Controls.Add(this.deleteBox);
            this.tabPage1.Controls.Add(this.DeleteRecordButton);
            this.tabPage1.Controls.Add(this.NewLumberButton);
            this.tabPage1.Controls.Add(this.RefreshLumbersButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пиломатериалы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(330, 382);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(322, 81);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Обновить запись";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(330, 295);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(79, 81);
            this.searchBox.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(415, 295);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(239, 81);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Поиск записи";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBox.Location = new System.Drawing.Point(330, 208);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(79, 81);
            this.deleteBox.TabIndex = 9;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteRecordButton.Location = new System.Drawing.Point(415, 208);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(239, 81);
            this.DeleteRecordButton.TabIndex = 8;
            this.DeleteRecordButton.Text = "Удалить запись";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // NewLumberButton
            // 
            this.NewLumberButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewLumberButton.Location = new System.Drawing.Point(330, 121);
            this.NewLumberButton.Name = "NewLumberButton";
            this.NewLumberButton.Size = new System.Drawing.Size(324, 81);
            this.NewLumberButton.TabIndex = 7;
            this.NewLumberButton.Text = "Добавить пиломатериал";
            this.NewLumberButton.UseVisualStyleBackColor = true;
            this.NewLumberButton.Click += new System.EventHandler(this.NewLumberButton_Click);
            // 
            // RefreshLumbersButton
            // 
            this.RefreshLumbersButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshLumbersButton.Location = new System.Drawing.Point(330, 34);
            this.RefreshLumbersButton.Name = "RefreshLumbersButton";
            this.RefreshLumbersButton.Size = new System.Drawing.Size(324, 81);
            this.RefreshLumbersButton.TabIndex = 6;
            this.RefreshLumbersButton.Text = "Обновить информацию";
            this.RefreshLumbersButton.UseVisualStyleBackColor = true;
            this.RefreshLumbersButton.Click += new System.EventHandler(this.RefreshLumbersButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpdateUButton);
            this.tabPage2.Controls.Add(this.searchUBox);
            this.tabPage2.Controls.Add(this.searchUButton);
            this.tabPage2.Controls.Add(this.deleteUBox);
            this.tabPage2.Controls.Add(this.deleteUButton);
            this.tabPage2.Controls.Add(this.RefreshUsersDBButton);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateUButton
            // 
            this.UpdateUButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateUButton.Location = new System.Drawing.Point(330, 295);
            this.UpdateUButton.Name = "UpdateUButton";
            this.UpdateUButton.Size = new System.Drawing.Size(320, 81);
            this.UpdateUButton.TabIndex = 18;
            this.UpdateUButton.Text = "Обновить запись";
            this.UpdateUButton.UseVisualStyleBackColor = true;
            this.UpdateUButton.Click += new System.EventHandler(this.UpdateUButton_Click);
            // 
            // searchUBox
            // 
            this.searchUBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchUBox.Location = new System.Drawing.Point(330, 208);
            this.searchUBox.Name = "searchUBox";
            this.searchUBox.Size = new System.Drawing.Size(79, 81);
            this.searchUBox.TabIndex = 17;
            // 
            // searchUButton
            // 
            this.searchUButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchUButton.Location = new System.Drawing.Point(413, 208);
            this.searchUButton.Name = "searchUButton";
            this.searchUButton.Size = new System.Drawing.Size(239, 81);
            this.searchUButton.TabIndex = 16;
            this.searchUButton.Text = "Поиск пользователя";
            this.searchUButton.UseVisualStyleBackColor = true;
            this.searchUButton.Click += new System.EventHandler(this.searchUButton_Click);
            // 
            // deleteUBox
            // 
            this.deleteUBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUBox.Location = new System.Drawing.Point(330, 121);
            this.deleteUBox.Name = "deleteUBox";
            this.deleteUBox.Size = new System.Drawing.Size(79, 81);
            this.deleteUBox.TabIndex = 15;
            // 
            // deleteUButton
            // 
            this.deleteUButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUButton.Location = new System.Drawing.Point(413, 121);
            this.deleteUButton.Name = "deleteUButton";
            this.deleteUButton.Size = new System.Drawing.Size(239, 81);
            this.deleteUButton.TabIndex = 14;
            this.deleteUButton.Text = "Удалить пользователя";
            this.deleteUButton.UseVisualStyleBackColor = true;
            this.deleteUButton.Click += new System.EventHandler(this.deleteUButton_Click);
            // 
            // RefreshUsersDBButton
            // 
            this.RefreshUsersDBButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshUsersDBButton.Location = new System.Drawing.Point(330, 34);
            this.RefreshUsersDBButton.Name = "RefreshUsersDBButton";
            this.RefreshUsersDBButton.Size = new System.Drawing.Size(322, 81);
            this.RefreshUsersDBButton.TabIndex = 7;
            this.RefreshUsersDBButton.Text = "Обновить информацию";
            this.RefreshUsersDBButton.UseVisualStyleBackColor = true;
            this.RefreshUsersDBButton.Click += new System.EventHandler(this.RefreshUsersDBButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UpdateWButton);
            this.tabPage3.Controls.Add(this.searchWBox);
            this.tabPage3.Controls.Add(this.searchWButton);
            this.tabPage3.Controls.Add(this.deleteWBox);
            this.tabPage3.Controls.Add(this.deleteWButton);
            this.tabPage3.Controls.Add(this.RefreshWorkersDBButton);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(660, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Работники";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UpdateWButton
            // 
            this.UpdateWButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateWButton.Location = new System.Drawing.Point(330, 296);
            this.UpdateWButton.Name = "UpdateWButton";
            this.UpdateWButton.Size = new System.Drawing.Size(325, 81);
            this.UpdateWButton.TabIndex = 18;
            this.UpdateWButton.Text = "Обновить запись";
            this.UpdateWButton.UseVisualStyleBackColor = true;
            this.UpdateWButton.Click += new System.EventHandler(this.UpdateWButton_Click);
            // 
            // searchWBox
            // 
            this.searchWBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchWBox.Location = new System.Drawing.Point(330, 209);
            this.searchWBox.Name = "searchWBox";
            this.searchWBox.Size = new System.Drawing.Size(82, 81);
            this.searchWBox.TabIndex = 17;
            // 
            // searchWButton
            // 
            this.searchWButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchWButton.Location = new System.Drawing.Point(418, 209);
            this.searchWButton.Name = "searchWButton";
            this.searchWButton.Size = new System.Drawing.Size(239, 81);
            this.searchWButton.TabIndex = 16;
            this.searchWButton.Text = "Поиск работника";
            this.searchWButton.UseVisualStyleBackColor = true;
            this.searchWButton.Click += new System.EventHandler(this.searchWButton_Click);
            // 
            // deleteWBox
            // 
            this.deleteWBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteWBox.Location = new System.Drawing.Point(330, 122);
            this.deleteWBox.Name = "deleteWBox";
            this.deleteWBox.Size = new System.Drawing.Size(82, 81);
            this.deleteWBox.TabIndex = 15;
            // 
            // deleteWButton
            // 
            this.deleteWButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteWButton.Location = new System.Drawing.Point(418, 122);
            this.deleteWButton.Name = "deleteWButton";
            this.deleteWButton.Size = new System.Drawing.Size(239, 81);
            this.deleteWButton.TabIndex = 14;
            this.deleteWButton.Text = "Удалить работника";
            this.deleteWButton.UseVisualStyleBackColor = true;
            this.deleteWButton.Click += new System.EventHandler(this.deleteWButton_Click);
            // 
            // RefreshWorkersDBButton
            // 
            this.RefreshWorkersDBButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshWorkersDBButton.Location = new System.Drawing.Point(330, 34);
            this.RefreshWorkersDBButton.Name = "RefreshWorkersDBButton";
            this.RefreshWorkersDBButton.Size = new System.Drawing.Size(327, 82);
            this.RefreshWorkersDBButton.TabIndex = 8;
            this.RefreshWorkersDBButton.Text = "Обновить информацию";
            this.RefreshWorkersDBButton.UseVisualStyleBackColor = true;
            this.RefreshWorkersDBButton.Click += new System.EventHandler(this.RefreshWorkersDBButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewUserButton.Location = new System.Drawing.Point(4, 494);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(660, 58);
            this.NewUserButton.TabIndex = 8;
            this.NewUserButton.Text = "Добавить нового пользователя";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 556);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button RefreshLumbersButton;
        private System.Windows.Forms.Button RefreshUsersDBButton;
        private System.Windows.Forms.Button RefreshWorkersDBButton;
        private System.Windows.Forms.Button NewLumberButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateUButton;
        private System.Windows.Forms.TextBox searchUBox;
        private System.Windows.Forms.Button searchUButton;
        private System.Windows.Forms.TextBox deleteUBox;
        private System.Windows.Forms.Button deleteUButton;
        private System.Windows.Forms.Button UpdateWButton;
        private System.Windows.Forms.TextBox searchWBox;
        private System.Windows.Forms.Button searchWButton;
        private System.Windows.Forms.TextBox deleteWBox;
        private System.Windows.Forms.Button deleteWButton;
    }
}