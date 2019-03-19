using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasesdeDatosSql
{
    public partial class Vista_inicial : Form
    {
        public Vista_inicial()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            string conexion = "server=HGDLAPCARRASCOJ\\SQLEXPRESS ;" +
                    " database=AdventureWorks2014 ; integrated security = true";
            OperacionesDB OPDB = new OperacionesDB(conexion);

            DGV_Resultado.AutoGenerateColumns = true;
            DGV_Resultado.DataSource = OPDB.Getinfo();//llama al metodo devuelve datatable de dataset

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            BusquedaMaster BM = new BusquedaMaster();
            BM.Show();
            this.Hide();
        }
    }
}
