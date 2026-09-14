namespace Bai16
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
            mnuMainMenu = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            sepFile = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuFont = new ToolStripMenuItem();
            mnuColor = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            mnuContext = new ContextMenuStrip(components);
            ctxCut = new ToolStripMenuItem();
            ctxCopy = new ToolStripMenuItem();
            ctxPaste = new ToolStripMenuItem();
            ctxSep = new ToolStripSeparator();
            ctxFont = new ToolStripMenuItem();
            ctxColor = new ToolStripMenuItem();
            rtbContent = new RichTextBox();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            mnuMainMenu.SuspendLayout();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { mnuFile, mnuFormat, mnuHelp });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(584, 24);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSaveAs, sepFile, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new Size(123, 22);
            mnuNew.Text = "&New";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(123, 22);
            mnuOpen.Text = "&Open...";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.Size = new Size(123, 22);
            mnuSaveAs.Text = "&Save As...";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // sepFile
            // 
            sepFile.Name = "sepFile";
            sepFile.Size = new Size(120, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(123, 22);
            mnuExit.Text = "E&xit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuFormat
            // 
            mnuFormat.DropDownItems.AddRange(new ToolStripItem[] { mnuFont, mnuColor });
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(57, 20);
            mnuFormat.Text = "F&ormat";
            // 
            // mnuFont
            // 
            mnuFont.Name = "mnuFont";
            mnuFont.Size = new Size(112, 22);
            mnuFont.Text = "&Font...";
            mnuFont.Click += mnuFont_Click;
            // 
            // mnuColor
            // 
            mnuColor.Name = "mnuColor";
            mnuColor.Size = new Size(112, 22);
            mnuColor.Text = "&Color...";
            mnuColor.Click += mnuColor_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(107, 22);
            mnuAbout.Text = "&About";
            mnuAbout.Click += mnuAbout_Click;
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
            ctxCut.Click += mnuCut_Click;
            // 
            // ctxCopy
            // 
            ctxCopy.Name = "ctxCopy";
            ctxCopy.Size = new Size(108, 22);
            ctxCopy.Text = "&Copy";
            ctxCopy.Click += mnuCopy_Click;
            // 
            // ctxPaste
            // 
            ctxPaste.Name = "ctxPaste";
            ctxPaste.Size = new Size(108, 22);
            ctxPaste.Text = "&Paste";
            ctxPaste.Click += mnuPaste_Click;
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
            ctxFont.Click += mnuFont_Click;
            // 
            // ctxColor
            // 
            ctxColor.Name = "ctxColor";
            ctxColor.Size = new Size(108, 22);
            ctxColor.Text = "Color...";
            ctxColor.Click += mnuColor_Click;
            // 
            // rtbContent
            // 
            rtbContent.ContextMenuStrip = mnuContext;
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Consolas", 11F);
            rtbContent.Location = new Point(0, 24);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(584, 417);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 441);
            Controls.Add(rtbContent);
            Controls.Add(mnuMainMenu);
            MainMenuStrip = mnuMainMenu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_18 / StepByStep2_19 - MainMenu & ContextMenu";
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMainMenu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripSeparator sepFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuFormat;
        private ToolStripMenuItem mnuFont;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem ctxCut;
        private ToolStripMenuItem ctxCopy;
        private ToolStripMenuItem ctxPaste;
        private ToolStripSeparator ctxSep;
        private ToolStripMenuItem ctxFont;
        private ToolStripMenuItem ctxColor;
        private RichTextBox rtbContent;
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
    }
}
