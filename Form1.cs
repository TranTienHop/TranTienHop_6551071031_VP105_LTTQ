using System.Globalization;
using TranTienHop_6551071031_VP105_LTTQ.Models;

namespace TranTienHop_6551071031_VP105_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            LoadDanhSachThietBi();
        }

        private void LoadDanhSachThietBi()
        {
            using (var ctx = new DuLieu_ThietBiContext())
            {
                dgvDanhSachThietBi.DataSource = ctx.ThietBis.ToList();
            }
        }

        private void XoaRongTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void DatTrangThaiNutMacDinh()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
        }

        private bool KiemTraNhapDuLieu()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(textBox3.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out _) &&
                !decimal.TryParse(textBox3.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Đơn giá chỉ được nhập số nguyên hoặc số thực!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím điều khiển (Backspace, Delete,...)
            if (char.IsControl(e.KeyChar))
                return;

            // Cho phép chữ số
            if (char.IsDigit(e.KeyChar))
                return;

            // Cho phép dấu thập phân (chỉ 1 lần)
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if ((e.KeyChar == decimalSeparator || e.KeyChar == '.' || e.KeyChar == ',') &&
                !textBox3.Text.Contains(decimalSeparator) &&
                !textBox3.Text.Contains('.') &&
                !textBox3.Text.Contains(','))
            {
                return;
            }

            e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapDuLieu())
                return;

            string maThietBi = textBox1.Text.Trim();

            using (var ctx = new DuLieu_ThietBiContext())
            {
                bool trungMa = ctx.ThietBis.Any(tb => tb.MaThietBi == maThietBi);
                if (trungMa)
                {
                    MessageBox.Show("Mã thiết bị đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var thietBi = new ThietBi
                {
                    MaThietBi = maThietBi,
                    TenThietBi = textBox2.Text.Trim(),
                    DonGia = textBox3.Text.Trim()
                };

                ctx.ThietBis.Add(thietBi);
                ctx.SaveChanges();
            }

            LoadDanhSachThietBi();
            XoaRongTextBox();
            DatTrangThaiNutMacDinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapDuLieu())
                return;

            string maThietBi = textBox1.Text.Trim();

            using (var ctx = new DuLieu_ThietBiContext())
            {
                var thietBi = ctx.ThietBis.FirstOrDefault(tb => tb.MaThietBi == maThietBi);
                if (thietBi == null)
                {
                    MessageBox.Show("Không tìm thấy thiết bị để sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                thietBi.TenThietBi = textBox2.Text.Trim();
                thietBi.DonGia = textBox3.Text.Trim();
                ctx.SaveChanges();
            }

            LoadDanhSachThietBi();
            XoaRongTextBox();
            DatTrangThaiNutMacDinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có muốn xóa thiết bị này không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                string maThietBi = textBox1.Text.Trim();

                using (var ctx = new DuLieu_ThietBiContext())
                {
                    var thietBi = ctx.ThietBis.FirstOrDefault(tb => tb.MaThietBi == maThietBi);
                    if (thietBi != null)
                    {
                        ctx.ThietBis.Remove(thietBi);
                        ctx.SaveChanges();
                    }
                }

                LoadDanhSachThietBi();
            }

            XoaRongTextBox();
            DatTrangThaiNutMacDinh();
        }

        private void dgvDanhSachThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvDanhSachThietBi.Rows[e.RowIndex];
            textBox1.Text = row.Cells["MaThietBi"].Value?.ToString() ?? "";
            textBox2.Text = row.Cells["TenThietBi"].Value?.ToString() ?? "";
            textBox3.Text = row.Cells["DonGia"].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }
    }
}
