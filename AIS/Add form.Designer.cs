namespace AIS
{
    partial class Add_row_form
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
            System.Windows.Forms.Label dependenceLabel;
            System.Windows.Forms.Label resp_personLabel;
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label nameLabel;
            this.resp_personTextBox = new System.Windows.Forms.TextBox();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.housingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbAISDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_AISDataSet2 = new AIS.Db_AISDataSet2();
            this.comboBox_dependence = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_AISDataSet1 = new AIS.Db_AISDataSet1();
            this.unitsTableAdapter = new AIS.Db_AISDataSet1TableAdapters.UnitsTableAdapter();
            this.dbAISDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housingTableAdapter = new AIS.Db_AISDataSet2TableAdapters.HousingTableAdapter();
            dependenceLabel = new System.Windows.Forms.Label();
            resp_personLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dependenceLabel
            // 
            dependenceLabel.AutoSize = true;
            dependenceLabel.Location = new System.Drawing.Point(12, 127);
            dependenceLabel.Name = "dependenceLabel";
            dependenceLabel.Size = new System.Drawing.Size(78, 13);
            dependenceLabel.TabIndex = 49;
            dependenceLabel.Text = "Зависимость:";
            // 
            // resp_personLabel
            // 
            resp_personLabel.AutoSize = true;
            resp_personLabel.Location = new System.Drawing.Point(12, 74);
            resp_personLabel.Name = "resp_personLabel";
            resp_personLabel.Size = new System.Drawing.Size(114, 13);
            resp_personLabel.TabIndex = 47;
            resp_personLabel.Text = "Ответственное лицо:";
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(12, 48);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(125, 13);
            full_nameLabel.TabIndex = 45;
            full_nameLabel.Text = "Полное наименование:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(157, 13);
            nameLabel.TabIndex = 43;
            nameLabel.Text = "Сокращенное наименование:";
            // 
            // resp_personTextBox
            // 
            this.resp_personTextBox.Location = new System.Drawing.Point(204, 71);
            this.resp_personTextBox.Name = "resp_personTextBox";
            this.resp_personTextBox.Size = new System.Drawing.Size(154, 20);
            this.resp_personTextBox.TabIndex = 48;
            this.resp_personTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resp_personTextBox_KeyPress);
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.Location = new System.Drawing.Point(204, 45);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.full_nameTextBox.TabIndex = 46;
            this.full_nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.full_nameTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 44;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 168);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(154, 23);
            this.add_btn.TabIndex = 51;
            this.add_btn.Text = "Ок";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(204, 168);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(154, 23);
            this.cancel_btn.TabIndex = 52;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox_dependence);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(full_nameLabel);
            this.panel1.Controls.Add(this.full_nameTextBox);
            this.panel1.Controls.Add(resp_personLabel);
            this.panel1.Controls.Add(this.resp_personTextBox);
            this.panel1.Controls.Add(dependenceLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 205);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Корпус";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.housingBindingSource;
            this.comboBox1.DisplayMember = "Наименование";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.ValueMember = "Код";
            // 
            // housingBindingSource
            // 
            this.housingBindingSource.DataMember = "Housing";
            this.housingBindingSource.DataSource = this.dbAISDataSet2BindingSource1;
            // 
            // dbAISDataSet2BindingSource1
            // 
            this.dbAISDataSet2BindingSource1.DataSource = this.db_AISDataSet2;
            this.dbAISDataSet2BindingSource1.Position = 0;
            // 
            // db_AISDataSet2
            // 
            this.db_AISDataSet2.DataSetName = "Db_AISDataSet2";
            this.db_AISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_dependence
            // 
            this.comboBox_dependence.DataSource = this.unitsBindingSource;
            this.comboBox_dependence.DisplayMember = "Сокращенное наименование";
            this.comboBox_dependence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dependence.FormattingEnabled = true;
            this.comboBox_dependence.Location = new System.Drawing.Point(204, 124);
            this.comboBox_dependence.Name = "comboBox_dependence";
            this.comboBox_dependence.Size = new System.Drawing.Size(154, 21);
            this.comboBox_dependence.TabIndex = 53;
            this.comboBox_dependence.ValueMember = "Код";
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
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // dbAISDataSet2BindingSource
            // 
            this.dbAISDataSet2BindingSource.DataSource = this.db_AISDataSet2;
            this.dbAISDataSet2BindingSource.Position = 0;
            // 
            // housingTableAdapter
            // 
            this.housingTableAdapter.ClearBeforeFill = true;
            // 
            // Add_row_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 205);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_row_form";
            this.Text = "Добавить подразделение";
            this.Load += new System.EventHandler(this.Add_row_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAISDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox resp_personTextBox;
        public System.Windows.Forms.TextBox full_nameTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox_dependence;
        private Db_AISDataSet1 db_AISDataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private Db_AISDataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dbAISDataSet2BindingSource1;
        private Db_AISDataSet2 db_AISDataSet2;
        private System.Windows.Forms.BindingSource dbAISDataSet2BindingSource;
        private System.Windows.Forms.BindingSource housingBindingSource;
        private Db_AISDataSet2TableAdapters.HousingTableAdapter housingTableAdapter;
    }
}