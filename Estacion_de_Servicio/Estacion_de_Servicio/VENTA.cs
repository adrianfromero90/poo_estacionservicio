using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacion_de_Servicio
{
    public class VENTA
    {
        private DateTime id_venta;

        /*
        public DateTime ID_venta
        {
            get { return id_venta; }
            set { id_venta = DateTime.Now(); }              
        }
        */

        private SURTIDOR surtidor;

        public SURTIDOR SURTIDOR
        {
            get { return surtidor; }
            set { surtidor = value; }
        }



    }
}