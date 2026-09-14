namespace Bai18
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        public RichTextBox Editor => rtbContent;

        public void LoadFile(string path)
        {
            try
            {
                if (path.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    rtbContent.LoadFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtbContent.LoadFile(path, RichTextBoxStreamType.PlainText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveFile(string path)
        {
            try
            {
                if (path.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    rtbContent.SaveFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtbContent.SaveFile(path, RichTextBoxStreamType.PlainText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxCut_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }

        private void ctxCopy_Click(object sender, EventArgs e)
        {
            rtbContent.Copy();
        }

        private void ctxPaste_Click(object sender, EventArgs e)
        {
            rtbContent.Paste();
        }

        private void ctxFont_Click(object sender, EventArgs e)
        {
            using FontDialog dlg = new FontDialog();
            if (rtbContent.SelectionFont != null)
                dlg.Font = rtbContent.SelectionFont;
            else
                dlg.Font = rtbContent.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (rtbContent.SelectionLength > 0)
                    rtbContent.SelectionFont = dlg.Font;
                else
                    rtbContent.Font = dlg.Font;
            }
        }

        private void ctxColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            dlg.Color = rtbContent.SelectionColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (rtbContent.SelectionLength > 0)
                    rtbContent.SelectionColor = dlg.Color;
                else
                    rtbContent.ForeColor = dlg.Color;
            }
        }
    }
}
