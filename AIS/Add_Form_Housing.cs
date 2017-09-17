using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AIS
{
    public partial class Add_Form_Housing : Form
    {
        db_control dbc;
        public int temp_id;
        public bool edit = false;
        public Add_Form_Housing()
        {
            InitializeComponent();
            dbc = new db_control(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Db_AIS.mdf;Integrated Security=True");
        }

        private void Add_btn_housing_Click(object sender, EventArgs e)
        {
            try
            {
                if (!edit)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Housing ([Номер корпуса],[Наименование],[Количество этажей]) VALUES(@housig_num,@name,@floor_count)", dbc.con);
                    cmd.Parameters.AddWithValue("@housig_num", textBox_corp_num.Text);
                    cmd.Parameters.AddWithValue("@name", nameTextBox1.Text);
                    cmd.Parameters.AddWithValue("@floor_count", floor_countTextBox.Text);
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
                        SqlCommand cmd = new SqlCommand("UPDATE Housing set [Номер корпуса] = @housig_num,"
                        + "[Наименование] = @name,[Количество этажей] = @floor_count WHERE [Код]=@id", dbc.con);
                        cmd.Parameters.AddWithValue("@id", temp_id);
                        cmd.Parameters.AddWithValue("@housig_num", textBox_corp_num.Text);
                        cmd.Parameters.AddWithValue("@name", nameTextBox1.Text);
                        cmd.Parameters.AddWithValue("@floor_count", floor_countTextBox.Text);
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

        private void Cancel_btn_housing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Form_Housing_Load(object sender, EventArgs e)
        {
            dbc.con.Open();
        }

        private void nameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
                e.Handled = true;
        }

        private void floor_countTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && l != '\b')
                e.Handled = true;
        }

        private void textBox_corp_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ' && l != '№')
                e.Handled = true;
        }

        private void nameTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
                e.Handled = true;
        }

        private void floor_countTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && l != '\b')
                e.Handled = true;
        }
    }
}
