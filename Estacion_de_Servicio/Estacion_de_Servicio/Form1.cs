using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacion_de_Servicio
{
    public partial class Form1 : Form
    {
        public ESTACION estacion = new ESTACION();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            lblsurtidor1.Text = estacion.Surtidor1.Tipo_nafta.Nombre;
            lblsurtidor2.Text = estacion.Surtidor2.Tipo_nafta.Nombre;
            lblsurtidor3.Text = estacion.Surtidor3.Tipo_nafta.Nombre;
            */
        }
    }
}
