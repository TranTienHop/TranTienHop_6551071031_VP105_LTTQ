namespace TranTienHop_6551071031_VP105_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbDanhSachThietBi = new GroupBox();
            dgvDanhSachThietBi = new DataGridView();
            gpbThongTinThietBi = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gpbThaoTac = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            gpbDanhSachThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).BeginInit();
            gpbThongTinThietBi.SuspendLayout();
            gpbThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // gpbDanhSachThietBi
            // 
            gpbDanhSachThietBi.Controls.Add(dgvDanhSachThietBi);
            gpbDanhSachThietBi.Location = new Point(12, 36);
            gpbDanhSachThietBi.Name = "gpbDanhSachThietBi";
            gpbDanhSachThietBi.Size = new Size(479, 412);
            gpbDanhSachThietBi.TabIndex = 0;
            gpbDanhSachThietBi.TabStop = false;
            gpbDanhSachThietBi.Text = "Danh Sách Thiết Bị";
            // 
            // dgvDanhSachThietBi
            // 
            dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThietBi.Location = new Point(6, 26);
            dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            dgvDanhSachThietBi.ReadOnly = true;
            dgvDanhSachThietBi.RowHeadersWidth = 51;
            dgvDanhSachThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachThietBi.Size = new Size(467, 380);
            dgvDanhSachThietBi.TabIndex = 0;
            dgvDanhSachThietBi.CellClick += dgvDanhSachThietBi_CellClick;
            // 
            // gpbThongTinThietBi
            // 
            gpbThongTinThietBi.Controls.Add(textBox3);
            gpbThongTinThietBi.Controls.Add(textBox2);
            gpbThongTinThietBi.Controls.Add(textBox1);
            gpbThongTinThietBi.Controls.Add(label3);
            gpbThongTinThietBi.Controls.Add(label2);
            gpbThongTinThietBi.Controls.Add(label1);
            gpbThongTinThietBi.Location = new Point(519, 49);
            gpbThongTinThietBi.Name = "gpbThongTinThietBi";
            gpbThongTinThietBi.Size = new Size(278, 183);
            gpbThongTinThietBi.TabIndex = 1;
            gpbThongTinThietBi.TabStop = false;
            gpbThongTinThietBi.Text = "Thông tin thiết bị";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 118);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá (VND):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 77);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên thiết bị:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thiết bị:";
            // 
            // gpbThaoTac
            // 
            gpbThaoTac.Controls.Add(btnXoa);
            gpbThaoTac.Controls.Add(btnSua);
            gpbThaoTac.Controls.Add(btnThoat);
            gpbThaoTac.Controls.Add(btnThem);
            gpbThaoTac.Location = new Point(521, 252);
            gpbThaoTac.Name = "gpbThaoTac";
            gpbThaoTac.Size = new Size(276, 196);
            gpbThaoTac.TabIndex = 2;
            gpbThaoTac.TabStop = false;
            gpbThaoTac.Text = "Thao Tác";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(135, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(20, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(135, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 475);
            Controls.Add(gpbThaoTac);
            Controls.Add(gpbThongTinThietBi);
            Controls.Add(gpbDanhSachThietBi);
            Name = "Form1";
            Text = "Quản lí thiết bị / Vật Tư - VP105";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Click += Form1_Click;
            gpbDanhSachThietBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).EndInit();
            gpbThongTinThietBi.ResumeLayout(false);
            gpbThongTinThietBi.PerformLayout();
            gpbThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbDanhSachThietBi;
        private DataGridView dgvDanhSachThietBi;
        private GroupBox gpbThongTinThietBi;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gpbThaoTac;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
