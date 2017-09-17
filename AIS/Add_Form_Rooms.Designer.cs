namespace AIS
{
    partial class Add_Form_Rooms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label housing_idLabel;
            System.Windows.Forms.Label room_nameLabel;
            System.Windows.Forms.Label Label_aud_num;
            System.Windows.Forms.Label Label_pom_num;
            System.Windows.Forms.Label room_heightLabel;
            System.Windows.Forms.Label room_lenghtLabel;
            System.Windows.Forms.Label room_widthLabel;
            System.Windows.Forms.Label room_floor_numLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_houisng = new System.Windows.Forms.ComboBox();
            this.housingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_AISDataSet2 = new AIS.Db_AISDataSet2();
            this.comboBox_secured = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_AISDataSet1 = new AIS.Db_AISDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label_seats = new System.Windows.Forms.Label();
            this.textBox_seats = new System.Windows.Forms.TextBox();
            this.textBox_square = new System.Windows.Forms.TextBox();
            this.label_square = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_room_equipment = new System.Windows.Forms.RichTextBox();
            this.comboBox_roomfloor = new System.Windows.Forms.ComboBox();
            this.room_nameTextBox = new System.Windows.Forms.TextBox();
            this.TextBox_aud_num = new System.Windows.Forms.TextBox();
            this.TextBox_pom_num = new System.Windows.Forms.TextBox();
            this.room_heightTextBox = new System.Windows.Forms.TextBox();
            this.room_lenghtTextBox = new System.Windows.Forms.TextBox();
            this.room_widthTextBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.housingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housingTableAdapter = new AIS.Db_AISDataSet2TableAdapters.HousingTableAdapter();
            this.unitsTableAdapter = new AIS.Db_AISDataSet1TableAdapters.UnitsTableAdapter();
            this.dbAISDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            housing_idLabel = new System.Windows.Forms.Label();
            room_nameLabel = new System.Windows.Forms.Label();
            Label_aud_num = new System.Windows.Forms.Label();
            Label_pom_num = new System.Windows.Forms.Label();
            room_heightLabel = new System.Windows.Forms.Label();
            room_lenghtLabel = new System.Windows.Forms.Label();
            room_widthLabel = new System.Windows.Forms.Label();
            room_floor_numLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // housing_idLabel
            // 
            housing_idLabel.AutoSize = true;
            housing_idLabel.Location = new System.Drawing.Point(12, 22);
            housing_idLabel.Name = "housing_idLabel";
            housing_idLabel.Size = new System.Drawing.Size(46, 13);
            housing_idLabel.TabIndex = 21;
            housing_idLabel.Text = "Корпус:";
            // 
            // room_nameLabel
            // 
            room_nameLabel.AutoSize = true;
            room_nameLabel.Location = new System.Drawing.Point(12, 101);
            room_nameLabel.Name = "room_nameLabel";
            room_nameLabel.Size = new System.Drawing.Size(86, 13);
            room_nameLabel.TabIndex = 23;
            room_nameLabel.Text = "Наименование:";
            // 
            // Label_aud_num
            // 
            Label_aud_num.AutoSize = true;
            Label_aud_num.Location = new System.Drawing.Point(12, 49);
            Label_aud_num.Name = "Label_aud_num";
            Label_aud_num.Size = new System.Drawing.Size(73, 13);
            Label_aud_num.TabIndex = 25;
            Label_aud_num.Text = "№ аудитории";
            // 
            // Label_pom_num
            // 
            Label_pom_num.AutoSize = true;
            Label_pom_num.Location = new System.Drawing.Point(12, 75);
            Label_pom_num.Name = "Label_pom_num";
            Label_pom_num.Size = new System.Drawing.Size(83, 13);
            Label_pom_num.TabIndex = 27;
            Label_pom_num.Text = "№ помещения:";
            // 
            // room_heightLabel
            // 
            room_heightLabel.AutoSize = true;
            room_heightLabel.Location = new System.Drawing.Point(12, 227);
            room_heightLabel.Name = "room_heightLabel";
            room_heightLabel.Size = new System.Drawing.Size(110, 13);
            room_heightLabel.TabIndex = 29;
            room_heightLabel.Text = "Высота помещения:";
            // 
            // room_lenghtLabel
            // 
            room_lenghtLabel.AutoSize = true;
            room_lenghtLabel.Location = new System.Drawing.Point(12, 253);
            room_lenghtLabel.Name = "room_lenghtLabel";
            room_lenghtLabel.Size = new System.Drawing.Size(105, 13);
            room_lenghtLabel.TabIndex = 31;
            room_lenghtLabel.Text = "Длина помещения:";
            // 
            // room_widthLabel
            // 
            room_widthLabel.AutoSize = true;
            room_widthLabel.Location = new System.Drawing.Point(12, 279);
            room_widthLabel.Name = "room_widthLabel";
            room_widthLabel.Size = new System.Drawing.Size(111, 13);
            room_widthLabel.TabIndex = 33;
            room_widthLabel.Text = "Ширина помещения:";
            // 
            // room_floor_numLabel
            // 
            room_floor_numLabel.AutoSize = true;
            room_floor_numLabel.Location = new System.Drawing.Point(12, 387);
            room_floor_numLabel.Name = "room_floor_numLabel";
            room_floor_numLabel.Size = new System.Drawing.Size(98, 13);
            room_floor_numLabel.TabIndex = 35;
            room_floor_numLabel.Text = "Этаж помещения:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_houisng);
            this.panel1.Controls.Add(this.comboBox_secured);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_seats);
            this.panel1.Controls.Add(this.textBox_seats);
            this.panel1.Controls.Add(this.textBox_square);
            this.panel1.Controls.Add(this.label_square);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox_room_equipment);
            this.panel1.Controls.Add(this.comboBox_roomfloor);
            this.panel1.Controls.Add(housing_idLabel);
            this.panel1.Controls.Add(room_nameLabel);
            this.panel1.Controls.Add(this.room_nameTextBox);
            this.panel1.Controls.Add(Label_aud_num);
            this.panel1.Controls.Add(this.TextBox_aud_num);
            this.panel1.Controls.Add(Label_pom_num);
            this.panel1.Controls.Add(this.TextBox_pom_num);
            this.panel1.Controls.Add(room_heightLabel);
            this.panel1.Controls.Add(this.room_heightTextBox);
            this.panel1.Controls.Add(room_lenghtLabel);
            this.panel1.Controls.Add(this.room_lenghtTextBox);
            this.panel1.Controls.Add(room_widthLabel);
            this.panel1.Controls.Add(this.room_widthTextBox);
            this.panel1.Controls.Add(room_floor_numLabel);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 471);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_houisng
            // 
            this.comboBox_houisng.DataSource = this.housingBindingSource2;
            this.comboBox_houisng.DisplayMember = "Наименование";
            this.comboBox_houisng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_houisng.FormattingEnabled = true;
            this.comboBox_houisng.Location = new System.Drawing.Point(204, 19);
            this.comboBox_houisng.Name = "comboBox_houisng";
            this.comboBox_houisng.Size = new System.Drawing.Size(154, 21);
            this.comboBox_houisng.TabIndex = 55;
            this.comboBox_houisng.ValueMember = "Код";
            this.comboBox_houisng.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // housingBindingSource2
            // 
            this.housingBindingSource2.DataMember = "Housing";
            this.housingBindingSource2.DataSource = this.db_AISDataSet2;
            // 
            // db_AISDataSet2
            // 
            this.db_AISDataSet2.DataSetName = "Db_AISDataSet2";
            this.db_AISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_secured
            // 
            this.comboBox_secured.DataSource = this.unitsBindingSource;
            this.comboBox_secured.DisplayMember = "Сокращенное наименование";
            this.comboBox_secured.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_secured.FormattingEnabled = true;
            this.comboBox_secured.Location = new System.Drawing.Point(204, 357);
            this.comboBox_secured.Name = "comboBox_secured";
            this.comboBox_secured.Size = new System.Drawing.Size(154, 21);
            this.comboBox_secured.TabIndex = 45;
            this.comboBox_secured.ValueMember = "Код";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.db_AISDataSet1;
            // 
            // db_AISDataSet1
            // 
            this.db_AISDataSet1.DataSetName = "Db_AISDataSet1";
            this.db_AISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Закрепление:";
            // 
            // label_seats
            // 
            this.label_seats.AutoSize = true;
            this.label_seats.Location = new System.Drawing.Point(12, 331);
            this.label_seats.Name = "label_seats";
            this.label_seats.Size = new System.Drawing.Size(102, 13);
            this.label_seats.TabIndex = 43;
            this.label_seats.Text = "Мест для сидения:";
            // 
            // textBox_seats
            // 
            this.textBox_seats.Location = new System.Drawing.Point(204, 328);
            this.textBox_seats.Name = "textBox_seats";
            this.textBox_seats.Size = new System.Drawing.Size(154, 20);
            this.textBox_seats.TabIndex = 42;
            this.textBox_seats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_seats_KeyPress);
            // 
            // textBox_square
            // 
            this.textBox_square.Enabled = false;
            this.textBox_square.Location = new System.Drawing.Point(204, 302);
            this.textBox_square.Name = "textBox_square";
            this.textBox_square.Size = new System.Drawing.Size(154, 20);
            this.textBox_square.TabIndex = 50;
            this.textBox_square.TabStop = false;
            // 
            // label_square
            // 
            this.label_square.AutoSize = true;
            this.label_square.Location = new System.Drawing.Point(12, 305);
            this.label_square.Name = "label_square";
            this.label_square.Size = new System.Drawing.Size(119, 13);
            this.label_square.TabIndex = 40;
            this.label_square.Text = "Площадь помещения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Оборудование:";
            // 
            // richTextBox_room_equipment
            // 
            this.richTextBox_room_equipment.Location = new System.Drawing.Point(15, 148);
            this.richTextBox_room_equipment.Name = "richTextBox_room_equipment";
            this.richTextBox_room_equipment.Size = new System.Drawing.Size(343, 70);
            this.richTextBox_room_equipment.TabIndex = 29;
            this.richTextBox_room_equipment.Text = "";
            // 
            // comboBox_roomfloor
            // 
            this.comboBox_roomfloor.DisplayMember = "1";
            this.comboBox_roomfloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomfloor.FormattingEnabled = true;
            this.comboBox_roomfloor.Location = new System.Drawing.Point(204, 384);
            this.comboBox_roomfloor.Name = "comboBox_roomfloor";
            this.comboBox_roomfloor.Size = new System.Drawing.Size(154, 21);
            this.comboBox_roomfloor.TabIndex = 46;
            this.comboBox_roomfloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_roomfloor_KeyPress);
            // 
            // room_nameTextBox
            // 
            this.room_nameTextBox.Location = new System.Drawing.Point(204, 98);
            this.room_nameTextBox.Name = "room_nameTextBox";
            this.room_nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.room_nameTextBox.TabIndex = 28;
            this.room_nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_nameTextBox_KeyPress);
            // 
            // TextBox_aud_num
            // 
            this.TextBox_aud_num.Location = new System.Drawing.Point(204, 46);
            this.TextBox_aud_num.Name = "TextBox_aud_num";
            this.TextBox_aud_num.Size = new System.Drawing.Size(154, 20);
            this.TextBox_aud_num.TabIndex = 26;
            this.TextBox_aud_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_descriptionTextBox_KeyPress);
            // 
            // TextBox_pom_num
            // 
            this.TextBox_pom_num.Location = new System.Drawing.Point(204, 72);
            this.TextBox_pom_num.Name = "TextBox_pom_num";
            this.TextBox_pom_num.Size = new System.Drawing.Size(154, 20);
            this.TextBox_pom_num.TabIndex = 27;
            this.TextBox_pom_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_functionTextBox_KeyPress);
            // 
            // room_heightTextBox
            // 
            this.room_heightTextBox.Location = new System.Drawing.Point(204, 224);
            this.room_heightTextBox.Name = "room_heightTextBox";
            this.room_heightTextBox.Size = new System.Drawing.Size(154, 20);
            this.room_heightTextBox.TabIndex = 30;
            this.room_heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_heightTextBox_KeyPress);
            // 
            // room_lenghtTextBox
            // 
            this.room_lenghtTextBox.Location = new System.Drawing.Point(204, 250);
            this.room_lenghtTextBox.Name = "room_lenghtTextBox";
            this.room_lenghtTextBox.Size = new System.Drawing.Size(154, 20);
            this.room_lenghtTextBox.TabIndex = 32;
            this.room_lenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_lenghtTextBox_KeyPress);
            // 
            // room_widthTextBox
            // 
            this.room_widthTextBox.Location = new System.Drawing.Point(204, 276);
            this.room_widthTextBox.Name = "room_widthTextBox";
            this.room_widthTextBox.Size = new System.Drawing.Size(154, 20);
            this.room_widthTextBox.TabIndex = 34;
            this.room_widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_widthTextBox_KeyPress);
            this.room_widthTextBox.Leave += new System.EventHandler(this.room_widthTextBox_Leave);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(204, 437);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(154, 23);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 437);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(154, 23);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Ок";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // housingBindingSource
            // 
            this.housingBindingSource.DataMember = "Housing";
            this.housingBindingSource.DataSource = this.db_AISDataSet2;
            // 
            // housingTableAdapter
            // 
            this.housingTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // dbAISDataSet2BindingSource
            // 
            this.dbAISDataSet2BindingSource.DataSource = this.db_AISDataSet2;
            this.dbAISDataSet2BindingSource.Position = 0;
            // 
            // housingBindingSource1
            // 
            this.housingBindingSource1.DataMember = "Housing";
            this.housingBindingSource1.DataSource = this.dbAISDataSet2BindingSource;
            // 
            // unitsBindingSource1
            // 
            this.unitsBindingSource1.DataMember = "Units";
            this.unitsBindingSource1.DataSource = this.db_AISDataSet1;
            // 
            // Add_Form_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Form_Rooms";
            this.Text = "Добавить помещение";
            this.Load += new System.EventHandler(this.Add_Form_Rooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.TextBox room_nameTextBox;
        public System.Windows.Forms.TextBox TextBox_aud_num;
        public System.Windows.Forms.TextBox TextBox_pom_num;
        public System.Windows.Forms.TextBox room_heightTextBox;
        public System.Windows.Forms.TextBox room_lenghtTextBox;
        public System.Windows.Forms.TextBox room_widthTextBox;
        public System.Windows.Forms.ComboBox comboBox_roomfloor;
        private Db_AISDataSet2 db_AISDataSet2;
        private System.Windows.Forms.BindingSource housingBindingSource;
        private Db_AISDataSet2TableAdapters.HousingTableAdapter housingTableAdapter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox richTextBox_room_equipment;
        public System.Windows.Forms.TextBox textBox_square;
        private System.Windows.Forms.Label label_square;
        public System.Windows.Forms.ComboBox comboBox_secured;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_seats;
        public System.Windows.Forms.TextBox textBox_seats;
        private Db_AISDataSet1 db_AISDataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private Db_AISDataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        public System.Windows.Forms.ComboBox comboBox_houisng;
        private System.Windows.Forms.BindingSource housingBindingSource1;
        private System.Windows.Forms.BindingSource dbAISDataSet2BindingSource;
        private System.Windows.Forms.BindingSource unitsBindingSource1;
        private System.Windows.Forms.BindingSource housingBindingSource2;
    }
}