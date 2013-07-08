using System.Drawing;
namespace RavSoft.GoogleTranslator
{
    partial class TranslatorJoomla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorJoomla));
            this.gvEn = new System.Windows.Forms.DataGridView();
            this.chkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPathVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenFileEn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTenFileVi = new System.Windows.Forms.DataGridViewLinkColumn();
            this.bChonVI = new System.Windows.Forms.Button();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.opDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtEnLink = new System.Windows.Forms.TextBox();
            this.txtViLink = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.bChonEn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvEn
            // 
            this.gvEn.AllowUserToAddRows = false;
            this.gvEn.AllowUserToDeleteRows = false;
            this.gvEn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChon,
            this.colPath,
            this.colPathVi,
            this.colTenFileEn,
            this.colTenFileVi});
            this.gvEn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEn.Location = new System.Drawing.Point(0, 0);
            this.gvEn.MultiSelect = false;
            this.gvEn.Name = "gvEn";
            this.gvEn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEn.Size = new System.Drawing.Size(866, 465);
            this.gvEn.TabIndex = 8;
            this.gvEn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEn_CellDoubleClick);
            this.gvEn.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvEn_DataBindingComplete);
            // 
            // chkChon
            // 
            this.chkChon.DataPropertyName = "Chon";
            this.chkChon.HeaderText = "";
            this.chkChon.Name = "chkChon";
            this.chkChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkChon.Width = 50;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "PathEn";
            this.colPath.HeaderText = "PathEn";
            this.colPath.Name = "colPath";
            this.colPath.Visible = false;
            // 
            // colPathVi
            // 
            this.colPathVi.DataPropertyName = "PathVi";
            this.colPathVi.HeaderText = "Path Vi";
            this.colPathVi.Name = "colPathVi";
            this.colPathVi.Visible = false;
            // 
            // colTenFileEn
            // 
            this.colTenFileEn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenFileEn.DataPropertyName = "TenFileEn";
            this.colTenFileEn.HeaderText = "Tên file En";
            this.colTenFileEn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colTenFileEn.LinkColor = System.Drawing.Color.Black;
            this.colTenFileEn.Name = "colTenFileEn";
            this.colTenFileEn.ReadOnly = true;
            this.colTenFileEn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenFileEn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenFileEn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // colTenFileVi
            // 
            this.colTenFileVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenFileVi.DataPropertyName = "TenFileVi";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.colTenFileVi.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTenFileVi.HeaderText = "Tên file Vi";
            this.colTenFileVi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colTenFileVi.LinkColor = System.Drawing.Color.Black;
            this.colTenFileVi.Name = "colTenFileVi";
            this.colTenFileVi.ReadOnly = true;
            this.colTenFileVi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenFileVi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenFileVi.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // bChonVI
            // 
            this.bChonVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChonVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChonVI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bChonVI.Location = new System.Drawing.Point(655, 32);
            this.bChonVI.Name = "bChonVI";
            this.bChonVI.Size = new System.Drawing.Size(111, 23);
            this.bChonVI.TabIndex = 9;
            this.bChonVI.Text = "Target language";
            this.bChonVI.UseVisualStyleBackColor = true;
            this.bChonVI.Click += new System.EventHandler(this.bChonVI_Click);
            // 
            // opDialog
            // 
            this.opDialog.FileName = "opDialog";
            // 
            // txtEnLink
            // 
            this.txtEnLink.Location = new System.Drawing.Point(5, 6);
            this.txtEnLink.Name = "txtEnLink";
            this.txtEnLink.Size = new System.Drawing.Size(644, 20);
            this.txtEnLink.TabIndex = 10;
            // 
            // txtViLink
            // 
            this.txtViLink.Location = new System.Drawing.Point(5, 32);
            this.txtViLink.Name = "txtViLink";
            this.txtViLink.Size = new System.Drawing.Size(644, 20);
            this.txtViLink.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtViLink);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Controls.Add(this.bChonVI);
            this.panel1.Controls.Add(this.bChonEn);
            this.panel1.Controls.Add(this.txtEnLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 63);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvEn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 465);
            this.panel2.TabIndex = 13;
            // 
            // bStart
            // 
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bStart.Location = new System.Drawing.Point(772, 3);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(91, 56);
            this.bStart.TabIndex = 11;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bChonEn
            // 
            this.bChonEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChonEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChonEn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bChonEn.Location = new System.Drawing.Point(655, 3);
            this.bChonEn.Name = "bChonEn";
            this.bChonEn.Size = new System.Drawing.Size(111, 23);
            this.bChonEn.TabIndex = 9;
            this.bChonEn.Text = "Choose English";
            this.bChonEn.UseVisualStyleBackColor = true;
            this.bChonEn.Click += new System.EventHandler(this.bChonEn_Click);
            // 
            // TranslatorJoomla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorJoomla";
            this.Text = "Translator Joomla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TranslatorJoomla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEn;
        private System.Windows.Forms.Button bChonVI;
        private System.Windows.Forms.Button bChonEn;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.OpenFileDialog opDialog;
        private System.Windows.Forms.TextBox txtEnLink;
        private System.Windows.Forms.TextBox txtViLink;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPathVi;
        private System.Windows.Forms.DataGridViewLinkColumn colTenFileEn;
        private System.Windows.Forms.DataGridViewLinkColumn colTenFileVi;
    }
}