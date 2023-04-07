namespace Proyek_Riwayat_Uang
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_setUang = new System.Windows.Forms.Button();
            this.box_Uang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_riwayat = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_Pengeluaran = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_AddRiwayat = new System.Windows.Forms.Button();
            this.box_Pendapatan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_riwayat)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(47)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atur Pengeluaran Uang Anda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(88)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btn_setUang);
            this.panel2.Controls.Add(this.box_Uang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 277);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 165);
            this.panel2.TabIndex = 1;
            // 
            // btn_setUang
            // 
            this.btn_setUang.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_setUang.FlatAppearance.BorderSize = 0;
            this.btn_setUang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setUang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.btn_setUang.Location = new System.Drawing.Point(66, 116);
            this.btn_setUang.Name = "btn_setUang";
            this.btn_setUang.Size = new System.Drawing.Size(72, 30);
            this.btn_setUang.TabIndex = 2;
            this.btn_setUang.TabStop = false;
            this.btn_setUang.Text = "Set Uang";
            this.btn_setUang.UseVisualStyleBackColor = false;
            this.btn_setUang.Click += new System.EventHandler(this.btn_setUang_Click);
            // 
            // box_Uang
            // 
            this.box_Uang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(88)))), ((int)(((byte)(25)))));
            this.box_Uang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_Uang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.box_Uang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Uang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(52)))));
            this.box_Uang.Location = new System.Drawing.Point(10, 66);
            this.box_Uang.Margin = new System.Windows.Forms.Padding(10);
            this.box_Uang.Name = "box_Uang";
            this.box_Uang.ShortcutsEnabled = false;
            this.box_Uang.Size = new System.Drawing.Size(185, 20);
            this.box_Uang.TabIndex = 1;
            this.box_Uang.TabStop = false;
            this.box_Uang.Text = "10000";
            this.box_Uang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uang Anda";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.dataGridView_riwayat);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(158)))), ((int)(((byte)(78)))));
            this.panel3.Location = new System.Drawing.Point(234, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 388);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView_riwayat
            // 
            this.dataGridView_riwayat.AllowUserToAddRows = false;
            this.dataGridView_riwayat.AllowUserToDeleteRows = false;
            this.dataGridView_riwayat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.dataGridView_riwayat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_riwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_riwayat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(158)))), ((int)(((byte)(78)))));
            this.dataGridView_riwayat.Location = new System.Drawing.Point(5, 5);
            this.dataGridView_riwayat.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_riwayat.Name = "dataGridView_riwayat";
            this.dataGridView_riwayat.ReadOnly = true;
            this.dataGridView_riwayat.Size = new System.Drawing.Size(521, 378);
            this.dataGridView_riwayat.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.box_Pengeluaran);
            this.panel4.Controls.Add(this.btn_Clear);
            this.panel4.Controls.Add(this.btn_AddRiwayat);
            this.panel4.Controls.Add(this.box_Pendapatan);
            this.panel4.Controls.Add(this.label3);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(14, 59);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 208);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(233)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(53, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Pendapatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(51, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Pengeluaran";
            // 
            // box_Pengeluaran
            // 
            this.box_Pengeluaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.box_Pengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_Pengeluaran.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.box_Pengeluaran.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Pengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.box_Pengeluaran.Location = new System.Drawing.Point(9, 128);
            this.box_Pengeluaran.Margin = new System.Windows.Forms.Padding(10);
            this.box_Pengeluaran.Name = "box_Pengeluaran";
            this.box_Pengeluaran.ReadOnly = true;
            this.box_Pengeluaran.ShortcutsEnabled = false;
            this.box_Pengeluaran.Size = new System.Drawing.Size(185, 20);
            this.box_Pengeluaran.TabIndex = 4;
            this.box_Pengeluaran.TabStop = false;
            this.box_Pengeluaran.Text = "10000";
            this.box_Pengeluaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.btn_Clear.Location = new System.Drawing.Point(5, 168);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 30);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Hapus Semua";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_AddRiwayat
            // 
            this.btn_AddRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.btn_AddRiwayat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.btn_AddRiwayat.FlatAppearance.BorderSize = 0;
            this.btn_AddRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.btn_AddRiwayat.Location = new System.Drawing.Point(100, 168);
            this.btn_AddRiwayat.Margin = new System.Windows.Forms.Padding(10);
            this.btn_AddRiwayat.Name = "btn_AddRiwayat";
            this.btn_AddRiwayat.Size = new System.Drawing.Size(100, 30);
            this.btn_AddRiwayat.TabIndex = 2;
            this.btn_AddRiwayat.TabStop = false;
            this.btn_AddRiwayat.Text = "Tambah Riwayat";
            this.btn_AddRiwayat.UseVisualStyleBackColor = false;
            this.btn_AddRiwayat.Click += new System.EventHandler(this.btn_AddRiwayat_Click);
            // 
            // box_Pendapatan
            // 
            this.box_Pendapatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.box_Pendapatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_Pendapatan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.box_Pendapatan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Pendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.box_Pendapatan.Location = new System.Drawing.Point(9, 72);
            this.box_Pendapatan.Margin = new System.Windows.Forms.Padding(10);
            this.box_Pendapatan.Name = "box_Pendapatan";
            this.box_Pendapatan.ReadOnly = true;
            this.box_Pendapatan.ShortcutsEnabled = false;
            this.box_Pendapatan.Size = new System.Drawing.Size(185, 20);
            this.box_Pendapatan.TabIndex = 1;
            this.box_Pendapatan.TabStop = false;
            this.box_Pendapatan.Text = "10000";
            this.box_Pendapatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(51, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Riwayat";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "App";
            this.Text = "Riwayat Uang by maul-lq";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppExit);
            this.Load += new System.EventHandler(this.App_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_riwayat)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_setUang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_riwayat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_Pengeluaran;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_AddRiwayat;
        private System.Windows.Forms.TextBox box_Pendapatan;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox box_Uang;
    }
}