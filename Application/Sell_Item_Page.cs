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
    public partial class Sell_Item_Page : Form
    {
        Database db = new Database();
        public Sell_Item_Page()
        {
            InitializeComponent();
            Seacrh_by_date_panel.Hide();
            Search_by_Name_Panel.Hide();
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
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sell_Item_Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.Sales();
                Sales.DataSource = dt;
            }
            catch (Exception ex)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(item_name_textBox.Text))
                {
                    DialogResult result = MessageBox.Show("Enter Item Name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        item_name_textBox.Focus();
                    }
                }
                else
                {
                    DataTable dt = db.Search_by_ItemName(item_name_textBox.Text);
                    Search_by_Name_dataGridView.DataSource = dt;
                    Search_by_Name_Panel.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_date_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.Search_by_Date(dateTimePicker1.Value.ToString());
                Search_by_date_datagridview.DataSource = dt;
                Seacrh_by_date_panel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_by_Name_exitbtn_Click(object sender, EventArgs e)
        {
            Search_by_Name_Panel.Hide();
        }

        private void Search_by_date_exitbtn_Click(object sender, EventArgs e)
        {
            Seacrh_by_date_panel.Hide();
        }
    }
}
