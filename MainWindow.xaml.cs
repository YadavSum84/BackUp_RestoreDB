using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackUp_RestoreDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection con;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connectionString = "Data Source = " + txtDataSource.Text + "; User Id= " + txtUserName.Text + "; Password=" + txtPassword.ToString() + "";
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "EXEC sp_databases";
                //sql = "Select sys.databases d where d.database_id>4";
                command = new SqlCommand(sql, con);
                reader = command.ExecuteReader();
                cmdDatabases.Items.Clear();
                while (reader.Read())
                {
                    cmdDatabases.Items.Add(reader[0].ToString());
                }
                txtDataSource.IsEnabled = false;
                txtUserName.IsEnabled = false;
                txtPassword.IsEnabled = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BackUp_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnRestoreBrowse_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnRestore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
