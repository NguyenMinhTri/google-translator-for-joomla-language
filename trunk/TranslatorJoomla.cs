using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RavSoft.GoogleTranslator
{
    public partial class TranslatorJoomla : Form
    {
        public TranslatorJoomla()
        {
            InitializeComponent();
        }

        private void TranslatorJoomla_Load(object sender, EventArgs e)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\GoogleTranslator"))
            {
                txtEnLink.Text = (string)registryKey.GetValue("TenFileEn", String.Empty);
                txtViLink.Text = (string)registryKey.GetValue("TenFileVi", String.Empty);
            }
            if (txtEnLink.Text != string.Empty && txtViLink.Text != string.Empty)
            {
                AddData(txtEnLink.Text, txtViLink.Text);
            }
        }
        private void bChonEn_Click(object sender, EventArgs e)
        {
            fbDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = fbDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //AddData();
                txtEnLink.Text = fbDialog.SelectedPath;
                using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\GoogleTranslator"))
                {
                    registryKey.SetValue("TenFileEn", fbDialog.SelectedPath, RegistryValueKind.String);
                }
            }
        }

       

        private void bChonVI_Click(object sender, EventArgs e)
        {
            fbDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = fbDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //AddData();
                txtViLink.Text = fbDialog.SelectedPath;
                using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\GoogleTranslator"))
                {
                    registryKey.SetValue("TenFileVi", fbDialog.SelectedPath, RegistryValueKind.String);
                }
            }
        }

        List<SimpleDataFile> data;
        private void AddData(string sPathEn, string sPathVi)
        {
            string[] filePathEn = Directory.GetFiles(sPathEn, "*.ini");
            string[] filePathVi = Directory.GetFiles(sPathVi, "*.ini");
            var bindingSource = new BindingSource();
            data = new List<SimpleDataFile>();
            for (int i = 0; i < filePathEn.Length; i++)
            {
                string[] aPathVi = filePathVi.Where(w => (Path.GetFileName(w).Remove(0, 6) == Path.GetFileName(filePathEn[i]).Remove(0, 6))).ToArray();
                string pathvi = "";
                string Tenfilevi = "";
                if (aPathVi.Length > 0)
                {
                    pathvi = aPathVi[0];
                    Tenfilevi = Path.GetFileName(aPathVi[0]);
                }
                bindingSource.Add(new SimpleDataFile { Chon = false, TenFileEn = Path.GetFileName(filePathEn[i]), TenFileVi = Tenfilevi, PathEn = filePathEn[i], PathVi = pathvi });
                data.Add(new SimpleDataFile { Chon = false, TenFileEn = Path.GetFileName(filePathEn[i]), TenFileVi = Tenfilevi, PathEn = filePathEn[i], PathVi = pathvi });
            }
            gvEn.DataSource = bindingSource;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            AddData(txtEnLink.Text, txtViLink.Text);
        }

        private void gvEn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gvEn.Rows)
            {
                string RowType = row.Cells[2].Value.ToString();
                if (RowType == "")
                {
                    row.Cells[1].Style.BackColor = Color.Coral;
                    row.Cells[2].Style.BackColor = Color.Coral;
                }
            }
        }

        private void gvEn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SimpleDataFile temp = data[e.RowIndex];
            TranslatorOne obj = new TranslatorOne();
            obj.DataTranslator = temp;
            obj.ShowDialog();
        }

       
    }
}
