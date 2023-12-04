namespace Project1
{
    partial class frm_view_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view_staff));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNIM = new System.Windows.Forms.TextBox();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.TxtNoRegist = new System.Windows.Forms.TextBox();
            this.TxtTglLahir = new System.Windows.Forms.TextBox();
            this.TxtAlamat = new System.Windows.Forms.TextBox();
            this.CBJK = new System.Windows.Forms.ComboBox();
            this.CBAgama = new System.Windows.Forms.ComboBox();
            this.TxtProdi = new System.Windows.Forms.TextBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BtnCari = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnApprove = new System.Windows.Forms.Button();
            this.TxtFakultas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBResidence = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(163, 689);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(113, 35);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add Data";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(92, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(92, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nama Mahasiswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(92, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "No Regist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(92, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(720, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Jenis Kelamin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(720, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Agama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(92, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alamat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(720, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fakultas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(720, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Program Studi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(720, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status";
            // 
            // TxtNIM
            // 
            this.TxtNIM.Location = new System.Drawing.Point(266, 82);
            this.TxtNIM.Name = "TxtNIM";
            this.TxtNIM.Size = new System.Drawing.Size(185, 26);
            this.TxtNIM.TabIndex = 15;
            this.TxtNIM.TextChanged += new System.EventHandler(this.TxtNIM_TextChanged);
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(266, 119);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(185, 26);
            this.TxtNama.TabIndex = 16;
            // 
            // TxtNoRegist
            // 
            this.TxtNoRegist.Location = new System.Drawing.Point(266, 158);
            this.TxtNoRegist.Name = "TxtNoRegist";
            this.TxtNoRegist.Size = new System.Drawing.Size(185, 26);
            this.TxtNoRegist.TabIndex = 17;
            // 
            // TxtTglLahir
            // 
            this.TxtTglLahir.Location = new System.Drawing.Point(266, 199);
            this.TxtTglLahir.Name = "TxtTglLahir";
            this.TxtTglLahir.Size = new System.Drawing.Size(185, 26);
            this.TxtTglLahir.TabIndex = 18;
            this.TxtTglLahir.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtAlamat
            // 
            this.TxtAlamat.Location = new System.Drawing.Point(266, 233);
            this.TxtAlamat.Name = "TxtAlamat";
            this.TxtAlamat.Size = new System.Drawing.Size(185, 26);
            this.TxtAlamat.TabIndex = 19;
            // 
            // CBJK
            // 
            this.CBJK.FormattingEnabled = true;
            this.CBJK.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CBJK.Location = new System.Drawing.Point(893, 82);
            this.CBJK.Name = "CBJK";
            this.CBJK.Size = new System.Drawing.Size(175, 28);
            this.CBJK.TabIndex = 20;
            // 
            // CBAgama
            // 
            this.CBAgama.FormattingEnabled = true;
            this.CBAgama.Items.AddRange(new object[] {
            "Advent",
            "Islam",
            "Kristen Protestan",
            "Katolik",
            "Hindu ",
            "Budha",
            "Kong Hu Chu",
            "Lainnya"});
            this.CBAgama.Location = new System.Drawing.Point(893, 116);
            this.CBAgama.Name = "CBAgama";
            this.CBAgama.Size = new System.Drawing.Size(175, 28);
            this.CBAgama.TabIndex = 21;
            // 
            // TxtProdi
            // 
            this.TxtProdi.Location = new System.Drawing.Point(893, 199);
            this.TxtProdi.Name = "TxtProdi";
            this.TxtProdi.Size = new System.Drawing.Size(175, 26);
            this.TxtProdi.TabIndex = 23;
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Approve",
            "Disapprove"});
            this.CBStatus.Location = new System.Drawing.Point(893, 234);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(175, 28);
            this.CBStatus.TabIndex = 24;
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(282, 689);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(113, 35);
            this.BtnCari.TabIndex = 25;
            this.BtnCari.Text = "Search";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(701, 435);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(113, 35);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnApprove
            // 
            this.BtnApprove.Location = new System.Drawing.Point(401, 689);
            this.BtnApprove.Name = "BtnApprove";
            this.BtnApprove.Size = new System.Drawing.Size(113, 35);
            this.BtnApprove.TabIndex = 27;
            this.BtnApprove.Text = "Approve ";
            this.BtnApprove.UseVisualStyleBackColor = true;
            this.BtnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // TxtFakultas
            // 
            this.TxtFakultas.Location = new System.Drawing.Point(893, 158);
            this.TxtFakultas.Name = "TxtFakultas";
            this.TxtFakultas.Size = new System.Drawing.Size(175, 26);
            this.TxtFakultas.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(92, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Status Tempat Tinggal";
            // 
            // CBResidence
            // 
            this.CBResidence.FormattingEnabled = true;
            this.CBResidence.Items.AddRange(new object[] {
            "Long Range",
            "Short Range",
            "Dormitory"});
            this.CBResidence.Location = new System.Drawing.Point(266, 275);
            this.CBResidence.Name = "CBResidence";
            this.CBResidence.Size = new System.Drawing.Size(185, 28);
            this.CBResidence.TabIndex = 30;
            this.CBResidence.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(972, 327);
            this.dataGridView1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 42);
            this.label2.TabIndex = 32;
            this.label2.Text = "Students Profile";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm_view_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 840);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CBResidence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnApprove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.TxtProdi);
            this.Controls.Add(this.TxtFakultas);
            this.Controls.Add(this.CBAgama);
            this.Controls.Add(this.CBJK);
            this.Controls.Add(this.TxtAlamat);
            this.Controls.Add(this.TxtTglLahir);
            this.Controls.Add(this.TxtNoRegist);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.TxtNIM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAdd);
            this.DoubleBuffered = true;
            this.Name = "frm_view_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_view_staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_view_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNIM;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox TxtNoRegist;
        private System.Windows.Forms.TextBox TxtTglLahir;
        private System.Windows.Forms.TextBox TxtAlamat;
        private System.Windows.Forms.ComboBox CBJK;
        private System.Windows.Forms.ComboBox CBAgama;
        private System.Windows.Forms.TextBox TxtProdi;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnApprove;
        private System.Windows.Forms.TextBox TxtFakultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBResidence;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}