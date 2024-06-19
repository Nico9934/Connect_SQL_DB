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

namespace Connect_SQL_DB
{
	public partial class Frm_principal : Form
	{
		public Frm_principal()
		{
			InitializeComponent();
		}

		private void btn_connect_Click(object sender, EventArgs e)
		{
			Declaraciones.connectionString = @"Data Source=localhost;Initial Catalog=abm_db;Trusted_Connection=True;";
			Declaraciones.cnn = new SqlConnection(Declaraciones.connectionString);
			Declaraciones.cnn.Open();
			MessageBox.Show("Connection Open!");
	
		}

		private void btn_disconnect_Click(object sender, EventArgs e)
		{
			Declaraciones.cnn.Close();
			MessageBox.Show("Connection Close!");
		}

		private void btn_load_data_Click(object sender, EventArgs e)
		{
		
			DataTable tabla = new DataTable();
			string consulta = "SELECT firstName as Nombre from Person";
			SqlCommand comando = new SqlCommand(consulta, Declaraciones.cnn);
			SqlDataReader reader = comando.ExecuteReader();
			tabla.Load(reader);
			dgv_data.DataSource = tabla;
		}
	}
}
