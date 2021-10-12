using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Sell_Page : Form
    {
        Database db = new Database();
        int i = 1;
        int rowindex;
        public Sell_Page()
        {
            InitializeComponent();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Item_Setup_Page item_setup = new Item_Setup_Page();
                item_setup.Show();
                this.Hide();
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
                this.Refresh();
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

        private void Sell_Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.Item_List();
                Item_List_View.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Discount_Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble(Discount_Textbox.Text) > Convert.ToDouble(Total_Amount_Textbox.Text))
                {
                    DialogResult result =  MessageBox.Show("Discount amount exceeded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Discount_Textbox.Focus();
                    }
                }
                else
                {
                    Final_amount_textbox.Text = (Convert.ToDouble(Total_Amount_Textbox.Text) - Convert.ToDouble(Discount_Textbox.Text)).ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Sell_List_View.Rows.Clear();
                Total_Amount_Textbox.Clear();
                Discount_Textbox.Text = 0.ToString();
                Final_amount_textbox.Clear();
                Item_name_textbox.Clear();
                Item_price_textbox.Clear();
                Qty_textbox.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if((String.IsNullOrEmpty(Item_name_textbox.Text)) || (String.IsNullOrEmpty(Item_price_textbox.Text)) || (String.IsNullOrEmpty(Qty_textbox.Value.ToString())))
                {
                    MessageBox.Show("Empty Textboxes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Sell_List_View.Rows.Add(i++, Item_name_textbox.Text, Item_price_textbox.Text, Qty_textbox.Value.ToString(),(Convert.ToDecimal(Item_price_textbox.Text) * Qty_textbox.Value));
                    Item_name_textbox.Clear();
                    Item_price_textbox.Clear();
                    Qty_textbox.Value = 0;
                    Total_Amount_Textbox.Text = Sell_List_View.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                    Final_amount_textbox.Text = (Convert.ToDouble(Total_Amount_Textbox.Text) - Convert.ToDouble(Discount_Textbox.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow data = Sell_List_View.Rows[rowindex];

                data.Cells[1].Value = Item_name_textbox.Text;
                data.Cells[2].Value = Item_price_textbox.Text;
                data.Cells[3].Value = Qty_textbox.Text;
                data.Cells[4].Value = (Qty_textbox.Value * Convert.ToDecimal(Item_price_textbox.Text));
                Item_name_textbox.Clear();
                Item_price_textbox.Clear();
                Qty_textbox.Value = 0;
                Total_Amount_Textbox.Text = Sell_List_View.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                Final_amount_textbox.Text = (Convert.ToDouble(Total_Amount_Textbox.Text) - Convert.ToDouble(Discount_Textbox.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sell_List_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.Sell_List_View.Rows[e.RowIndex];
                    Item_name_textbox.Text = row.Cells["ItemNameCol"].Value.ToString();
                    Item_price_textbox.Text = row.Cells["ItemPriceCol"].Value.ToString();
                    Qty_textbox.Text = row.Cells["QuantityCol"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Cells are for read only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Item_name_textbox.Text = row.Cells[1].Value.ToString();
                    Item_price_textbox.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Cells are for read only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Sell_List_View.Rows.Count == 0)
                {
                    MessageBox.Show("Bill is empty.There is no item in bill to sell.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for(int rows = 0; rows < Sell_List_View.Rows.Count-1; rows++)
                    {
                        db.Confirm_Bill(Sell_List_View.Rows[rows].Cells[1].Value.ToString(), Convert.ToDouble(Sell_List_View.Rows[rows].Cells[2].Value), Convert.ToInt16(Sell_List_View.Rows[rows].Cells[3].Value), dateTimePicker1.Value.ToString());
                    }
                }
                Sell_List_View.Rows.Clear();
                Total_Amount_Textbox.Clear();
                Discount_Textbox.Text = 0.ToString();
                Final_amount_textbox.Clear();
                Item_name_textbox.Clear();
                Item_price_textbox.Clear();
                Qty_textbox.Value = 0;
                MessageBox.Show("Bill is confirmed.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}