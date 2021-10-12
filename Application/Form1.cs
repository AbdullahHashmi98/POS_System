using System;
using System.Data;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Item_Setup_Page : Form
    {

        Database db = new Database();
        int rowindex;
        int id;
        public Item_Setup_Page()
        {
            InitializeComponent();
        }

        private void Item_Setup_Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.Item_List();
                Item_List_View.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Sell_Page Sell = new Sell_Page();
                Sell.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Sell_Item_Page Sales = new Sell_Item_Page();
                Sales.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Text_Input_Check()
        {
            try
            {
                if (String.IsNullOrEmpty(Item_Name.Text) || String.IsNullOrEmpty(Item_Price.Text))
                {
                    DialogResult result = MessageBox.Show("Fill the boxes with correct information.", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if(result == DialogResult.OK)
                    {
                        Item_Name.Focus();

                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Text_Input_Check();

                if (result == true)
                {
                    bool ItemExist = db.Check_Item_Exits(Item_Name.Text, Convert.ToDouble(Item_Price.Text));
                    if (ItemExist == false)
                    {
                        db.Add_New_Item(Item_Name.Text, Convert.ToDouble(Item_Price.Text));
                    }
                    else
                    {
                        MessageBox.Show("Item already exist.Please enter different item name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Text_Input_Check();

                if (result == true)
                {
                    db.Update_Exits_Item(id, Item_Name.Text, Convert.ToDouble(Item_Price.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Item_List_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.Item_List_View.Rows[e.RowIndex];
                    Item_Name.Text = row.Cells["Item_name"].Value.ToString();
                    Item_Price.Text = row.Cells["Sell_price"].Value.ToString();
                    id = Convert.ToInt32(row.Cells["Item_setup_id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Cells are for read only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimized_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
