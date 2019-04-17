namespace ExtensionFinder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnteredExtension = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChoosePath = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.lstIncomingFile = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(156)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.lblPercent);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEnteredExtension);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSelectedPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnChoosePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 554);
            this.panel1.TabIndex = 0;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(110, 509);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(16, 14);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "%";
            this.lblPercent.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "(enter in form of \".txt\")";
            // 
            // btnFind
            // 
            this.btnFind.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnFind.Appearance.Options.UseFont = true;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(12, 459);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(213, 34);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFind_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(213, 143);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "word: (.docx)\nexcel: (.xlsx)\npowerpoint: (.pptx)\nimage: (.jpg | .png)\nvideo: (.av" +
    "i | .mp4 | .mov)\nzip: (.zip),winrar: (.rar)\nvisual studio: (.sln)\nsqlbackup: (.b" +
    "ak)\narduino: (.ino)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Some extensions:";
            // 
            // txtEnteredExtension
            // 
            this.txtEnteredExtension.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnteredExtension.Location = new System.Drawing.Point(12, 203);
            this.txtEnteredExtension.Multiline = true;
            this.txtEnteredExtension.Name = "txtEnteredExtension";
            this.txtEnteredExtension.Size = new System.Drawing.Size(213, 23);
            this.txtEnteredExtension.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter an extension:";
            // 
            // txtSelectedPath
            // 
            this.txtSelectedPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedPath.Location = new System.Drawing.Point(12, 137);
            this.txtSelectedPath.MaxLength = 26;
            this.txtSelectedPath.Multiline = true;
            this.txtSelectedPath.Name = "txtSelectedPath";
            this.txtSelectedPath.ReadOnly = true;
            this.txtSelectedPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSelectedPath.Size = new System.Drawing.Size(213, 24);
            this.txtSelectedPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected path:";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChoosePath.Appearance.Options.UseFont = true;
            this.btnChoosePath.Image = ((System.Drawing.Image)(resources.GetObject("btnChoosePath.Image")));
            this.btnChoosePath.Location = new System.Drawing.Point(12, 56);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(213, 34);
            this.btnChoosePath.TabIndex = 1;
            this.btnChoosePath.Text = "Choose";
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose a path:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(156)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 77);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(615, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(Double Click to open)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word to search:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.skinBarSubItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Total File:";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Total File: 0";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(984, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Size = new System.Drawing.Size(984, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(984, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // lstIncomingFile
            // 
            this.lstIncomingFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIncomingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIncomingFile.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstIncomingFile.FormattingEnabled = true;
            this.lstIncomingFile.HorizontalScrollbar = true;
            this.lstIncomingFile.ItemHeight = 17;
            this.lstIncomingFile.Location = new System.Drawing.Point(240, 56);
            this.lstIncomingFile.Name = "lstIncomingFile";
            this.lstIncomingFile.Size = new System.Drawing.Size(744, 497);
            this.lstIncomingFile.Sorted = true;
            this.lstIncomingFile.TabIndex = 7;
            this.lstIncomingFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstIncomingFile_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.lstIncomingFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "Form1";
            this.Text = "Extension Finder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnteredExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedPath;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnChoosePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.ListBox lstIncomingFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label7;
    }
}

