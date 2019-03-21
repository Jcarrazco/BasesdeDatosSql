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

        List<string> listanew;
        string conexion = "data source=HGDLAPCARRASCOJ\\SQLEXPRESS;" +
            "initial catalog=master;integrated security = true;user id=sa";

        private void Btn_return_Click(object sender, EventArgs e)
        {
            Vista_inicial ret = new Vista_inicial();
            ret.Show();
            this.Close();
        }

        private void BusquedaMaster_Load(object sender, EventArgs e)
        {
          
            OperacionesDB Opdb = new OperacionesDB(conexion);

            listanew = Opdb.BasesD();
            foreach(string s in listanew)
            {
                Lstb_BD.Items.Add(s);
            }
            
        }

        private void Lstb_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDB = Lstb_BD.SelectedItem.ToString();
            OperacionesDB Opdb = new OperacionesDB(conexion);//crea una conexion 
            //---------------------carga info a Tablas-------------------------
            listanew = Opdb.DatosBDTablas(nombreDB);//pide las tablas de la BD
            Lstb_Tables.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                Lstb_Tables.Items.Add(s);
            }
            //------------------Carga info a Views------------------------------------------
            listanew = Opdb.DatosBDViews(nombreDB);//pide las tablas de la BD
            Lstb_View.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                Lstb_View.Items.Add(s);
            }
            //------------------Carga info a Stored procedures----------------------------
            listanew = Opdb.DatosBDSP(nombreDB);//pide las tablas de la BD
            Lstb_SP.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                Lstb_SP.Items.Add(s);
            }
        }
    }
}
