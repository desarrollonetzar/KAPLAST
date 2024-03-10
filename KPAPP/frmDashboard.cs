using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocios;
using System.Data.SqlClient;


namespace KPAPP
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        public static int nrofabricacion;


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            GrafConsumos();
            GrafTareas();
            GrafDias();
        }


        private void GrafConsumos()
        {
            DataTable dt = new DataTable();
            dt = NDashboard.consumo(Convert.ToInt32(txtnrofabricacion.Text));
            //DgvProceso.CurrentRow.Cells[12].Value != System.DBNull.Value
            txtConsumo1.Text = Convert.ToString(dt.Rows[0][0] is DBNull ? 0 : dt.Rows[0][0]);

            chartConsumo.Series["Consumos"].Points.AddXY("RESINA (Kgs)", Convert.ToInt32(txtConsumo1.Text));
            //chartConsumo.Series["Consumos"].Points.AddXY("Consumo 2", NDashboard.consumodos());

            DataTable dt2 = new DataTable();
            dt2 = NDashboard.consumodos(Convert.ToInt32(txtnrofabricacion.Text));
            txtconsumo2.Text = Convert.ToString(dt2.Rows[0][0] is DBNull ? 0 : dt2.Rows[0][0]);

            //if ((dt.Rows[0][0]) == System.DBNull.Value)
            //{
            //   txtconsumo2.Text = "0";

            //}
            //else
            //{
            //    txtconsumo2.Text = (dt2.Rows[0][0]).ToString(); ;
            //}
           

            chartConsumo.Series["Consumos"].Points.AddXY("FIBRA (Kgs)", Convert.ToInt32(txtconsumo2.Text));
            //chartConsumo.Series["Consumos"].Points.AddXY("Consumo 2", NDashboard.consumodos());

        }

        private void GrafTareas()
        {
            
                DataTable dt = new DataTable();
                dt = NDashboard.tareasCompletadas(Convert.ToInt32(txtnrofabricacion.Text));
                int tareascomp = Convert.ToInt32(dt.Rows[0][0]is DBNull ? 0 : dt.Rows[0][0]);

                chartTareas.Series["Tareas"].Points.AddXY("COMPLETADAS", tareascomp);
                //chartConsumo.Series["Consumos"].Points.AddXY("Consumo 2", NDashboard.consumodos());

                DataTable dt2 = new DataTable();
                dt2 = NDashboard.tareasPendientes(Convert.ToInt32(txtnrofabricacion.Text));
                int tareaspend = Convert.ToInt32(dt2.Rows[0][0]is DBNull ? 0 : dt2.Rows[0][0]);

               chartTareas.Series["Tareas"].Points.AddXY("PENDIENTES", tareaspend);
                //chartConsumo.Series["Consumos"].Points.AddXY("Consumo 2", NDashboard.consumodos());

            }

        private void GrafDias()
        {
            TimeSpan treal = dtpCierre.Value.Date.Subtract(dtpfechaorden.Value.Date);

            int dias = treal.Days + 1;
            chartDias.Series["Cantidad"].Points.AddXY("Días", dias);
        }

        private void txtConsumo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
