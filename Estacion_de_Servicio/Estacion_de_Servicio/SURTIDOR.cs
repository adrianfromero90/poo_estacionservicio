using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacion_de_Servicio
{
    
    public class SURTIDOR
    {
        public SURTIDOR()
        {
            this.tipo_nafta.Nombre = "Sin Nafta";
        }
        private int numero_surtidor;

        public int Numero_surtidor
        {
            get { return numero_surtidor; }
            set { numero_surtidor = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private NAFTA tipo_nafta;
        public NAFTA Tipo_nafta
        { 
            get { return tipo_nafta; }
            set { tipo_nafta = value; }        
        }

        private float recaudacion;
        public float Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        private int cantidad_recargas;

        public int Cantidad_Recargas
        {
            get { return cantidad_recargas; }
            set { cantidad_recargas = value; }
        }


        public void RecargarSurtidor()
        {
            
        }






    }
}