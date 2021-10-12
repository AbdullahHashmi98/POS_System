
namespace POS_System
{
    partial class Sell_Page
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
            this.Item_name_textbox = new System.Windows.Forms.TextBox();
            this.Item_price_textbox = new System.Windows.Forms.TextBox();
            this.Item_Name_Label = new System.Windows.Forms.Label();
            this.Item_price_label = new System.Windows.Forms.Label();
            this.Qty_textbox = new System.Windows.Forms.NumericUpDown();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Item_List_View = new System.Windows.Forms.DataGridView();
            this.Item_List_Label = new System.Windows.Forms.Label();
            this.Total_Amount_Label = new System.Windows.Forms.Label();
            this.Discount_Label = new System.Windows.Forms.Label();
            this.Final_Amount_Label = new System.Windows.Forms.Label();
            this.Total_Amount_Textbox = new System.Windows.Forms.TextBox();
            this.Discount_Textbox = new System.Windows.Forms.TextBox();
            this.Final_amount_textbox = new System.Windows.Forms.TextBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Sell_List_View = new System.Windows.Forms.DataGridView();
            this.S_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell_List_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Minimized_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_List_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sell_List_View)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item_name_textbox
            // 
            this.Item_name_textbox.Location = new System.Drawing.Point(155, 460);
            this.Item_name_textbox.Name = "Item_name_textbox";
            this.Item_name_textbox.ReadOnly = true;
            this.Item_name_textbox.Size = new System.Drawing.Size(200, 20);
            this.Item_name_textbox.TabIndex = 0;
            // 
            // Item_price_textbox
            // 
            this.Item_price_textbox.Location = new System.Drawing.Point(494, 457);
            this.Item_price_textbox.Name = "Item_price_textbox";
            this.Item_price_textbox.ReadOnly = true;
            this.Item_price_textbox.Size = new System.Drawing.Size(73, 20);
            this.Item_price_textbox.TabIndex = 1;
            // 
            // Item_Name_Label
            // 
            this.Item_Name_Label.AutoSize = true;
            this.Item_Name_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name_Label.Location = new System.Drawing.Point(45, 459);
            this.Item_Name_Label.Name = "Item_Name_Label";
            this.Item_Name_Label.Size = new System.Drawing.Size(104, 21);
            this.Item_Name_Label.TabIndex = 2;
            this.Item_Name_Label.Text = "Item Name";
            // 
            // Item_price_label
            // 
            this.Item_price_label.AutoSize = true;
            this.Item_price_label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_price_label.Location = new System.Drawing.Point(386, 457);
            this.Item_price_label.Name = "Item_price_label";
            this.Item_price_label.Size = new System.Drawing.Size(102, 21);
            this.Item_price_label.TabIndex = 3;
            this.Item_price_label.Text = "Item Price";
            // 
            // Qty_textbox
            // 
            this.Qty_textbox.Location = new System.Drawing.Point(708, 454);
            this.Qty_textbox.Name = "Qty_textbox";
            this.Qty_textbox.Size = new System.Drawing.Size(68, 20);
            this.Qty_textbox.TabIndex = 4;
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_Label.Location = new System.Drawing.Point(606, 454);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(86, 21);
            this.Quantity_Label.TabIndex = 5;
            this.Quantity_Label.Text = "Quantity";
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(49, 529);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(76, 31);
            this.Add_btn.TabIndex = 6;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(342, 529);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(77, 31);
            this.Update_btn.TabIndex = 7;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(647, 529);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(75, 31);
            this.Reset_btn.TabIndex = 8;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Item_List_View
            // 
            this.Item_List_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Item_List_View.Location = new System.Drawing.Point(24, 268);
            this.Item_List_View.Name = "Item_List_View";
            this.Item_List_View.ReadOnly = true;
            this.Item_List_View.Size = new System.Drawing.Size(345, 150);
            this.Item_List_View.TabIndex = 9;
            this.Item_List_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Item_List_View_CellClick);
            // 
            // Item_List_Label
            // 
            this.Item_List_Label.AutoSize = true;
            this.Item_List_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_List_Label.Location = new System.Drawing.Point(140, 241);
            this.Item_List_Label.Name = "Item_List_Label";
            this.Item_List_Label.Size = new System.Drawing.Size(90, 24);
            this.Item_List_Label.TabIndex = 10;
            this.Item_List_Label.Text = "Item List";
            // 
            // Total_Amount_Label
            // 
            this.Total_Amount_Label.AutoSize = true;
            this.Total_Amount_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Amount_Label.Location = new System.Drawing.Point(499, 278);
            this.Total_Amount_Label.Name = "Total_Amount_Label";
            this.Total_Amount_Label.Size = new System.Drawing.Size(131, 21);
            this.Total_Amount_Label.TabIndex = 11;
            this.Total_Amount_Label.Text = "Total Amount";
            // 
            // Discount_Label
            // 
            this.Discount_Label.AutoSize = true;
            this.Discount_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_Label.Location = new System.Drawing.Point(499, 323);
            this.Discount_Label.Name = "Discount_Label";
            this.Discount_Label.Size = new System.Drawing.Size(158, 21);
            this.Discount_Label.TabIndex = 12;
            this.Discount_Label.Text = "Discount(If any)";
            // 
            // Final_Amount_Label
            // 
            this.Final_Amount_Label.AutoSize = true;
            this.Final_Amount_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Final_Amount_Label.Location = new System.Drawing.Point(499, 363);
            this.Final_Amount_Label.Name = "Final_Amount_Label";
            this.Final_Amount_Label.Size = new System.Drawing.Size(132, 21);
            this.Final_Amount_Label.TabIndex = 13;
            this.Final_Amount_Label.Text = "Final Amount";
            // 
            // Total_Amount_Textbox
            // 
            this.Total_Amount_Textbox.Location = new System.Drawing.Point(647, 278);
            this.Total_Amount_Textbox.Name = "Total_Amount_Textbox";
            this.Total_Amount_Textbox.ReadOnly = true;
            this.Total_Amount_Textbox.Size = new System.Drawing.Size(129, 20);
            this.Total_Amount_Textbox.TabIndex = 14;
            // 
            // Discount_Textbox
            // 
            this.Discount_Textbox.Location = new System.Drawing.Point(664, 323);
            this.Discount_Textbox.Name = "Discount_Textbox";
            this.Discount_Textbox.Size = new System.Drawing.Size(112, 20);
            this.Discount_Textbox.TabIndex = 15;
            this.Discount_Textbox.Text = "0";
            this.Discount_Textbox.TextChanged += new System.EventHandler(this.Discount_Textbox_TextChanged);
            // 
            // Final_amount_textbox
            // 
            this.Final_amount_textbox.Location = new System.Drawing.Point(647, 363);
            this.Final_amount_textbox.Name = "Final_amount_textbox";
            this.Final_amount_textbox.ReadOnly = true;
            this.Final_amount_textbox.Size = new System.Drawing.Size(129, 20);
            this.Final_amount_textbox.TabIndex = 16;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(687, 401);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(89, 34);
            this.Confirm_btn.TabIndex = 17;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Sell_List_View
            // 
            this.Sell_List_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sell_List_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_No,
            this.ItemNameCol,
            this.ItemPriceCol,
            this.QuantityCol,
            this.AmountCol});
            this.Sell_List_View.Location = new System.Drawing.Point(132, 53);
            this.Sell_List_View.Name = "Sell_List_View";
            this.Sell_List_View.ReadOnly = true;
            this.Sell_List_View.Size = new System.Drawing.Size(544, 169);
            this.Sell_List_View.TabIndex = 18;
            this.Sell_List_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sell_List_View_CellClick);
            // 
            // S_No
            // 
            this.S_No.HeaderText = "S_No.";
            this.S_No.Name = "S_No";
            this.S_No.ReadOnly = true;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.HeaderText = "Item Name";
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ItemPriceCol
            // 
            this.ItemPriceCol.HeaderText = "Item Price";
            this.ItemPriceCol.Name = "ItemPriceCol";
            this.ItemPriceCol.ReadOnly = true;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.ReadOnly = true;
            // 
            // AmountCol
            // 
            this.AmountCol.HeaderText = "Amount";
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.ReadOnly = true;
            // 
            // Sell_List_Label
            // 
            this.Sell_List_Label.AutoSize = true;
            this.Sell_List_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_List_Label.Location = new System.Drawing.Point(386, 24);
            this.Sell_List_Label.Name = "Sell_List_Label";
            this.Sell_List_Label.Size = new System.Drawing.Size(86, 24);
            this.Sell_List_Label.TabIndex = 19;
            this.Sell_List_Label.Text = "Sell List ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(636, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
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
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 21;
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
            // Minimized_btn
            // 
            this.Minimized_btn.Location = new System.Drawing.Point(775, 1);
            this.Minimized_btn.Name = "Minimized_btn";
            this.Minimized_btn.Size = new System.Drawing.Size(32, 23);
            this.Minimized_btn.TabIndex = 22;
            this.Minimized_btn.Text = "_";
            this.Minimized_btn.UseVisualStyleBackColor = true;
            this.Minimized_btn.Click += new System.EventHandler(this.Minimized_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(813, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(37, 23);
            this.Exit_btn.TabIndex = 23;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Sell_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 590);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Minimized_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Sell_List_Label);
            this.Controls.Add(this.Sell_List_View);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Final_amount_textbox);
            this.Controls.Add(this.Discount_Textbox);
            this.Controls.Add(this.Total_Amount_Textbox);
            this.Controls.Add(this.Final_Amount_Label);
            this.Controls.Add(this.Discount_Label);
            this.Controls.Add(this.Total_Amount_Label);
            this.Controls.Add(this.Item_List_Label);
            this.Controls.Add(this.Item_List_View);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Quantity_Label);
            this.Controls.Add(this.Qty_textbox);
            this.Controls.Add(this.Item_price_label);
            this.Controls.Add(this.Item_Name_Label);
            this.Controls.Add(this.Item_price_textbox);
            this.Controls.Add(this.Item_name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sell_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELL PAGE";
            this.Load += new System.EventHandler(this.Sell_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qty_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_List_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sell_List_View)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_name_textbox;
        private System.Windows.Forms.TextBox Item_price_textbox;
        private System.Windows.Forms.Label Item_Name_Label;
        private System.Windows.Forms.Label Item_price_label;
        private System.Windows.Forms.NumericUpDown Qty_textbox;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.DataGridView Item_List_View;
        private System.Windows.Forms.Label Item_List_Label;
        private System.Windows.Forms.Label Total_Amount_Label;
        private System.Windows.Forms.Label Discount_Label;
        private System.Windows.Forms.Label Final_Amount_Label;
        private System.Windows.Forms.TextBox Total_Amount_Textbox;
        private System.Windows.Forms.TextBox Discount_Textbox;
        private System.Windows.Forms.TextBox Final_amount_textbox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.DataGridView Sell_List_View;
        private System.Windows.Forms.Label Sell_List_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.Button Minimized_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
    }
}