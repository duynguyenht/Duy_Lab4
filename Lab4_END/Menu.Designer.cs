namespace Lab4_END
{
    partial class Menu
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
            this.BTN_NhanVien = new System.Windows.Forms.Button();
            this.BTN_PhongBan = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_NhanVien
            // 
            this.BTN_NhanVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_NhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NhanVien.Location = new System.Drawing.Point(158, 230);
            this.BTN_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_NhanVien.Name = "BTN_NhanVien";
            this.BTN_NhanVien.Size = new System.Drawing.Size(209, 81);
            this.BTN_NhanVien.TabIndex = 1;
            this.BTN_NhanVien.Text = "Nhan Vien";
            this.BTN_NhanVien.UseVisualStyleBackColor = false;
            this.BTN_NhanVien.Click += new System.EventHandler(this.BTN_NhanVien_Click);
            // 
            // BTN_PhongBan
            // 
            this.BTN_PhongBan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_PhongBan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PhongBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_PhongBan.Location = new System.Drawing.Point(467, 230);
            this.BTN_PhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_PhongBan.Name = "BTN_PhongBan";
            this.BTN_PhongBan.Size = new System.Drawing.Size(209, 81);
            this.BTN_PhongBan.TabIndex = 2;
            this.BTN_PhongBan.Text = "Phong Ban";
            this.BTN_PhongBan.UseVisualStyleBackColor = false;
            this.BTN_PhongBan.Click += new System.EventHandler(this.BTN_PhongBan_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Exit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.Location = new System.Drawing.Point(321, 339);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(182, 81);
            this.BTN_Exit.TabIndex = 3;
            this.BTN_Exit.Text = "Exit !!!";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHẦN MIỀM QUẢN LÍ NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab4_END.Properties.Resources.Screenshot_2024_05_11_181139;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Lab4_END.Properties.Resources.brackgroup_1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "CÔNG TY DIY";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_PhongBan);
            this.Controls.Add(this.BTN_NhanVien);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_NhanVien;
        private System.Windows.Forms.Button BTN_PhongBan;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

