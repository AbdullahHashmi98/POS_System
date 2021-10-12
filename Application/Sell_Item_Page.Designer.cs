
namespace POS_System
{
    partial class Sell_Item_Page
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
            this.Sales = new System.Windows.Forms.DataGridView();
            this.Sale_List_Label = new System.Windows.Forms.Label();
            this.Search_date_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.item_name_textBox = new System.Windows.Forms.TextBox();
            this.item_name_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Minimized_btn = new System.Windows.Forms.Button();
            this.Search_by_Name_Panel = new System.Windows.Forms.Panel();
            this.Search_by_Name_exitbtn = new System.Windows.Forms.Button();
            this.Search_by_Name_dataGridView = new System.Windows.Forms.DataGridView();
            this.Seacrh_by_date_panel = new System.Windows.Forms.Panel();
            this.Search_by_date_datagridview = new System.Windows.Forms.DataGridView();
            this.Search_by_date_exitbtn = new System.Windows.Forms.Button();
            this.SearchByDate = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sales)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Search_by_Name_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_by_Name_dataGridView)).BeginInit();
            this.Seacrh_by_date_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_by_date_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Sales
            // 
            this.Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sales.Location = new System.Drawing.Point(113, 68);
            this.Sales.Name = "Sales";
            this.Sales.ReadOnly = true;
            this.Sales.Size = new System.Drawing.Size(545, 150);
            this.Sales.TabIndex = 0;
            // 
            // Sale_List_Label
            // 
            this.Sale_List_Label.AutoSize = true;
            this.Sale_List_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sale_List_Label.Location = new System.Drawing.Point(333, 25);
            this.Sale_List_Label.Name = "Sale_List_Label";
            this.Sale_List_Label.Size = new System.Drawing.Size(116, 24);
            this.Sale_List_Label.TabIndex = 1;
            this.Sale_List_Label.Text = "SALE LIST";
            // 
            // Search_date_btn
            // 
            this.Search_date_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_date_btn.Location = new System.Drawing.Point(82, 356);
            this.Search_date_btn.Name = "Search_date_btn";
            this.Search_date_btn.Size = new System.Drawing.Size(144, 32);
            this.Search_date_btn.TabIndex = 2;
            this.Search_date_btn.Text = "Search By Date";
            this.Search_date_btn.UseVisualStyleBackColor = true;
            this.Search_date_btn.Click += new System.EventHandler(this.Search_date_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search By Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // item_name_textBox
            // 
            this.item_name_textBox.Location = new System.Drawing.Point(559, 297);
            this.item_name_textBox.Name = "item_name_textBox";
            this.item_name_textBox.Size = new System.Drawing.Size(135, 20);
            this.item_name_textBox.TabIndex = 5;
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.Location = new System.Drawing.Point(432, 296);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(104, 21);
            this.item_name_label.TabIndex = 6;
            this.item_name_label.Text = "Item Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSetupToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(751, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(37, 23);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Minimized_btn
            // 
            this.Minimized_btn.Location = new System.Drawing.Point(713, 1);
            this.Minimized_btn.Name = "Minimized_btn";
            this.Minimized_btn.Size = new System.Drawing.Size(32, 23);
            this.Minimized_btn.TabIndex = 11;
            this.Minimized_btn.Text = "_";
            this.Minimized_btn.UseVisualStyleBackColor = true;
            this.Minimized_btn.Click += new System.EventHandler(this.Minimized_btn_Click);
            // 
            // Search_by_Name_Panel
            // 
            this.Search_by_Name_Panel.Controls.Add(this.SearchByName);
            this.Search_by_Name_Panel.Controls.Add(this.Search_by_Name_exitbtn);
            this.Search_by_Name_Panel.Controls.Add(this.Search_by_Name_dataGridView);
            this.Search_by_Name_Panel.Location = new System.Drawing.Point(0, 0);
            this.Search_by_Name_Panel.Name = "Search_by_Name_Panel";
            this.Search_by_Name_Panel.Size = new System.Drawing.Size(800, 150);
            this.Search_by_Name_Panel.TabIndex = 12;
            // 
            // Search_by_Name_exitbtn
            // 
            this.Search_by_Name_exitbtn.BackColor = System.Drawing.Color.White;
            this.Search_by_Name_exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_by_Name_exitbtn.Location = new System.Drawing.Point(751, 12);
            this.Search_by_Name_exitbtn.Name = "Search_by_Name_exitbtn";
            this.Search_by_Name_exitbtn.Size = new System.Drawing.Size(37, 23);
            this.Search_by_Name_exitbtn.TabIndex = 11;
            this.Search_by_Name_exitbtn.Text = "X";
            this.Search_by_Name_exitbtn.UseVisualStyleBackColor = false;
            this.Search_by_Name_exitbtn.Click += new System.EventHandler(this.Search_by_Name_exitbtn_Click);
            // 
            // Search_by_Name_dataGridView
            // 
            this.Search_by_Name_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_by_Name_dataGridView.Location = new System.Drawing.Point(112, 3);
            this.Search_by_Name_dataGridView.Name = "Search_by_Name_dataGridView";
            this.Search_by_Name_dataGridView.ReadOnly = true;
            this.Search_by_Name_dataGridView.Size = new System.Drawing.Size(546, 147);
            this.Search_by_Name_dataGridView.TabIndex = 0;
            // 
            // Seacrh_by_date_panel
            // 
            this.Seacrh_by_date_panel.Controls.Add(this.Search_by_Name_Panel);
            this.Seacrh_by_date_panel.Controls.Add(this.SearchByDate);
            this.Seacrh_by_date_panel.Controls.Add(this.Search_by_date_exitbtn);
            this.Seacrh_by_date_panel.Controls.Add(this.Search_by_date_datagridview);
            this.Seacrh_by_date_panel.Location = new System.Drawing.Point(0, 68);
            this.Seacrh_by_date_panel.Name = "Seacrh_by_date_panel";
            this.Seacrh_by_date_panel.Size = new System.Drawing.Size(800, 150);
            this.Seacrh_by_date_panel.TabIndex = 12;
            // 
            // Search_by_date_datagridview
            // 
            this.Search_by_date_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_by_date_datagridview.Location = new System.Drawing.Point(112, 0);
            this.Search_by_date_datagridview.Name = "Search_by_date_datagridview";
            this.Search_by_date_datagridview.Size = new System.Drawing.Size(546, 147);
            this.Search_by_date_datagridview.TabIndex = 0;
            // 
            // Search_by_date_exitbtn
            // 
            this.Search_by_date_exitbtn.BackColor = System.Drawing.Color.White;
            this.Search_by_date_exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_by_date_exitbtn.Location = new System.Drawing.Point(751, 13);
            this.Search_by_date_exitbtn.Name = "Search_by_date_exitbtn";
            this.Search_by_date_exitbtn.Size = new System.Drawing.Size(37, 23);
            this.Search_by_date_exitbtn.TabIndex = 12;
            this.Search_by_date_exitbtn.Text = "X";
            this.Search_by_date_exitbtn.UseVisualStyleBackColor = false;
            this.Search_by_date_exitbtn.Click += new System.EventHandler(this.Search_by_date_exitbtn_Click);
            // 
            // SearchByDate
            // 
            this.SearchByDate.AutoSize = true;
            this.SearchByDate.Location = new System.Drawing.Point(12, 23);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(82, 13);
            this.SearchByDate.TabIndex = 13;
            this.SearchByDate.Text = "Search By Date";
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Location = new System.Drawing.Point(15, 22);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(87, 13);
            this.SearchByName.TabIndex = 14;
            this.SearchByName.Text = "Search By Name";
            // 
            // Sell_Item_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seacrh_by_date_panel);
            this.Controls.Add(this.Minimized_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.item_name_textBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search_date_btn);
            this.Controls.Add(this.Sale_List_Label);
            this.Controls.Add(this.Sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sell_Item_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALES";
            this.Load += new System.EventHandler(this.Sell_Item_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sales)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Search_by_Name_Panel.ResumeLayout(false);
            this.Search_by_Name_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_by_Name_dataGridView)).EndInit();
            this.Seacrh_by_date_panel.ResumeLayout(false);
            this.Seacrh_by_date_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_by_date_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Sales;
        private System.Windows.Forms.Label Sale_List_Label;
        private System.Windows.Forms.Button Search_date_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox item_name_textBox;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Minimized_btn;
        private System.Windows.Forms.Panel Search_by_Name_Panel;
        private System.Windows.Forms.Button Search_by_Name_exitbtn;
        private System.Windows.Forms.DataGridView Search_by_Name_dataGridView;
        private System.Windows.Forms.Panel Seacrh_by_date_panel;
        private System.Windows.Forms.Button Search_by_date_exitbtn;
        private System.Windows.Forms.DataGridView Search_by_date_datagridview;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.Label SearchByDate;
    }
}