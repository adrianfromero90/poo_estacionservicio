using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacion_de_Servicio
{
    public class ESTACION
    {
        private SURTIDOR surtidor1;
        private SURTIDOR surtidor2;
        private SURTIDOR surtidor3;
        private float recaudacion_total;
        private int cantidad_ventas;

        public SURTIDOR Surtidor1
        {
            get { return surtidor1; }
            set { surtidor1 = value; }
        }        
        public SURTIDOR Surtidor2
        {
            get { return surtidor2; }
            set { surtidor2 = value; }
        }       
        public SURTIDOR Surtidor3
        {
            get { return surtidor3; }
            set { surtidor3 = value; }
        }
        public float Recaudacion_total
        {
            get { return recaudacion_total; }
            set { recaudacion_total = value; }
        }
        public int Cantidad_Ventas
        {
            get { return cantidad_ventas; }
            set { cantidad_ventas = value; }
        }
        
        private float recaudacionTotal()
        {
            return 0;
        }
        private float recaudacionSurtidor(SURTIDOR s)
        {
            return 0;
        }
        private SURTIDOR masRecaudo()
        { 
            return default(SURTIDOR);

        }

        private SURTIDOR masClientes()
        {
            return default(SURTIDOR); 
        }
        private float porcentajeVentas(NAFTA n)
        {
            return 0;

        }
        private float porcentajeRecaudacion(NAFTA n)
        {
            return 0;

        }

        private float promedioVentasxSurtidor(SURTIDOR s)
        {
            return 0;
        
        }
        private float promedioRecaudacionxSurtidor(SURTIDOR s)
        {
            return 0;
        
        }


    }
}