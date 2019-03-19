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
    public partial class BusquedaMaster : Form
    {
        public BusquedaMaster()
        {
            InitializeComponent();
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            Form ret = new Form();
            ret.Show();
            this.Close();
        }

        private void BusquedaMaster_Load(object sender, EventArgs e)
        {
            List<string> listanew;
            string conexion = "data source=HGDLAPCARRASCOJ\\SQLEXPRESS;" +
                "initial catalog=master;integrated security = true;user id=sa";
            OperacionesDB Opdb = new OperacionesDB(conexion);

            listanew = Opdb.BasesD();
            foreach(string s in listanew)
            {
                Lstb_BD.Items.Add(s);
            }
            
        }
    }
}
