namespace Bai18
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            sepFile = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuFont = new ToolStripMenuItem();
            mnuColor = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuTileHorizontally = new ToolStripMenuItem();
            mnuTileVertically = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            sepWindow = new ToolStripSeparator();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbNew = new ToolStripButton();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbCascade = new ToolStripButton();
            tsbTileH = new ToolStripButton();
            tsbTileV = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuFormat, mnuWindow, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuWindow;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(163, 22);
            mnuNew.Text = "&New";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(163, 22);
            mnuOpen.Text = "&Open...";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.Size = new Size(163, 22);
            mnuSaveAs.Text = "&Save As...";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // sepFile
            // 
            sepFile.Name = "sepFile";
            sepFile.Size = new Size(160, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(163, 22);
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
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuTileHorizontally, mnuTileVertically, mnuCascade, sepWindow });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(63, 20);
            mnuWindow.Text = "&Window";
            // 
            // mnuTileHorizontally
            // 
            mnuTileHorizontally.Name = "mnuTileHorizontally";
            mnuTileHorizontally.Size = new Size(160, 22);
            mnuTileHorizontally.Text = "Tile &Horizontally";
            mnuTileHorizontally.Click += mnuTileHorizontally_Click;
            // 
            // mnuTileVertically
            // 
            mnuTileVertically.Name = "mnuTileVertically";
            mnuTileVertically.Size = new Size(160, 22);
            mnuTileVertically.Text = "Tile &Vertically";
            mnuTileVertically.Click += mnuTileVertically_Click;
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(160, 22);
            mnuCascade.Text = "&Cascade";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // sepWindow
            // 
            sepWindow.Name = "sepWindow";
            sepWindow.Size = new Size(157, 6);
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNew, tsbOpen, tsbSave, toolStripSeparator1, tsbCascade, tsbTileH, tsbTileV });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            tsbNew.ImageTransparentColor = Color.Magenta;
            tsbNew.Name = "tsbNew";
            tsbNew.Size = new Size(91, 22);
            tsbNew.Text = "New Document";
            tsbNew.Click += tsbNew_Click;
            // 
            // tsbOpen
            // 
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(96, 22);
            tsbOpen.Text = "Open Document";
            tsbOpen.Click += tsbOpen_Click;
            // 
            // tsbSave
            // 
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(91, 22);
            tsbSave.Text = "Save Document";
            tsbSave.Click += tsbSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbCascade
            // 
            tsbCascade.ImageTransparentColor = Color.Magenta;
            tsbCascade.Name = "tsbCascade";
            tsbCascade.Size = new Size(56, 22);
            tsbCascade.Text = "Cascade";
            tsbCascade.Click += tsbCascade_Click;
            // 
            // tsbTileH
            // 
            tsbTileH.ImageTransparentColor = Color.Magenta;
            tsbTileH.Name = "tsbTileH";
            tsbTileH.Size = new Size(94, 22);
            tsbTileH.Text = "Tile Horizontally";
            tsbTileH.Click += tsbTileH_Click;
            // 
            // tsbTileV
            // 
            tsbTileV.ImageTransparentColor = Color.Magenta;
            tsbTileV.Name = "tsbTileV";
            tsbTileV.Size = new Size(79, 22);
            tsbTileV.Text = "Tile Vertically";
            tsbTileV.Click += tsbTileV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_22 - Creating an MDI Application";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripSeparator sepFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuFormat;
        private ToolStripMenuItem mnuFont;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuTileHorizontally;
        private ToolStripMenuItem mnuTileVertically;
        private ToolStripMenuItem mnuCascade;
        private ToolStripSeparator sepWindow;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNew;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbCascade;
        private ToolStripButton tsbTileH;
        private ToolStripButton tsbTileV;
    }
}
