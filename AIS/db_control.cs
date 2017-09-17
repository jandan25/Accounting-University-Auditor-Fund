using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AIS
{
    class db_control
    {
        public db_control(string path_to_bd)
        {
            con = new SqlConnection(path_to_bd);
        }
        public SqlConnection con;
        public Add_row_form examp1;
        public Add_Form_Housing examp2;
        public Add_Form_Rooms examp3;
        public DataSet ds;
        public SqlDataAdapter adap;
        public void AddWindowUnits()
        {
            examp1 = new Add_row_form();
            examp1.Show();
        }
        public void AddWindowHousing()
        {
            examp2 = new Add_Form_Housing();
            examp2.Show();
        }
        public void AddWindowRooms()
        {
            examp3 = new Add_Form_Rooms();
            examp3.Show();
        }

        public void FillDB(string t_n, DataGridView dgv)
        {
            string table_name = t_n;
            DataGridView datagridview = dgv;
            datagridview.DataSource = null;
            adap = new SqlDataAdapter("SELECT * FROM " + table_name + " WHERE [Код] > 1", con);
            ds = new DataSet();
            adap.Fill(ds, table_name);        
            datagridview.DataSource = ds.Tables[0];
        }
        public void DeleteCurrentRowDB(string t_n, DataGridView dgv, int id_del, bool more)
        {
            if (more)
            {
                DialogResult result;
                result = MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string table_name = t_n;
                    DataGridView datagridview = dgv;
                    int id = id_del;
                    try
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM " + table_name + " WHERE [Код] = " + id, con);
                        command.ExecuteNonQuery();

                        FillDB(table_name, datagridview);
                    }
                    catch
                    {
                        result = MessageBox.Show("У записи имеются связанные записи хотите удалить их?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            SqlCommand command = new SqlCommand("DELETE FROM Rooms WHERE [Код корпуса] = " + id, con);
                            command.ExecuteNonQuery();
                            command = new SqlCommand("DELETE FROM Housing WHERE [Код] = " + id, con);
                            command.ExecuteNonQuery();
                            DeleteCurrentRowDB(table_name, datagridview, id_del,false);
                        }
                    }
                }
            }
            else
            {
                string table_name = t_n;
                DataGridView datagridview = dgv;
                int id = id_del;
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM " + table_name + " WHERE [Код] = " + id, con);
                    command.ExecuteNonQuery();
                    FillDB(table_name, datagridview);
                }
                catch
                {
                    DialogResult result;
                    result = MessageBox.Show("У записи имеются связанные записи хотите удалить их?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM Rooms WHERE [Код корпуса] = " + id, con);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("DELETE FROM Housing WHERE [Код] = " + id, con);
                        command.ExecuteNonQuery();
                        DeleteCurrentRowDB(table_name, datagridview, id_del,false);
                    }
                }
            }
        }
        public void UpdateTable(string t_n, DataGridView dgv,bool more)
        {
            try
            {
                string table_name = t_n;
                DataGridView datagridview = dgv;
                adap = new SqlDataAdapter("SELECT * FROM " + table_name, con);
                ds = new DataSet();
                adap.Fill(ds, table_name);
                adap.Update(ds, table_name);
                FillDB(table_name, datagridview);
                if (more)
                    MessageBox.Show("Информация обновлена", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataSet SelectEditRow(string t_n, int id)
        {
            string table_name = t_n;
            int id_row = id;
            adap = new SqlDataAdapter("SELECT * FROM " + table_name + " WHERE [Код] = " + id_row, con);
            ds = new DataSet();
            adap.Fill(ds, table_name);
            return ds;
        }

        public string Select_room_and_housing(int id)
        {
            int count_courpuses = 0;
            string g = "";
            adap = new SqlDataAdapter("SELECT * FROM Units where [Корпус] = " + id, con);
            ds = new DataSet();
            adap.Fill(ds, "Housing");
            count_courpuses = ds.Tables[0].Rows.Count;
            if (count_courpuses >= 1)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                    g = Select_rooms(id, false);
                g += '\n' + "Количество корпусов = " + count_courpuses;
            }
            else
                g = "Количество корпусов = 0";
            return g;
        }
        public string Select_rooms(int id, bool more)
        {
            string g = "";
            try
            {
                double S = 0, V = 0;
                if (more)
                    adap = new SqlDataAdapter("SELECT [Длина помещения],[Ширина помещения],[Высота помещения],[Этаж помещения],[Оборудование] FROM Rooms where [Код] = " + id, con);
                else
                    adap = new SqlDataAdapter("SELECT [Длина помещения],[Ширина помещения],[Высота помещения],[Этаж помещения] FROM Rooms where [Код корпуса] = " + id, con);
                ds = new DataSet();
                adap.Fill(ds, "Housing");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    S += Convert.ToDouble(row.ItemArray[0]) * Convert.ToDouble(row.ItemArray[1]);
                    V += Convert.ToDouble(row.ItemArray[0]) * Convert.ToDouble(row.ItemArray[0]) * Convert.ToDouble(row.ItemArray[2]);
                }
                g = "Площадь занимаемая комнатами = " + S + " кв.м" +
                    '\n' + "Объем занимаемый комнатами = " + V + " кв.м" + '\n' + '\n';
                if (ds.Tables[0].Rows[0].ItemArray[4].ToString().Length > 0)
                    g += "Оборудование в аудитории:" + '\n' + ds.Tables[0].Rows[0].ItemArray[4] + '\n' + '\n';
                    else
                    g += "Оборудование в аудитории:" + '\n' + "Отсутствует" + '\n' + '\n';
                g += "Этаж помещения = " + ds.Tables[0].Rows[0].ItemArray[3];
                return g;
            }
            catch
            {
                return g ="";
            }
        }
        public string Select_housing(int id)
        {
            string g = "";
            try
            {
                int count_facul = 0, count_pom = 0;
                string name_facul = "";
                adap = new SqlDataAdapter("SELECT [Сокращенное наименование] FROM Units where [Код корпуса] = " + id, con);
                ds = new DataSet();
                adap.Fill(ds, "Units");        
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    count_facul++;
                    name_facul +=row.ItemArray[0].ToString() + '\n';
                }
                adap = new SqlDataAdapter("SELECT [Закрепление] FROM Rooms where [Код корпуса] = " + id, con);
                ds = new DataSet();
                adap.Fill(ds, "Rooms");
                foreach (DataRow row in ds.Tables[0].Rows)
                    count_pom++;
                if (count_facul == 0)
                    g += "Входящие факультеты: Отсутствуют";
                else
                    g += "Входящие факультеты: " + '\n' + name_facul + '\n' +
                    "Количество факультетов: " + count_facul + '\n' +
                    "Колчество помещений: " + count_pom;
                return g;
            }
            catch
            {
                return g = "Нет подчиненных подразделений!";
            }
        }
        public string Select_units(string str)
        {
            string g = "";
            try
            {
                int count_pom = 0;
                float s_pom = 0;
                adap = new SqlDataAdapter("select [Площадь помещения] FROM Rooms WHERE [Закрепление] = N'" + str+"'", con);
                ds = new DataSet();
                adap.Fill(ds, "Rooms");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    count_pom++;
                    s_pom += Convert.ToSingle(row.ItemArray[0]);
                }
                if (count_pom == 0)
                    g += "Занимаемая площадь: Отсутствуют";
                else
                    g += "Занимаемая площадь: " + s_pom +" кв.м" +'\n' +
                    "Количество помещений: " + count_pom;
                return g;
            }
            catch
            {
                return g = "Нет входящих помещений!";
            }
        }
    }  
}
