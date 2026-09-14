namespace Bai17
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuCapNhat = new ToolStripMenuItem();
            mnuCapNhatLopA = new ToolStripMenuItem();
            mnuCapNhatLopB = new ToolStripMenuItem();
            mnuChuyenPtuChonSangLopA = new ToolStripMenuItem();
            mnuChuyenPtuChonSangLopB = new ToolStripMenuItem();
            mnuChuyenHetDsSangLopA = new ToolStripMenuItem();
            mnuChuyenHetDsSangLopB = new ToolStripMenuItem();
            sepCapNhat = new ToolStripSeparator();
            mnuXoaDsLopA = new ToolStripMenuItem();
            mnuXoaDsLopB = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            mnuKetThuc = new ToolStripMenuItem();
            lblTenSV = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnSang = new Button();
            btnSangTatCa = new Button();
            btnVe = new Button();
            btnVeTatCa = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(540, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuCapNhatLopA, mnuCapNhatLopB, mnuChuyenPtuChonSangLopA, mnuChuyenPtuChonSangLopB, mnuChuyenHetDsSangLopA, mnuChuyenHetDsSangLopB, sepCapNhat, mnuXoaDsLopA, mnuXoaDsLopB });
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(83, 24);
            mnuCapNhat.Text = "Cập Nhật";
            // 
            // mnuCapNhatLopA
            // 
            mnuCapNhatLopA.Font = new Font("Segoe UI", 9.5F);
            mnuCapNhatLopA.Name = "mnuCapNhatLopA";
            mnuCapNhatLopA.Size = new Size(278, 22);
            mnuCapNhatLopA.Text = "Cập Nhật Lớp A";
            mnuCapNhatLopA.Click += mnuCapNhatLopA_Click;
            // 
            // mnuCapNhatLopB
            // 
            mnuCapNhatLopB.Font = new Font("Segoe UI", 9.5F);
            mnuCapNhatLopB.Name = "mnuCapNhatLopB";
            mnuCapNhatLopB.Size = new Size(278, 22);
            mnuCapNhatLopB.Text = "Cập Nhật Lớp B";
            mnuCapNhatLopB.Click += mnuCapNhatLopB_Click;
            // 
            // mnuChuyenPtuChonSangLopA
            // 
            mnuChuyenPtuChonSangLopA.Font = new Font("Segoe UI", 9.5F);
            mnuChuyenPtuChonSangLopA.Name = "mnuChuyenPtuChonSangLopA";
            mnuChuyenPtuChonSangLopA.Size = new Size(278, 22);
            mnuChuyenPtuChonSangLopA.Text = "Chuyển phần tử chọn sang lớp A";
            mnuChuyenPtuChonSangLopA.Click += mnuChuyenPtuChonSangLopA_Click;
            // 
            // mnuChuyenPtuChonSangLopB
            // 
            mnuChuyenPtuChonSangLopB.Font = new Font("Segoe UI", 9.5F);
            mnuChuyenPtuChonSangLopB.Name = "mnuChuyenPtuChonSangLopB";
            mnuChuyenPtuChonSangLopB.Size = new Size(278, 22);
            mnuChuyenPtuChonSangLopB.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            mnuChuyenPtuChonSangLopB.Click += mnuChuyenPtuChonSangLopB_Click;
            // 
            // mnuChuyenHetDsSangLopA
            // 
            mnuChuyenHetDsSangLopA.Font = new Font("Segoe UI", 9.5F);
            mnuChuyenHetDsSangLopA.Name = "mnuChuyenHetDsSangLopA";
            mnuChuyenHetDsSangLopA.Size = new Size(278, 22);
            mnuChuyenHetDsSangLopA.Text = "Chuyển hết ds sang lớp A";
            mnuChuyenHetDsSangLopA.Click += mnuChuyenHetDsSangLopA_Click;
            // 
            // mnuChuyenHetDsSangLopB
            // 
            mnuChuyenHetDsSangLopB.Font = new Font("Segoe UI", 9.5F);
            mnuChuyenHetDsSangLopB.Name = "mnuChuyenHetDsSangLopB";
            mnuChuyenHetDsSangLopB.Size = new Size(278, 22);
            mnuChuyenHetDsSangLopB.Text = "Chuyển Hết ds Sang lớp B";
            mnuChuyenHetDsSangLopB.Click += mnuChuyenHetDsSangLopB_Click;
            // 
            // sepCapNhat
            // 
            sepCapNhat.Name = "sepCapNhat";
            sepCapNhat.Size = new Size(275, 6);
            // 
            // mnuXoaDsLopA
            // 
            mnuXoaDsLopA.Font = new Font("Segoe UI", 9.5F);
            mnuXoaDsLopA.Name = "mnuXoaDsLopA";
            mnuXoaDsLopA.Size = new Size(278, 22);
            mnuXoaDsLopA.Text = "Xóa Danh Sách Lớp A";
            mnuXoaDsLopA.Click += mnuXoaDsLopA_Click;
            // 
            // mnuXoaDsLopB
            // 
            mnuXoaDsLopB.Font = new Font("Segoe UI", 9.5F);
            mnuXoaDsLopB.Name = "mnuXoaDsLopB";
            mnuXoaDsLopB.Size = new Size(278, 22);
            mnuXoaDsLopB.Text = "Xóa Danh Sách Lớp B";
            mnuXoaDsLopB.Click += mnuXoaDsLopB_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin, mnuKetThuc });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(86, 24);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Font = new Font("Segoe UI", 9.5F);
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(134, 22);
            mnuThongTin.Text = "Thông Tin";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // mnuKetThuc
            // 
            mnuKetThuc.Font = new Font("Segoe UI", 9.5F);
            mnuKetThuc.Name = "mnuKetThuc";
            mnuKetThuc.Size = new Size(134, 22);
            mnuKetThuc.Text = "Kết Thúc";
            mnuKetThuc.Click += mnuKetThuc_Click;
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenSV.Location = new Point(35, 60);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(60, 19);
            lblTenSV.TabIndex = 12;
            lblTenSV.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(105, 57);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 25);
            txtTen.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.Location = new Point(375, 54);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(130, 30);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.Font = new Font("Segoe UI", 10F);
            lstLopA.FormattingEnabled = true;
            lstLopA.ItemHeight = 17;
            lstLopA.Location = new Point(35, 110);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(200, 208);
            lstLopA.TabIndex = 2;
            // 
            // lstLopB
            // 
            lstLopB.Font = new Font("Segoe UI", 10F);
            lstLopB.FormattingEnabled = true;
            lstLopB.ItemHeight = 17;
            lstLopB.Location = new Point(305, 110);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(200, 208);
            lstLopB.TabIndex = 7;
            // 
            // btnSang
            // 
            btnSang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSang.Location = new Point(247, 120);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(46, 30);
            btnSang.TabIndex = 3;
            btnSang.Text = ">";
            btnSang.UseVisualStyleBackColor = true;
            btnSang.Click += btnSang_Click;
            // 
            // btnSangTatCa
            // 
            btnSangTatCa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSangTatCa.Location = new Point(247, 165);
            btnSangTatCa.Name = "btnSangTatCa";
            btnSangTatCa.Size = new Size(46, 30);
            btnSangTatCa.TabIndex = 4;
            btnSangTatCa.Text = ">>";
            btnSangTatCa.UseVisualStyleBackColor = true;
            btnSangTatCa.Click += btnSangTatCa_Click;
            // 
            // btnVe
            // 
            btnVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVe.Location = new Point(247, 210);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(46, 30);
            btnVe.TabIndex = 5;
            btnVe.Text = "<";
            btnVe.UseVisualStyleBackColor = true;
            btnVe.Click += btnVe_Click;
            // 
            // btnVeTatCa
            // 
            btnVeTatCa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVeTatCa.Location = new Point(247, 255);
            btnVeTatCa.Name = "btnVeTatCa";
            btnVeTatCa.Size = new Size(46, 30);
            btnVeTatCa.TabIndex = 6;
            btnVeTatCa.Text = "<<";
            btnVeTatCa.UseVisualStyleBackColor = true;
            btnVeTatCa.Click += btnVeTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaLopA.Location = new Point(35, 340);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(140, 35);
            btnXoaLopA.TabIndex = 8;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKetThuc.Location = new Point(200, 340);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(140, 35);
            btnKetThuc.TabIndex = 9;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaLopB.Location = new Point(365, 340);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(140, 35);
            btnXoaLopB.TabIndex = 10;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.LightCyan;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 395);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(540, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Consolas", 9F);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(266, 17);
            lblStatus.Text = "11/30/2011 10:51:52 AM   Designed by Xavier";
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 417);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnVeTatCa);
            Controls.Add(btnVe);
            Controls.Add(btnSangTatCa);
            Controls.Add(btnSang);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTenSV);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 17: Thiết kế bổ sung hệ thống menu cho Bài tập số 14";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuCapNhatLopA;
        private ToolStripMenuItem mnuCapNhatLopB;
        private ToolStripMenuItem mnuChuyenPtuChonSangLopA;
        private ToolStripMenuItem mnuChuyenPtuChonSangLopB;
        private ToolStripMenuItem mnuChuyenHetDsSangLopA;
        private ToolStripMenuItem mnuChuyenHetDsSangLopB;
        private ToolStripSeparator sepCapNhat;
        private ToolStripMenuItem mnuXoaDsLopA;
        private ToolStripMenuItem mnuXoaDsLopB;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripMenuItem mnuKetThuc;
        private Label lblTenSV;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnSang;
        private Button btnSangTatCa;
        private Button btnVe;
        private Button btnVeTatCa;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timer1;
    }
}
