using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprg_v4.front
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btContar_Click(object sender, EventArgs e)
        {
            try
            {
                int incremento = 1;

                int desde = Convert.ToInt32(txtDesde.Text);   
                int hasta = Convert.ToInt32(txtHasta.Text);

                #region Version for
                //if (desde > hasta)
                //{
                //    incremento = incremento * -1;
                //    for (int i = desde; i >= hasta; i = i + incremento)
                //    {
                //        lblSalida.Text = i.ToString("000");
                //        Task.Delay(5).Wait();
                //        this.Refresh();
                //    }
                //}
                //else
                //{
                //    for (int i = desde; i <= hasta; i = i + incremento)
                //    {
                //        lblSalida.Text = i.ToString("000");
                //        Task.Delay(5).Wait();
                //        this.Refresh();
                //    }
                //}
                #endregion

                #region version while
                int i = desde;
                bool condicion;

                if (desde > hasta)
                {
                    incremento = incremento * -1;
                    condicion = i >= hasta;
                }
                else 
                {
                    condicion = i <= hasta;
                }
                
                while (condicion)
                {
                    lblSalida.Text = i.ToString("000");
                    Task.Delay(5).Wait();
                    this.Refresh();
                    i = i + incremento;
                    if (desde > hasta)
                    {
                        condicion = i >= hasta;
                    }
                    else
                    {
                        condicion = i <= hasta;
                    }
                }
                #endregion

            }
            catch (Exception err)
            {
                lblMsg.Text = "Error: " + err.Message;
            }



        }
    }
}
