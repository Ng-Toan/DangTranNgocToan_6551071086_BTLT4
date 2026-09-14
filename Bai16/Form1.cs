namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            rtbContent.Clear();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (dlgOpenFile.FileName.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbContent.LoadFile(dlgOpenFile.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        rtbContent.LoadFile(dlgOpenFile.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            dlgSaveFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (dlgSaveFile.FileName.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbContent.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        rtbContent.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
                dlgFont.Font = rtbContent.SelectionFont;
            else
                dlgFont.Font = rtbContent.Font;

            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                if (rtbContent.SelectionLength > 0)
                    rtbContent.SelectionFont = dlgFont.Font;
                else
                    rtbContent.Font = dlgFont.Font;
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = rtbContent.SelectionColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                if (rtbContent.SelectionLength > 0)
                    rtbContent.SelectionColor = dlgColor.Color;
                else
                    rtbContent.ForeColor = dlgColor.Color;
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            rtbContent.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            rtbContent.Paste();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài 16: Xây dựng hệ thống MainMenu và ContextMenu\nDesigned by Xavier", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
