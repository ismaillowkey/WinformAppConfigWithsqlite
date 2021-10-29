using System;
using System.Windows.Forms;

namespace WinformSqliteAsStoreConf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWriteKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtWriteSection.Text) || string.IsNullOrEmpty(TxtWriteKey.Text) || string.IsNullOrEmpty(TxtWriteValue.Text))
                MessageBox.Show("Error blank setting", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ConfParser.WriteKey(TxtWriteSection.Text, TxtWriteKey.Text, TxtWriteValue.Text);
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtReadSection.Text) || string.IsNullOrEmpty(TxtReadKey.Text))
                MessageBox.Show("Error blank setting", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                TxtReadValue.Text = ConfParser.ReadKey(TxtReadSection.Text, TxtReadKey.Text);
        }
    }
}
