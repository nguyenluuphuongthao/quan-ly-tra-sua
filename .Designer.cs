namespace baitaplon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.butdangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu : ";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(200, 161);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(176, 25);
            this.txtusername.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(200, 213);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(176, 25);
            this.txtpass.TabIndex = 5;
            // 
            // butdangnhap
            // 
            this.butdangnhap.BackColor = System.Drawing.Color.Transparent;
            this.butdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butdangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdangnhap.Location = new System.Drawing.Point(285, 264);
            this.butdangnhap.Name = "butdangnhap";
            this.butdangnhap.Size = new System.Drawing.Size(112, 31);
            this.butdangnhap.TabIndex = 0;
            this.butdangnhap.Text = "Đăng nhập";
            this.butdangnhap.UseVisualStyleBackColor = false;
            this.butdangnhap.Click += new System.EventHandler(this.butdangnhap_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.butdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::baitaplon.Properties.Resources.abstract_comic_book_background_design_vector1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(419, 323);
            this.ControlBox = false;
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butdangnhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
    }
}

