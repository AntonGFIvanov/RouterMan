using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace RouterMan
{
    public partial class FormGeneral : Form
    {
        string connectionString;

        public FormGeneral()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string strSQL = $"SELECT MARSH.DET AS 'Код детали',SIZD.NDSE AS 'Название детали',MARSH.IZD AS 'Код изделия',MARSH.SB AS 'Сборочный узел',MARSH.KOLS AS 'Кол в сборке',MARSH.KOLIZD AS 'Кол в изделии',MARSH.MAR AS 'Маршрут' FROM MARSH INNER JOIN SIZD ON MARSH.DET=SIZD.IZD WHERE DET LIKE '%{textBoxDetailCode.Text}%'";

            if (tabControlGeneral.SelectedTab == tabPageKran)
            {
                connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Router\Kran\;Extended Properties=dBASE IV;User ID=Admin;Password=";
                dataGridViewKran.DataSource = DTselect(strSQL, connectionString);
            }
            else if (tabControlGeneral.SelectedTab == tabPageMaz)
            {
                connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Router\Maz\;Extended Properties=dBASE IV;User ID=Admin;Password=";
                dataGridViewMaz.DataSource = DTselect(strSQL, connectionString);
            }
            else
            {
                connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Router\Plat\;Extended Properties=dBASE IV;User ID=Admin;Password=";
                dataGridViewPlat.DataSource = DTselect(strSQL, connectionString);
            }
        }

        public static DataTable DTselect(string str, string con)
        {
             try
             {
                 OleDbConnection connection;
                 connection = new OleDbConnection(con);
                 connection.Open();
                 OleDbCommand command = new OleDbCommand(str, connection);
                 DataTable temp = new DataTable();
                 temp.Load(command.ExecuteReader());
                 connection.Close();
                 return temp;
             }
             catch (Exception)
             {
                 MessageBox.Show("База данных повреждена. Запустите обновление базы данных");
                 return null;
             }
             
        }

        private void buttonUpdateDataBase_Click(object sender, EventArgs e)
        {
            Process.Start("D:/Router/SetUp/UpdateDB.bat", "");
        }

        private void Press_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search_Click(sender, e);
        }
    }
}
