namespace Proyek_Riwayat_Uang
{
    partial class TambahRiwayat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.box_uang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pengeluaran = new System.Windows.Forms.RadioButton();
            this.pendapatan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.riwayatlebihdari1 = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.note);
            this.panel1.Controls.Add(this.btn_batal);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.riwayatlebihdari1);
            this.panel1.Controls.Add(this.tanggal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pendapatan);
            this.panel1.Controls.Add(this.pengeluaran);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.box_uang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(19, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 268);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status Riwayat";
            // 
            // box_uang
            // 
            this.box_uang.Location = new System.Drawing.Point(23, 45);
            this.box_uang.Name = "box_uang";
            this.box_uang.Size = new System.Drawing.Size(250, 25);
            this.box_uang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 30);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(214, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambah Riwayat Anda";
            // 
            // pengeluaran
            // 
            this.pengeluaran.AutoSize = true;
            this.pengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.pengeluaran.Location = new System.Drawing.Point(23, 108);
            this.pengeluaran.Name = "pengeluaran";
            this.pengeluaran.Size = new System.Drawing.Size(98, 21);
            this.pengeluaran.TabIndex = 5;
            this.pengeluaran.TabStop = true;
            this.pengeluaran.Text = "Pengeluaran";
            this.pengeluaran.UseVisualStyleBackColor = true;
            // 
            // pendapatan
            // 
            this.pendapatan.AutoSize = true;
            this.pendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(233)))), ((int)(((byte)(30)))));
            this.pendapatan.Location = new System.Drawing.Point(178, 108);
            this.pendapatan.Name = "pendapatan";
            this.pendapatan.Size = new System.Drawing.Size(95, 21);
            this.pendapatan.TabIndex = 6;
            this.pendapatan.TabStop = true;
            this.pendapatan.Text = "Pendapatan";
            this.pendapatan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggal";
            // 
            // tanggal
            // 
            this.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggal.Location = new System.Drawing.Point(23, 167);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(88, 25);
            this.tanggal.TabIndex = 8;
            this.tanggal.Value = new System.DateTime(2023, 4, 7, 0, 0, 0, 0);
            // 
            // riwayatlebihdari1
            // 
            this.riwayatlebihdari1.AutoSize = true;
            this.riwayatlebihdari1.ForeColor = System.Drawing.Color.Snow;
            this.riwayatlebihdari1.Location = new System.Drawing.Point(178, 227);
            this.riwayatlebihdari1.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.riwayatlebihdari1.Name = "riwayatlebihdari1";
            this.riwayatlebihdari1.Size = new System.Drawing.Size(95, 21);
            this.riwayatlebihdari1.TabIndex = 9;
            this.riwayatlebihdari1.Text = "Riwayat > 1";
            this.riwayatlebihdari1.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.ForeColor = System.Drawing.Color.Snow;
            this.btn_submit.Location = new System.Drawing.Point(103, 221);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(62, 30);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal.ForeColor = System.Drawing.Color.Snow;
            this.btn_batal.Location = new System.Drawing.Point(23, 221);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(62, 30);
            this.btn_batal.TabIndex = 11;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(296, 45);
            this.note.Name = "note";
            this.note.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.note.Size = new System.Drawing.Size(221, 206);
            this.note.TabIndex = 12;
            this.note.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(293, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Catatan";
            // 
            // TambahRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(573, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TambahRiwayat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahRiwayat";
            this.Load += new System.EventHandler(this.TambahRiwayat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_uang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton pendapatan;
        private System.Windows.Forms.RadioButton pengeluaran;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox riwayatlebihdari1;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox note;
    }
}