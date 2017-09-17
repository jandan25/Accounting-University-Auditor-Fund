namespace AIS
{
    partial class Add_Form_Housing
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
            System.Windows.Forms.Label units_idLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label floor_countLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_corp_num = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.floor_countTextBox = new System.Windows.Forms.TextBox();
            this.Cancel_btn_housing = new System.Windows.Forms.Button();
            this.Add_btn_housing = new System.Windows.Forms.Button();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_AISDataSet1 = new AIS.Db_AISDataSet1();
            this.unitsTableAdapter = new AIS.Db_AISDataSet1TableAdapters.UnitsTableAdapter();
            units_idLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            floor_countLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // units_idLabel
            // 
            units_idLabel.AutoSize = true;
            units_idLabel.Location = new System.Drawing.Point(12, 22);
            units_idLabel.Name = "units_idLabel";
            units_idLabel.Size = new System.Drawing.Size(88, 13);
            units_idLabel.TabIndex = 11;
            units_idLabel.Text = "Номер корпуса:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(12, 48);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(86, 13);
            nameLabel1.TabIndex = 13;
            nameLabel1.Text = "Наименование:";
            // 
            // floor_countLabel
            // 
            floor_countLabel.AutoSize = true;
            floor_countLabel.Location = new System.Drawing.Point(12, 74);
            floor_countLabel.Name = "floor_countLabel";
            floor_countLabel.Size = new System.Drawing.Size(109, 13);
            floor_countLabel.TabIndex = 15;
            floor_countLabel.Text = "Количество этажей:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_corp_num);
            this.panel1.Controls.Add(this.nameTextBox1);
            this.panel1.Controls.Add(this.floor_countTextBox);
            this.panel1.Controls.Add(this.Cancel_btn_housing);
            this.panel1.Controls.Add(this.Add_btn_housing);
            this.panel1.Controls.Add(units_idLabel);
            this.panel1.Controls.Add(nameLabel1);
            this.panel1.Controls.Add(floor_countLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 205);
            this.panel1.TabIndex = 0;
            // 
            // textBox_corp_num
            // 
            this.textBox_corp_num.Location = new System.Drawing.Point(204, 19);
            this.textBox_corp_num.Name = "textBox_corp_num";
            this.textBox_corp_num.Size = new System.Drawing.Size(154, 20);
            this.textBox_corp_num.TabIndex = 21;
            this.textBox_corp_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_corp_num_KeyPress);
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(204, 45);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox1.TabIndex = 23;
            this.nameTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox1_KeyPress_1);
            // 
            // floor_countTextBox
            // 
            this.floor_countTextBox.Location = new System.Drawing.Point(204, 71);
            this.floor_countTextBox.Name = "floor_countTextBox";
            this.floor_countTextBox.Size = new System.Drawing.Size(154, 20);
            this.floor_countTextBox.TabIndex = 25;
            this.floor_countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floor_countTextBox_KeyPress_1);
            // 
            // Cancel_btn_housing
            // 
            this.Cancel_btn_housing.Location = new System.Drawing.Point(204, 168);
            this.Cancel_btn_housing.Name = "Cancel_btn_housing";
            this.Cancel_btn_housing.Size = new System.Drawing.Size(154, 23);
            this.Cancel_btn_housing.TabIndex = 18;
            this.Cancel_btn_housing.Text = "Отмена";
            this.Cancel_btn_housing.UseVisualStyleBackColor = true;
            this.Cancel_btn_housing.Click += new System.EventHandler(this.Cancel_btn_housing_Click);
            // 
            // Add_btn_housing
            // 
            this.Add_btn_housing.Location = new System.Drawing.Point(15, 168);
            this.Add_btn_housing.Name = "Add_btn_housing";
            this.Add_btn_housing.Size = new System.Drawing.Size(154, 23);
            this.Add_btn_housing.TabIndex = 17;
            this.Add_btn_housing.Text = "Ок";
            this.Add_btn_housing.UseVisualStyleBackColor = true;
            this.Add_btn_housing.Click += new System.EventHandler(this.Add_btn_housing_Click);
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
            // Add_Form_Housing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 205);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Form_Housing";
            this.Text = "Добавить корпус";
            this.Load += new System.EventHandler(this.Add_Form_Housing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_AISDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel_btn_housing;
        private System.Windows.Forms.Button Add_btn_housing;
        private Db_AISDataSet1 db_AISDataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private Db_AISDataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        public System.Windows.Forms.TextBox textBox_corp_num;
        public System.Windows.Forms.TextBox nameTextBox1;
        public System.Windows.Forms.TextBox floor_countTextBox;
    }
}