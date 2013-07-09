using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RavSoft.GoogleTranslator
{
    public partial class TranslatorOne : Form
    {
        public TranslatorOne()
        {
            InitializeComponent();
        }
        private string[] enDataFirst;
        private string[] viDataFirst;
        public SimpleDataFile DataTranslator{ get; set; }
        List<SimpleData> Tran;
        private void LoadTranslate()
        {
            int j = 0;
            var enData = enDataFirst.Where(w => !w.StartsWith(";") && w != "").ToArray();
            var viData = viDataFirst.Where(w => !w.StartsWith(";") && w != "").ToArray();
            var bindingSource = new BindingSource();
            Tran = new List<SimpleData>();
            for (int i = 0; i < enData.Length; i++)
            {
                string khoachinh = "";
                string en = "";
                string vi = "";
                string[] tenpEn = enData[i].Split('=');
                if (tenpEn.Length > 1)
                {
                    khoachinh = tenpEn[0];
                    en = enData[i].Remove(0, tenpEn[0].Length + 1).Trim('"');
                }
                string[] iVi = viData.Where(w => w.StartsWith(khoachinh + "=")).ToArray();
                if (iVi.Length > 0)
                {
                    string[] tenpvi = iVi[0].Split('=');
                    if (tenpvi.Length > 1)
                    {
                        if (khoachinh == tenpvi[0])
                        {
                            vi = iVi[0].Remove(0, tenpvi[0].Length + 1).Trim('"');
                            j++;
                        }
                    }
                }

                bindingSource.Add(new SimpleData { Chon = false, KhoaChinh = khoachinh, En = en, Vi = vi });
                Tran.Add(new SimpleData { Chon = false, KhoaChinh = khoachinh, En = en, Vi = vi });
            }
            gvData.DataSource = bindingSource;
        }

        private void TranslatorOne_Load(object sender, EventArgs e)
        {

            this._comboFrom.Items.AddRange(Translator.Languages.ToArray());
            this._comboTo.Items.AddRange(Translator.Languages.ToArray());
            this._comboFrom.SelectedItem = "English";
            this._comboTo.SelectedItem = "Vietnamese";
            try
            {
                enDataFirst = System.IO.File.ReadAllLines(DataTranslator.PathEn);
                if (DataTranslator.PathVi != string.Empty)
                {
                    viDataFirst = System.IO.File.ReadAllLines(DataTranslator.PathVi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTranslate();
            _lblStatus.Text = string.Empty;
        }

        private void gvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gvData.Rows)
            {
                string RowType = row.Cells[3].Value.ToString();
                if (RowType == "")
                {
                    row.Cells[1].Style.BackColor = Color.Coral;
                    row.Cells[2].Style.BackColor = Color.Coral;
                    row.Cells[3].Style.BackColor = Color.Coral;
                }
            }
        }

        private void bTranslate_Click(object sender, EventArgs e)
        {
            Translator t = new Translator();
            var bindingSource = new BindingSource();
            pBar.Maximum = Tran.Count;
            pBar.Value = 1;
            pBar.Step = 1;
            for (int i = 0; i < Tran.Count; i++)
            {
                SimpleData temp = Tran[i];
                if (chkIsEmpty.Checked && temp.Vi == string.Empty)
                {
                    temp = TranslateLang(t, temp);
                }
                else if(chkFull.Checked)
                {
                    temp = TranslateLang(t, temp);
                }
                bindingSource.Add(temp);
                pBar.PerformStep();
                pBar.Update();
            }
            gvData.DataSource = bindingSource;
            gvData.Update();
        }

        private SimpleData TranslateLang(Translator t, SimpleData temp)
        {
            t.SourceLanguage = (string)this._comboFrom.SelectedItem;
            t.TargetLanguage = (string)this._comboTo.SelectedItem;
            t.SourceText = temp.En;
            try
            {
                // Forward translation
                this.Cursor = Cursors.WaitCursor;
                this._lblStatus.Text = "Being translation..." + temp.KhoaChinh + "...Key";
                this._lblStatus.Update();
                t.Translate();
                temp.Vi = t.Translation;

                this._lblStatus.Text = "Translate completed..." + temp.KhoaChinh + "...Key";
                this._lblStatus.Update();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this._lblStatus.Text = string.Empty;
                this.Cursor = Cursors.Default;
            }
            return temp;
        }

        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đang trong quá trình xử lý mong các bạn thông cảm","Thông báo");
            try
            {
                var viData = viDataFirst.Where(w => w.StartsWith(";")).ToArray();
                int iCount = Tran.Count + viData.Length;
                string[] temp = new string[iCount];
                for (int i = 0; i < viData.Length; i++)
                {
                    temp[i] = viData[i];
                }
                int j = 0;
                for (int i = viData.Length; i < temp.Length; i++)
                {
                    SimpleData tranTemp = Tran[j];
                    temp[i] = tranTemp.KhoaChinh + "=\"" + tranTemp.Vi + "\"";
                    j++;
                }
                System.IO.File.WriteAllLines(DataTranslator.TenFileVi, temp);
                MessageBox.Show("Save completed a file in app path");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
