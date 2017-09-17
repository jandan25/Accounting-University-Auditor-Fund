using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AIS
{
    public partial class Add_row_form : Form
    {
        db_control dbc;
        public int temp_id;
        public bool edit = false;
        public Add_row_form()
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Units ([Сокращенное наименование]"+
                        ",[Полное наименование],[Ответственное лицо],[Код корпуса],[Корпус],[Зависимость]) VALUES (@name,@full_name,@resp_person,@corpuse_id,@corpuse,@dependence)", dbc.con);
                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@full_name", full_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@resp_person",resp_personTextBox.Text);
                    cmd.Parameters.AddWithValue("@corpuse_id", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@corpuse", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@dependence", comboBox_dependence.Text);
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
                        SqlCommand cmd = new SqlCommand("UPDATE Units set [Сокращенное наименование] = @name,"
                        + "[Полное наименование] = @full_name,[Ответственное лицо] = @resp_person,[Код корпуса] = @corpuse_id, [Корпус] = @corpuse, [Зависимость] = @dependence WHERE [Код]=@id", dbc.con);
                        cmd.Parameters.AddWithValue("@id", temp_id);
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@full_name", full_nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@resp_person", resp_personTextBox.Text);
                        cmd.Parameters.AddWithValue("@corpuse_id", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@corpuse", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@dependence", comboBox_dependence.Text);
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

        private void Add_row_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_AISDataSet2.Housing". При необходимости она может быть перемещена или удалена.
            this.housingTableAdapter.Fill(this.db_AISDataSet2.Housing);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_AISDataSet1.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.db_AISDataSet1.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_AISDataSet1.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.db_AISDataSet1.Units);
            dbc.con.Open();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
                e.Handled = true;
        }

        private void full_nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
                e.Handled = true;
        }

        private void resp_personTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l!=' ')
                e.Handled = true;
        }
    }
}
