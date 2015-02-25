using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bWatermark_Click(object sender, EventArgs e)
        {
            label.Text = "";
            if (tbWatermarkText.Text.Trim()=="")
            {
                MessageBox.Show("Enter Watermark text");
                return;
            }
            DialogResult dlgWordResult = openFileDialog.ShowDialog();
            if (dlgWordResult == DialogResult.OK)
            {
                WordWatermark.AddWatermarkInDoc(openFileDialog.FileName, tbWatermarkText.Text.Trim());
            }
            label.Text = "Work complete";
        }

        private void bProtect_Click(object sender, EventArgs e)
        {
            label.Text = "";
            if (tbProtectPassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter Password");
                return;
            }
            DialogResult dlgWordResult = openFileDialog.ShowDialog();
            if (dlgWordResult == DialogResult.OK)
            {
                ProtectWord.AddProtectionInDoc(openFileDialog.FileName, tbWatermarkText.Text.Trim());
            }
            label.Text = "Work complete";
        }
    }
}
