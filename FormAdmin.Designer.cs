namespace baitaplon
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu ";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Giảm giá ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(812, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thanh toán ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số  :";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(590, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 334);
            this.panel2.TabIndex = 7;
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông Tin Hoá Đơn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 334);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drink ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cake ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}