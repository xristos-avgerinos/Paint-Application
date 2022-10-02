using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            if((Form1.FScount!=0)||(Form1.SLcount!=0)||(Form1.Rcount!=0)||(Form1.Ecount!=0)){
                String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                String insertQuery = "Insert into shapes(StraightLines, Freestyle, Rectangle, Ellipse,DTime) values(@SLcount,@FScount,@Rcount,@Ecount,@DTime)";
                OleDbCommand command = new OleDbCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@SLcount", Form1.SLcount);
                command.Parameters.AddWithValue("@FScount", Form1.FScount);
                command.Parameters.AddWithValue("@Rcount", Form1.Rcount);
                command.Parameters.AddWithValue("@Ecount", Form1.Ecount);
                command.Parameters.AddWithValue("@DTime",DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
