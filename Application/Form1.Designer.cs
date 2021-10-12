
namespace POS_System
{
    partial class Item_Setup_Page
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
            this.Item_Name = new System.Windows.Forms.TextBox();
            this.Item_Price = new System.Windows.Forms.TextBox();
            this.Item_Name_Label = new System.Windows.Forms.Label();
            this.Item_Price_Label = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Item_List_View = new System.Windows.Forms.DataGridView();
            this.Item_list_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Minimized_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Item_List_View)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item_Name
            // 
            this.Item_Name.Location = new System.Drawing.Point(163, 285);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(216, 20);
            this.Item_Name.TabIndex = 0;
            // 
            // Item_Price
            // 
            this.Item_Price.Location = new System.Drawing.Point(552, 282);
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Size = new System.Drawing.Size(216, 20);
            this.Item_Price.TabIndex = 1;
            // 
            // Item_Name_Label
            // 
            this.Item_Name_Label.AutoSize = true;
            this.Item_Name_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name_Label.Location = new System.Drawing.Point(34, 285);
            this.Item_Name_Label.Name = "Item_Name_Label";
            this.Item_Name_Label.Size = new System.Drawing.Size(104, 21);
            this.Item_Name_Label.TabIndex = 2;
            this.Item_Name_Label.Text = "Item Name";
            // 
            // Item_Price_Label
            // 
            this.Item_Price_Label.AutoSize = true;
            this.Item_Price_Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Price_Label.Location = new System.Drawing.Point(399, 282);
            this.Item_Price_Label.Name = "Item_Price_Label";
            this.Item_Price_Label.Size = new System.Drawing.Size(102, 21);
            this.Item_Price_Label.TabIndex = 3;
            this.Item_Price_Label.Text = "Item Price";
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(652, 397);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(78, 34);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Item_List_View
            // 
            this.Item_List_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Item_List_View.Location = new System.Drawing.Point(239, 63);
            this.Item_List_View.Name = "Item_List_View";
            this.Item_List_View.ReadOnly = true;
            this.Item_List_View.Size = new System.Drawing.Size(343, 173);
            this.Item_List_View.TabIndex = 6;
            this.Item_List_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Item_List_View_CellClick);
            // 
            // Item_list_label
            // 
            this.Item_list_label.AutoSize = true;
            this.Item_list_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_list_label.Location = new System.Drawing.Point(361, 25);
            this.Item_list_label.Name = "Item_list_label";
            this.Item_list_label.Size = new System.Drawing.Size(114, 24);
            this.Item_list_label.TabIndex = 7;
            this.Item_list_label.Text = "ITEM LIST";
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
            this.menuStrip1.TabIndex = 8;
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
            this.Exit_btn.TabIndex = 11;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Minimized_btn
            // 
            this.Minimized_btn.Location = new System.Drawing.Point(713, 1);
            this.Minimized_btn.Name = "Minimized_btn";
            this.Minimized_btn.Size = new System.Drawing.Size(32, 23);
            this.Minimized_btn.TabIndex = 12;
            this.Minimized_btn.Text = "_";
            this.Minimized_btn.UseVisualStyleBackColor = true;
            this.Minimized_btn.Click += new System.EventHandler(this.Minimized_btn_Click);
            // 
            // Item_Setup_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Minimized_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Item_list_label);
            this.Controls.Add(this.Item_List_View);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Item_Price_Label);
            this.Controls.Add(this.Item_Name_Label);
            this.Controls.Add(this.Item_Price);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Item_Setup_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEM SETUP PAGE";
            this.Load += new System.EventHandler(this.Item_Setup_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Item_List_View)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_Name;
        private System.Windows.Forms.TextBox Item_Price;
        private System.Windows.Forms.Label Item_Name_Label;
        private System.Windows.Forms.Label Item_Price_Label;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Item_List_View;
        private System.Windows.Forms.Label Item_list_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Minimized_btn;
    }
}

