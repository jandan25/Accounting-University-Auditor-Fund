using System;
using System.Windows.Forms;



namespace AIS
{
    public partial class Main_form : Form
    {
        db_control dbc;

        public Main_form()
        {
            InitializeComponent();
            dbc = new db_control(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Db_AIS.mdf;Integrated Security=True");
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            dbc.con.Open();
            dbc.FillDB("Units", unitsDataGridView);
            unitsDataGridView.Columns[0].Visible = false; //++++++++++++++++++++++++++++++++++
            unitsDataGridView.Columns[4].Visible = false; //++++++++++++++++++++++++++++++++++
            dbc.FillDB("Housing", housingDataGridView1);
            housingDataGridView1.Columns[0].Visible = false; //----------------------------------
            dbc.FillDB("Rooms", roomsDataGridView);
            roomsDataGridView.Columns[1].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[0].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[6].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[7].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[8].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[9].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[13].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[14].Visible = false; /////////////////////////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbc.AddWindowUnits();
            dbc.examp1.Text = "Добавление подразделения";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DeleteCurrentRowDB("Units", unitsDataGridView, Convert.ToInt32(unitsDataGridView.CurrentRow.Cells[0].Value), true);
                unitsDataGridView.Columns[0].Visible = false; //++++++++++++++++++++++++++++++++++
                unitsDataGridView.Columns[4].Visible = false; //++++++++++++++++++++++++++++++++++
                richTextBox_units.Text = "";
            }
            catch
            {
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_click(object sender, EventArgs e)
        {
            dbc.UpdateTable("Units", unitsDataGridView,true);
        }

        private void Main_form_Activated(object sender, EventArgs e)
        {
            dbc.FillDB("Units", unitsDataGridView);
            unitsDataGridView.Columns[0].Visible = false; //++++++++++++++++++++++++++++++++++
            unitsDataGridView.Columns[4].Visible = false; //++++++++++++++++++++++++++++++++++
            dbc.FillDB("Housing", housingDataGridView1);
            housingDataGridView1.Columns[0].Visible = false; //--------------------------------
            dbc.FillDB("Rooms", roomsDataGridView);
            roomsDataGridView.Columns[1].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[0].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[6].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[7].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[8].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[9].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[13].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[14].Visible = false; /////////////////////////////////////////
        }

        private void Add_btn_housing_Click(object sender, EventArgs e)
        {
            dbc.AddWindowHousing();
            dbc.examp2.Text = "Добавление корпуса";
        }

        private void Delete_btn_housing_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DeleteCurrentRowDB("Housing", housingDataGridView1, Convert.ToInt32(housingDataGridView1.CurrentRow.Cells[0].Value), true);
                housingDataGridView1.Columns[0].Visible = false;//--------------------------------------
                richTextBox_housing.Text = "";
            }
            catch
            {
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update_btn_housing_Click(object sender, EventArgs e)
        {
            dbc.UpdateTable("Housing", housingDataGridView1,true);
        }

        private void Add_btn_rooms_Click(object sender, EventArgs e)
        {
            dbc.AddWindowRooms();
            dbc.examp3.Text = "Добавление помещения";
            dbc.FillDB("Rooms", roomsDataGridView);
            roomsDataGridView.Columns[0].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[1].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[6].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[7].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[8].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[9].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[13].Visible = false; /////////////////////////////////////////
            roomsDataGridView.Columns[14].Visible = false; /////////////////////////////////////////

        }

        private void Delete_btn_rooms_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DeleteCurrentRowDB("Rooms", roomsDataGridView, Convert.ToInt32(roomsDataGridView.CurrentRow.Cells[0].Value), true);
                roomsDataGridView.Columns[0].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[1].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[6].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[7].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[8].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[9].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[13].Visible = false; /////////////////////////////////////////
                roomsDataGridView.Columns[14].Visible = false; ////////////////////////////////////////
                richTextBox_rooms.Text = "";
            }
            catch
            {
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update_btn_rooms_Click(object sender, EventArgs e)
        {
            dbc.UpdateTable("Rooms", roomsDataGridView,true);
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.AddWindowUnits();
                dbc.examp1.Text = "Редактирование подразделения";
                dbc.SelectEditRow("Units", (int)unitsDataGridView.CurrentRow.Cells[0].Value);
                dbc.examp1.edit = true;
                dbc.examp1.temp_id = Convert.ToInt32(dbc.ds.Tables[0].Rows[0].ItemArray[0]);
                dbc.examp1.nameTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[1].ToString();
                dbc.examp1.full_nameTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[2].ToString();
                dbc.examp1.resp_personTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[3].ToString();
                dbc.examp1.comboBox1.Text = dbc.ds.Tables[0].Rows[0].ItemArray[5].ToString();
                dbc.examp1.comboBox_dependence.Text = dbc.ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            catch
            {
                dbc.examp1.Close();
                MessageBox.Show("Не выбрана запись для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unitsDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_units.Text = dbc.Select_units(unitsDataGridView.CurrentRow.Cells[1].Value.ToString());
            }
            catch { }
        }

        private void housingDataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_housing.Text = dbc.Select_housing(Convert.ToInt32(housingDataGridView1.CurrentRow.Cells[0].Value));
            }
            catch { }

        }

        private void roomsDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_rooms.Text = dbc.Select_rooms(Convert.ToInt32(roomsDataGridView.CurrentRow.Cells[0].Value),true);
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.AddWindowHousing();
                dbc.examp2.Text = "Редактирование корпуса";
                dbc.SelectEditRow("Housing", (int)housingDataGridView1.CurrentRow.Cells[0].Value);
                dbc.examp2.edit = true;
                dbc.examp2.temp_id = Convert.ToInt32(dbc.ds.Tables[0].Rows[0].ItemArray[0]);
                dbc.examp2.textBox_corp_num.Text = dbc.ds.Tables[0].Rows[0].ItemArray[1].ToString();
                dbc.examp2.nameTextBox1.Text = dbc.ds.Tables[0].Rows[0].ItemArray[2].ToString();
                dbc.examp2.floor_countTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            catch
            {
                dbc.examp2.Close();
                MessageBox.Show("Не выбрана запись для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.AddWindowRooms();
                dbc.examp3.Text = "Редактирование помещения";
                dbc.SelectEditRow("Rooms", (int)roomsDataGridView.CurrentRow.Cells[0].Value);
                dbc.examp3.edit = true;
                dbc.examp3.temp_id = Convert.ToInt32(dbc.ds.Tables[0].Rows[0].ItemArray[0]);
                dbc.examp3.comboBox_houisng.Text = dbc.ds.Tables[0].Rows[0].ItemArray[2].ToString();
                dbc.examp3.TextBox_aud_num.Text = dbc.ds.Tables[0].Rows[0].ItemArray[3].ToString();
                dbc.examp3.TextBox_pom_num.Text = dbc.ds.Tables[0].Rows[0].ItemArray[4].ToString();
                dbc.examp3.room_nameTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[5].ToString();
                dbc.examp3.richTextBox_room_equipment.Text = dbc.ds.Tables[0].Rows[0].ItemArray[6].ToString();
                dbc.examp3.room_heightTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[7].ToString();
                dbc.examp3.room_lenghtTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[8].ToString();
                dbc.examp3.room_widthTextBox.Text = dbc.ds.Tables[0].Rows[0].ItemArray[9].ToString();
                dbc.examp3.textBox_square.Text = dbc.ds.Tables[0].Rows[0].ItemArray[10].ToString();
                dbc.examp3.textBox_seats.Text = dbc.ds.Tables[0].Rows[0].ItemArray[11].ToString();
                dbc.examp3.comboBox_secured.Text = dbc.ds.Tables[0].Rows[0].ItemArray[12].ToString();
                dbc.examp3.comboBox_roomfloor.Text = Convert.ToInt32(dbc.ds.Tables[0].Rows[0].ItemArray[14]).ToString();
            }
            catch
            {
                dbc.examp3.Close();
                MessageBox.Show("Не выбрана запись для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
    }
}
