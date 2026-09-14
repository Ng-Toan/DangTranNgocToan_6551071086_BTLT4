namespace Bai18
{
    partial class ChildForm
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
            components = new System.ComponentModel.Container();
            rtbContent = new RichTextBox();
            mnuContext = new ContextMenuStrip(components);
            ctxCut = new ToolStripMenuItem();
            ctxCopy = new ToolStripMenuItem();
            ctxPaste = new ToolStripMenuItem();
            ctxSep = new ToolStripSeparator();
            ctxFont = new ToolStripMenuItem();
            ctxColor = new ToolStripMenuItem();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.ContextMenuStrip = mnuContext;
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Consolas", 10.5F);
            rtbContent.Location = new Point(0, 0);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(484, 361);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "";
            // 
            // mnuContext
            // 
            mnuContext.Items.AddRange(new ToolStripItem[] { ctxCut, ctxCopy, ctxPaste, ctxSep, ctxFont, ctxColor });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(109, 120);
            // 
            // ctxCut
            // 
            ctxCut.Name = "ctxCut";
            ctxCut.Size = new Size(108, 22);
            ctxCut.Text = "Cu&t";
            ctxCut.Click += ctxCut_Click;
            // 
            // ctxCopy
            // 
            ctxCopy.Name = "ctxCopy";
            ctxCopy.Size = new Size(108, 22);
            ctxCopy.Text = "&Copy";
            ctxCopy.Click += ctxCopy_Click;
            // 
            // ctxPaste
            // 
            ctxPaste.Name = "ctxPaste";
            ctxPaste.Size = new Size(108, 22);
            ctxPaste.Text = "&Paste";
            ctxPaste.Click += ctxPaste_Click;
            // 
            // ctxSep
            // 
            ctxSep.Name = "ctxSep";
            ctxSep.Size = new Size(105, 6);
            // 
            // ctxFont
            // 
            ctxFont.Name = "ctxFont";
            ctxFont.Size = new Size(108, 22);
            ctxFont.Text = "Font...";
            ctxFont.Click += ctxFont_Click;
            // 
            // ctxColor
            // 
            ctxColor.Name = "ctxColor";
            ctxColor.Size = new Size(108, 22);
            ctxColor.Text = "Color...";
            ctxColor.Click += ctxColor_Click;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(rtbContent);
            Name = "ChildForm";
            Text = "New Document";
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContent;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem ctxCut;
        private ToolStripMenuItem ctxCopy;
        private ToolStripMenuItem ctxPaste;
        private ToolStripSeparator ctxSep;
        private ToolStripMenuItem ctxFont;
        private ToolStripMenuItem ctxColor;
    }
}
