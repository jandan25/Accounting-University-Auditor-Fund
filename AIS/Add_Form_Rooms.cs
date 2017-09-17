using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AIS
{
    public partial class Add_Form_Rooms : Form
    {
        db_control dbc;
        public int temp_id;
        public bool edit = false;
        public SqlDataAdapter adap;
        public DataSet ds;
        public Add_Form_Rooms()
        {
            InitializeComponent();
            dbc = new db_control(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Db_AIS.mdf;Integrated Security=True");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!edit)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Rooms ([Код корпуса],[Корпус],[№ аудитории],[№ помещения],[Наименование],[Оборудование],[Высота помещения],[Длина помещения],[Ширина помещения],[Площадь помещения],[Мест для сидения],[Закрепление],[Код закрепления],[Этаж помещения])" +
                        "VALUES (@housing_id,@housing,@room_aud_num,@room_pom_num,@room_name,@room_equipment,@room_height,@room_lenght,@room_width,@room_square,@room_seats,@room_secured,@room_id_secured,@room_floor_num)", dbc.con);
                    cmd.Parameters.AddWithValue("@housing_id", comboBox_houisng.SelectedValue);
                    cmd.Parameters.AddWithValue("@housing", comboBox_houisng.Text);
                    cmd.Parameters.AddWithValue("@room_name", room_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@room_aud_num", TextBox_aud_num.Text);
                    cmd.Parameters.AddWithValue("@room_pom_num", TextBox_pom_num.Text);
                    cmd.Parameters.AddWithValue("@room_equipment", richTextBox_room_equipment.Text);
                    cmd.Parameters.AddWithValue("@room_height", Convert.ToDouble(room_heightTextBox.Text));
                    cmd.Parameters.AddWithValue("@room_lenght", Convert.ToDouble(room_lenghtTextBox.Text));
                    cmd.Parameters.AddWithValue("@room_width", Convert.ToDouble(room_widthTextBox.Text));
                    cmd.Parameters.AddWithValue("@room_square", Convert.ToDouble(textBox_square.Text));
                    cmd.Parameters.AddWithValue("@room_seats", Convert.ToDouble(textBox_seats.Text));
                    cmd.Parameters.AddWithValue("@room_secured", comboBox_secured.Text);
                    cmd.Parameters.AddWithValue("@room_id_secured", comboBox_secured.SelectedValue);
                    cmd.Parameters.AddWithValue("@room_floor_num", Convert.ToInt32(comboBox_roomfloor.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация добавлена", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Rooms SET [Код корпуса] = @housing_id,[Корпус] = @housing,[№ аудитории] = @room_aud_num,[№ помещения] = @room_pom_num, [Наименование] = @room_name," +
                            "[Оборудование] = @room_equipment,[Высота помещения] = @room_height,[Длина помещения] = @room_lenght,[Ширина помещения] = @room_width,[Площадь помещения] = @room_square," +
                            "[Мест для сидения] = @room_seats,[Закрепление] = @room_secured,[Код закрепления] = @room_id_secured, [Этаж помещения] = @room_floor_num WHERE[Код] = @id", dbc.con);
                        cmd.Parameters.AddWithValue("@id", temp_id);
                        cmd.Parameters.AddWithValue("@housing_id", comboBox_houisng.SelectedValue);
                        cmd.Parameters.AddWithValue("@housing", comboBox_houisng.Text);
                        cmd.Parameters.AddWithValue("@room_name", room_nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@room_aud_num", TextBox_aud_num.Text);
                        cmd.Parameters.AddWithValue("@room_pom_num", TextBox_pom_num.Text);
                        cmd.Parameters.AddWithValue("@room_equipment", richTextBox_room_equipment.Text);
                        cmd.Parameters.AddWithValue("@room_height", Convert.ToDouble(room_heightTextBox.Text));
                        cmd.Parameters.AddWithValue("@room_lenght", Convert.ToDouble(room_lenghtTextBox.Text));
                        cmd.Parameters.AddWithValue("@room_width", Convert.ToDouble(room_widthTextBox.Text));
                        cmd.Parameters.AddWithValue("@room_square", Convert.ToDouble(textBox_square.Text));
                        cmd.Parameters.AddWithValue("@room_seats", Convert.ToDouble(textBox_seats.Text));
                        cmd.Parameters.AddWithValue("@room_secured", comboBox_secured.Text);
                        cmd.Parameters.AddWithValue("@room_id_secured", comboBox_secured.SelectedValue);
                        cmd.Parameters.AddWithValue("@room_floor_num", Convert.ToInt32(comboBox_roomfloor.Text));
                        cmd.ExecuteNonQuery();
                        edit = false;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void housing_idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b' && l != '.' && l != ' ')
                e.Handled = true;
        }

        private void room_nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
                e.Handled = true;
        }

        private void room_descriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (l < 'А' || l > 'я') 
                && l != '\b' && l != '.' && l != ' ' && l != '№' && l!='-' && l != '/')
                e.Handled = true;
        }

        private void room_functionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
                e.Handled = true;
        }

        private void room_heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b' && l != ',' && l != ' ')
                e.Handled = true;
        }

        private void room_lenghtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b' && l != ',' && l != ' ')
                e.Handled = true;
        }

        private void room_widthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b' && l != ',' && l != ' ')
                e.Handled = true;
        }

        private void comboBox_roomfloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Add_Form_Rooms_Load(object sender, EventArgs e)
        {
            dbc.con.Open();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_AISDataSet1.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.db_AISDataSet1.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_AISDataSet2.Housing". При необходимости она может быть перемещена или удалена.
            this.housingTableAdapter.Fill(this.db_AISDataSet2.Housing);
            comboBox_roomfloor.Items.Clear();
            adap = new SqlDataAdapter("SELECT [Количество этажей] FROM Housing WHERE [Код] = " + comboBox_houisng.SelectedValue, dbc.con);
            ds = new DataSet();
            adap.Fill(ds, "Housing");
            int count = (int)ds.Tables[0].Rows[0].ItemArray[0];
            for (int i = 1; i <= count; i++)
                comboBox_roomfloor.Items.Add(i);
            comboBox_roomfloor.SelectedIndex = 0;
        }
        private void room_widthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox_square.Text = (Convert.ToSingle(room_widthTextBox.Text) * Convert.ToSingle(room_lenghtTextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Не введено значение длины и/или ширины помещения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_roomfloor.Items.Clear();
                adap = new SqlDataAdapter("SELECT [Количество этажей] FROM Housing WHERE [Код] =" + comboBox_houisng.SelectedValue, dbc.con);
                ds = new DataSet();
                adap.Fill(ds, "Housing");
                int count = (int)ds.Tables[0].Rows[0].ItemArray[0];
                for (int i = 1; i <= count; i++)
                    comboBox_roomfloor.Items.Add(i);
                comboBox_roomfloor.SelectedIndex = 0;
            }
            catch
            { }
        }

        private void textBox_seats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b')
                e.Handled = true;
        }
    }
}
