using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Prvado.CAPAPRESENTACION
{
    public partial class ConsultarAreas : Form
    {
        public ConsultarAreas()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Melvin\\SQLEXPRESS;Initial Catalog=umge;Integrated Security=True");

        private void ConsultarAreas_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from Areas";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Areas menu = new Areas();
            menu.Show();
            this.Hide();
        }
    }
}
