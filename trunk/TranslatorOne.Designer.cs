namespace RavSoft.GoogleTranslator
{
    partial class TranslatorOne
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
            this.gvData = new System.Windows.Forms.DataGridView();
            this.ChkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this._lblStatus = new System.Windows.Forms.Label();
            this.chkFull = new System.Windows.Forms.CheckBox();
            this.chkIsEmpty = new System.Windows.Forms.CheckBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSaveToFile = new System.Windows.Forms.Button();
            this.bTranslate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvData
            // 
            this.gvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkChon,
            this.txtKhoa,
            this.txtEn,
            this.txtVi});
            this.gvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvData.Location = new System.Drawing.Point(0, 0);
            this.gvData.Name = "gvData";
            this.gvData.Size = new System.Drawing.Size(893, 442);
            this.gvData.TabIndex = 0;
            this.gvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvData_DataBindingComplete);
            // 
            // ChkChon
            // 
            this.ChkChon.DataPropertyName = "Chon";
            this.ChkChon.HeaderText = "Chọn";
            this.ChkChon.Name = "ChkChon";
            this.ChkChon.Visible = false;
            this.ChkChon.Width = 50;
            // 
            // txtKhoa
            // 
            this.txtKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtKhoa.DataPropertyName = "KhoaChinh";
            this.txtKhoa.HeaderText = "Keys";
            this.txtKhoa.Name = "txtKhoa";
            // 
            // txtEn
            // 
            this.txtEn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEn.DataPropertyName = "En";
            this.txtEn.HeaderText = "English";
            this.txtEn.Name = "txtEn";
            // 
            // txtVi
            // 
            this.txtVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtVi.DataPropertyName = "Vi";
            this.txtVi.HeaderText = "Target Language";
            this.txtVi.Name = "txtVi";
            // 
            // opDialog
            // 
            this.opDialog.FileName = "opDialog";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this._lblStatus);
            this.panel2.Controls.Add(this.chkFull);
            this.panel2.Controls.Add(this.chkIsEmpty);
            this.panel2.Controls.Add(this._comboTo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._comboFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bSaveToFile);
            this.panel2.Controls.Add(this.bTranslate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 89);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 28);
            this.panel3.TabIndex = 11;
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBar.Location = new System.Drawing.Point(0, 0);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(893, 28);
            this.pBar.TabIndex = 10;
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(197, 43);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(42, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "asadad";
            // 
            // chkFull
            // 
            this.chkFull.AutoSize = true;
            this.chkFull.Location = new System.Drawing.Point(712, 35);
            this.chkFull.Name = "chkFull";
            this.chkFull.Size = new System.Drawing.Size(113, 17);
            this.chkFull.TabIndex = 8;
            this.chkFull.Text = "Translate full fields";
            this.chkFull.UseVisualStyleBackColor = true;
            // 
            // chkIsEmpty
            // 
            this.chkIsEmpty.AutoSize = true;
            this.chkIsEmpty.Checked = true;
            this.chkIsEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsEmpty.Location = new System.Drawing.Point(712, 12);
            this.chkIsEmpty.Name = "chkIsEmpty";
            this.chkIsEmpty.Size = new System.Drawing.Size(150, 17);
            this.chkIsEmpty.TabIndex = 8;
            this.chkIsEmpty.Text = "Translate only empty fields";
            this.chkIsEmpty.UseVisualStyleBackColor = true;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(550, 17);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(156, 21);
            this._comboTo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Target language:";
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(294, 17);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(156, 21);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source language:";
            // 
            // bSaveToFile
            // 
            this.bSaveToFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bSaveToFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaveToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSaveToFile.Location = new System.Drawing.Point(100, 3);
            this.bSaveToFile.Name = "bSaveToFile";
            this.bSaveToFile.Size = new System.Drawing.Size(91, 53);
            this.bSaveToFile.TabIndex = 0;
            this.bSaveToFile.Text = "Save a File";
            this.bSaveToFile.UseVisualStyleBackColor = true;
            this.bSaveToFile.Click += new System.EventHandler(this.bSaveToFile_Click);
            // 
            // bTranslate
            // 
            this.bTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTranslate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bTranslate.Location = new System.Drawing.Point(3, 3);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(91, 53);
            this.bTranslate.TabIndex = 0;
            this.bTranslate.Text = "Translate ";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 442);
            this.panel1.TabIndex = 2;
            // 
            // TranslatorOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TranslatorOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TranslatorOne";
            this.Load += new System.EventHandler(this.TranslatorOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.OpenFileDialog opDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVi;
        private System.Windows.Forms.CheckBox chkIsEmpty;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.Button bSaveToFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.CheckBox chkFull;
    }
}