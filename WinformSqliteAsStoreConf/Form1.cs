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
            PersistentValue.MYSQL_URL = TxtReadMysqlUrl.Text;
            PersistentValue.MYSQL_PORT = Convert.ToInt32(TxtReadMysqlPort.Text);
            PersistentValue.MYSQL_USERNAME = TxtReadMysqlUsername.Text;
            PersistentValue.MYSQL_PASSWORD = TxtReadMysqlPassword.Text;
            PersistentValue.MYSQL_DBNAME = TxtReadMysqlDBName.Text;
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            TxtReadMysqlUrl.Text = PersistentValue.MYSQL_URL;
            TxtReadMysqlPort.Text = PersistentValue.MYSQL_PORT.ToString();
            TxtReadMysqlUsername.Text = PersistentValue.MYSQL_USERNAME;
            TxtReadMysqlPassword.Text = PersistentValue.MYSQL_PASSWORD;
            TxtReadMysqlDBName.Text = PersistentValue.MYSQL_DBNAME;
        }
    }
}
