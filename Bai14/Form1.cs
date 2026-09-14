namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị ban đầu cho các ListBox như hình mẫu
            lstLopA.Items.Add("Truong Xuan Quang");
            lstLopA.Items.Add("Vu Thi Tuyet Minh");
            lstLopB.Items.Add("Le Duy Tinh");

            // Khởi tạo timer cập nhật ngày giờ trên StatusStrip
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            CapNhatStatusStrip();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            CapNhatStatusStrip();
        }

        private void CapNhatStatusStrip()
        {
            lblStatus.Text = $"{DateTime.Now:MM/dd/yyyy hh:mm:ss tt}   Designed by Xavier";
        }

        // 4. Thiết lập cho button Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // đưa con nhảy vào ô txtTen
                txtTen.Focus();
            }
            else
            {
                // truyền dữ liệu vào list box
                string strDuLieu = txtTen.Text;
                lstLopA.Items.Add(strDuLieu);
                // xóa nội dung trong ô txtTen và đưa con nhảy vào ô này
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        // 5. Hàm thực thi chuyển dữ liệu được chọn
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

        // Sự kiện Click nút ">"
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

        // Sự kiện Click nút "<"
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

        // 6. Hàm chuyển toàn bộ dữ liệu
        private void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString()!;
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        // Sự kiện Click nút ">>"
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

        // Sự kiện Click nút "<<"
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

        // 7. Hàm xóa các phần tử đang chọn
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

        // Sự kiện Click nút "Xóa Lớp A"
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

        // Sự kiện Click nút "Xóa Lớp B"
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

        // Nút Kết thúc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        // Menu Strip Click handlers
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
