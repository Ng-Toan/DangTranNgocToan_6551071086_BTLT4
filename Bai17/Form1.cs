namespace Bai17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị ban đầu cho các ListBox
            lstLopA.Items.Add("Truong Xuan Quang");
            lstLopA.Items.Add("Vu Thi Tuyet Minh");
            lstLopB.Items.Add("Le Duy Tinh");

            // Khởi tạo timer cập nhật ngày giờ trên StatusStrip
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            CậpNhatStatusStrip();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            CậpNhatStatusStrip();
        }

        private void CậpNhatStatusStrip()
        {
            lblStatus.Text = $"{DateTime.Now:MM/dd/yyyy hh:mm:ss tt}   Designed by Xavier";
        }

        // ========================================================
        // 1. Cập nhật tên Sinh Viên vào ListBox
        // ========================================================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatVaoListBox(lstLopA);
        }

        private void CapNhatVaoListBox(ListBox lstTarget)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;
                lstTarget.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        // Menu: Cập Nhật Lớp A
        private void mnuCapNhatLopA_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        // Menu: Cập Nhật Lớp B
        private void mnuCapNhatLopB_Click(object sender, EventArgs e)
        {
            CapNhatVaoListBox(lstLopB);
        }

        // ========================================================
        // 2. Các hàm di chuyển dữ liệu
        // ========================================================
        private void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString()!;
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        private void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString()!;
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
            }
        }

        // ========================================================
        // 3. Sự kiện Click nút lệnh & Gọi lại từ Menu Items
        // ========================================================
        // Nút ">" - Chuyển phần tử chọn sang Lớp B
        private void btnSang_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        // Menu: Chuyển Phần Tử Chọn Sang Lớp B
        private void mnuChuyenPtuChonSangLopB_Click(object sender, EventArgs e)
        {
            btnSang_Click(sender, e);
        }

        // Nút "<" - Chuyển phần tử chọn sang Lớp A
        private void btnVe_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        // Menu: Chuyển phần tử chọn sang lớp A
        private void mnuChuyenPtuChonSangLopA_Click(object sender, EventArgs e)
        {
            btnVe_Click(sender, e);
        }

        // Nút ">>" - Chuyển Hết ds Sang Lớp B
        private void btnSangTatCa_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        // Menu: Chuyển Hết ds Sang lớp B
        private void mnuChuyenHetDsSangLopB_Click(object sender, EventArgs e)
        {
            btnSangTatCa_Click(sender, e);
        }

        // Nút "<<" - Chuyển hết ds sang Lớp A
        private void btnVeTatCa_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        // Menu: Chuyển hết ds sang lớp A
        private void mnuChuyenHetDsSangLopA_Click(object sender, EventArgs e)
        {
            btnVeTatCa_Click(sender, e);
        }

        // Nút "Xóa Lớp A"
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lstLopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lstLopA);
            }
            else
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
        }

        // Menu: Xóa Danh Sách Lớp A
        private void mnuXoaDsLopA_Click(object sender, EventArgs e)
        {
            btnXoaLopA_Click(sender, e);
        }

        // Nút "Xóa Lớp B"
        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lstLopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lstLopB);
            }
            else
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
        }

        // Menu: Xóa Danh Sách Lớp B
        private void mnuXoaDsLopB_Click(object sender, EventArgs e)
        {
            btnXoaLopB_Click(sender, e);
        }

        // Nút "Kết Thúc"
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu: Kết Thúc
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            btnKetThuc_Click(sender, e);
        }

        // Menu: Thông Tin
        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài 17: Thiết kế bổ sung hệ thống menu cho Bài tập số 14\n\nSinh viên thực hiện: Huỳnh Đức Đạt\nMSSV: 6551071021", "Thông Tin Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
