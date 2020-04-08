namespace LABA2_OOP
{
    partial class Form1
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
			this.lblPlace = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBoxInfo = new System.Windows.Forms.ListBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBoxCompany = new System.Windows.Forms.ComboBox();
			this.labelFirst = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxBuilding = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxStreet = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCost = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.checkBoxRestored = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonDeserialize = new System.Windows.Forms.Button();
			this.buttonSerialize = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ArchiveTypeCmBx = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPlace
			// 
			this.lblPlace.AutoSize = true;
			this.lblPlace.Location = new System.Drawing.Point(325, 201);
			this.lblPlace.Name = "lblPlace";
			this.lblPlace.Size = new System.Drawing.Size(122, 17);
			this.lblPlace.TabIndex = 85;
			this.lblPlace.Text = "Местоположение";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(311, 436);
			this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(154, 38);
			this.buttonClear.TabIndex = 84;
			this.buttonClear.Text = "Очистить поля";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(75, 477);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 22);
			this.textBox1.TabIndex = 83;
			this.textBox1.Text = "iPhone 7";
			// 
			// listBoxInfo
			// 
			this.listBoxInfo.FormattingEnabled = true;
			this.listBoxInfo.ItemHeight = 16;
			this.listBoxInfo.Items.AddRange(new object[] {
            "Выберите устройство."});
			this.listBoxInfo.Location = new System.Drawing.Point(508, 229);
			this.listBoxInfo.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxInfo.Name = "listBoxInfo";
			this.listBoxInfo.Size = new System.Drawing.Size(275, 180);
			this.listBoxInfo.TabIndex = 82;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(69, 408);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 17);
			this.label12.TabIndex = 81;
			this.label12.Text = "Фирма:";
			// 
			// comboBoxCompany
			// 
			this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.FormattingEnabled = true;
			this.comboBoxCompany.Items.AddRange(new object[] {
            "Не уточнено",
            "Samsung",
            "Apple",
            "Xiaomi",
            "Huawei"});
			this.comboBoxCompany.Location = new System.Drawing.Point(73, 427);
			this.comboBoxCompany.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCompany.TabIndex = 80;
			this.comboBoxCompany.Tag = "";
			this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
			// 
			// labelFirst
			// 
			this.labelFirst.AutoSize = true;
			this.labelFirst.Location = new System.Drawing.Point(69, 457);
			this.labelFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFirst.Name = "labelFirst";
			this.labelFirst.Size = new System.Drawing.Size(62, 17);
			this.labelFirst.TabIndex = 79;
			this.labelFirst.Text = "Модель:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(308, 324);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 17);
			this.label9.TabIndex = 78;
			this.label9.Text = "Дом:";
			// 
			// textBoxBuilding
			// 
			this.textBoxBuilding.Location = new System.Drawing.Point(311, 345);
			this.textBoxBuilding.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxBuilding.Name = "textBoxBuilding";
			this.textBoxBuilding.Size = new System.Drawing.Size(152, 22);
			this.textBoxBuilding.TabIndex = 77;
			this.textBoxBuilding.Text = "12";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(307, 277);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 17);
			this.label6.TabIndex = 76;
			this.label6.Text = "Улица:";
			// 
			// textBoxStreet
			// 
			this.textBoxStreet.Location = new System.Drawing.Point(311, 297);
			this.textBoxStreet.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxStreet.Name = "textBoxStreet";
			this.textBoxStreet.Size = new System.Drawing.Size(152, 22);
			this.textBoxStreet.TabIndex = 75;
			this.textBoxStreet.Text = "Козлова";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(307, 229);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 74;
			this.label7.Text = "Город:";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(311, 249);
			this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(152, 22);
			this.textBoxCity.TabIndex = 73;
			this.textBoxCity.Text = "Минск";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(70, 344);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(205, 17);
			this.label5.TabIndex = 72;
			this.label5.Text = "Ориентировочная стоимость:";
			// 
			// textBoxCost
			// 
			this.textBoxCost.Location = new System.Drawing.Point(72, 365);
			this.textBoxCost.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxCost.Name = "textBoxCost";
			this.textBoxCost.Size = new System.Drawing.Size(152, 22);
			this.textBoxCost.TabIndex = 71;
			this.textBoxCost.Text = "200";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 248);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 70;
			this.label4.Text = "Номер:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(72, 316);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
			this.dateTimePicker1.TabIndex = 69;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(72, 268);
			this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(152, 22);
			this.textBoxNumber.TabIndex = 68;
			this.textBoxNumber.Text = "375333861540";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 296);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 67;
			this.label3.Text = "Дата сдачи:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(72, 220);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(152, 22);
			this.textBoxName.TabIndex = 66;
			this.textBoxName.Text = "Турко А.Ю.";
			// 
			// checkBoxRestored
			// 
			this.checkBoxRestored.AutoSize = true;
			this.checkBoxRestored.Location = new System.Drawing.Point(72, 507);
			this.checkBoxRestored.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxRestored.Name = "checkBoxRestored";
			this.checkBoxRestored.Size = new System.Drawing.Size(149, 21);
			this.checkBoxRestored.TabIndex = 65;
			this.checkBoxRestored.Text = "Восстановленный";
			this.checkBoxRestored.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 202);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 17);
			this.label1.TabIndex = 64;
			this.label1.Text = "Владелец:";
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(508, 83);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(275, 58);
			this.buttonEdit.TabIndex = 3;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(508, 15);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(275, 64);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(508, 148);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(275, 58);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDate,
            this.ColumnAdress});
			this.dataGridView1.Location = new System.Drawing.Point(16, 15);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(468, 167);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Владелец";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 125;
			// 
			// ColumnDate
			// 
			this.ColumnDate.HeaderText = "Дата сдачи";
			this.ColumnDate.MinimumWidth = 6;
			this.ColumnDate.Name = "ColumnDate";
			this.ColumnDate.ReadOnly = true;
			this.ColumnDate.Width = 125;
			// 
			// ColumnAdress
			// 
			this.ColumnAdress.HeaderText = "Адрес";
			this.ColumnAdress.MinimumWidth = 6;
			this.ColumnAdress.Name = "ColumnAdress";
			this.ColumnAdress.ReadOnly = true;
			this.ColumnAdress.Width = 125;
			// 
			// buttonDeserialize
			// 
			this.buttonDeserialize.Location = new System.Drawing.Point(508, 485);
			this.buttonDeserialize.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDeserialize.Name = "buttonDeserialize";
			this.buttonDeserialize.Size = new System.Drawing.Size(279, 37);
			this.buttonDeserialize.TabIndex = 87;
			this.buttonDeserialize.Text = "Загрузить";
			this.buttonDeserialize.UseVisualStyleBackColor = true;
			this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
			// 
			// buttonSerialize
			// 
			this.buttonSerialize.Location = new System.Drawing.Point(508, 436);
			this.buttonSerialize.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSerialize.Name = "buttonSerialize";
			this.buttonSerialize.Size = new System.Drawing.Size(279, 37);
			this.buttonSerialize.TabIndex = 86;
			this.buttonSerialize.Text = "Сериализовать";
			this.buttonSerialize.UseVisualStyleBackColor = true;
			this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ArchiveTypeCmBx
			// 
			this.ArchiveTypeCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ArchiveTypeCmBx.FormattingEnabled = true;
			this.ArchiveTypeCmBx.Items.AddRange(new object[] {
            "Zip",
            "GZip",
            "BZip2"});
			this.ArchiveTypeCmBx.Location = new System.Drawing.Point(563, 530);
			this.ArchiveTypeCmBx.Margin = new System.Windows.Forms.Padding(4);
			this.ArchiveTypeCmBx.Name = "ArchiveTypeCmBx";
			this.ArchiveTypeCmBx.Size = new System.Drawing.Size(161, 24);
			this.ArchiveTypeCmBx.TabIndex = 91;
			this.ArchiveTypeCmBx.SelectedIndexChanged += new System.EventHandler(this.ArchiveTypeCmBx_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 603);
			this.Controls.Add(this.ArchiveTypeCmBx);
			this.Controls.Add(this.buttonDeserialize);
			this.Controls.Add(this.buttonSerialize);
			this.Controls.Add(this.lblPlace);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBoxInfo);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.comboBoxCompany);
			this.Controls.Add(this.labelFirst);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxBuilding);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxStreet);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxCost);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.checkBoxRestored);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Mobile";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxRestored;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdress;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox ArchiveTypeCmBx;
    }
}