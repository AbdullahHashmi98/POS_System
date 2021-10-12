using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace POS_System
{
    class Database
    {
        public SQLiteConnection connection;
        DataTable dt = new DataTable();
        public Database()
        {
            try
            {
                connection = new SQLiteConnection("Data Source=POS_System.db;Version=3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Item_List()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Item_setup", connection);
                connection.Open();
                SQLiteDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public DataTable Sales()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Total_sell_item", connection);
                connection.Open();
                SQLiteDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public void Add_New_Item(string ItemName,double Price)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("insert into Item_setup ([Item_name],[Sell_price]) values ('" + ItemName + "', '" + Price + "') ",connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();

                MessageBox.Show("Item is added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Item is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update_Exits_Item(int id, string ItemName, double Price)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("update Item_setup set Item_name = '"+ ItemName +"', Sell_price = '"+Price+"' where Item_setup_id = '"+id+"'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Item is updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Item is not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Search_by_ItemName(string Itemname)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Total_sell_item where Item_Name = '"+ Itemname +"'", connection);
                connection.Open();
                SQLiteDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public DataTable Search_by_Date(string date)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Total_sell_item where Date = '" + date + "'", connection);
                connection.Open();
                SQLiteDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public bool Check_Item_Exits(string ItemName, double Price)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Item_setup where Item_name = @Itemname and Sell_price = @price", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Itemname", ItemName);
                cmd.Parameters.AddWithValue("@price", Price);
                SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if(reader.HasRows)
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
            return false;
        }

        public void Confirm_Bill(string itemname, double price, int qty, string date)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("insert into Total_sell_item ([Item_Name],[Price],[Qty],[Date]) values ('" + itemname + "', '" + price + "', '" + qty + "', '" + date + "') ", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Bill is not confirmed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
