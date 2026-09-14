namespace Bai18
{
    public partial class Form1 : Form
    {
        private int docCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tự động tạo 1 child document mẫu khi khởi chạy như hình ảnh giáo trình
            CreateNewChild();
        }

        private void CreateNewChild()
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            docCount++;
            child.Text = "New Document " + docCount;
            child.Show();
        }

        private void OpenChildFile()
        {
            using OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ChildForm child = new ChildForm();
                child.MdiParent = this;
                child.Text = dlg.FileName;
                child.LoadFile(dlg.FileName);
                child.Show();
            }
        }

        private void SaveActiveChildFile()
        {
            if (this.ActiveMdiChild is ChildForm activeChild)
            {
                using SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    activeChild.SaveFile(dlg.FileName);
                    activeChild.Text = dlg.FileName;
                }
            }
            else
            {
                MessageBox.Show("Không có cửa sổ nào đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            CreateNewChild();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenChildFile();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveActiveChildFile();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is ChildForm activeChild)
            {
                using FontDialog dlg = new FontDialog();
                if (activeChild.Editor.SelectionFont != null)
                    dlg.Font = activeChild.Editor.SelectionFont;
                else
                    dlg.Font = activeChild.Editor.Font;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (activeChild.Editor.SelectionLength > 0)
                        activeChild.Editor.SelectionFont = dlg.Font;
                    else
                        activeChild.Editor.Font = dlg.Font;
                }
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is ChildForm activeChild)
            {
                using ColorDialog dlg = new ColorDialog();
                dlg.Color = activeChild.Editor.SelectionColor;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (activeChild.Editor.SelectionLength > 0)
                        activeChild.Editor.SelectionColor = dlg.Color;
                    else
                        activeChild.Editor.ForeColor = dlg.Color;
                }
            }
        }

        private void mnuTileHorizontally_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertically_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài 18: Creating an MDI Application (StepByStep2_22)\n\nSinh viên thực hiện: Huỳnh Đức Đạt\nMSSV: 6551071021", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ToolStrip Event Handlers
        private void tsbNew_Click(object sender, EventArgs e)
        {
            CreateNewChild();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenChildFile();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveActiveChildFile();
        }

        private void tsbCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsbTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsbTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
