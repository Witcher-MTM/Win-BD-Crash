using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        IDbConnection conn = new SqlConnection("Data Source=SQL5105.site4now.net;Initial Catalog=db_a7d3c0_opendi;User Id=db_a7d3c0_opendi_admin;Password=qwerty20039");
        List<string> notes = new List<string>();
        public Form1()
        {
            InitializeComponent();

            var connection = new SqlConnection("Data Source=SQL5105.site4now.net;Initial Catalog=db_a7d3c0_opendi;User Id=db_a7d3c0_opendi_admin;Password=qwerty20039");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToList().All(x => Char.IsDigit(x)))
            {
                MessageBox.Show("Num");
            }
            if (this.textBox1.Text != string.Empty)
            {
                string sql = "INSERT INTO [User] VALUES (@Name);";
                try
                {
                    var affectedRows = conn.Execute(sql, new { Name = textBox1.Text });

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
