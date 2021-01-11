using System;
using System.Collections.Generic;
using System.Text;

namespace M6Exercise.dto
{
    class Wheel 
    {
        private string marcaRuedaDelantera = "";
        private string marcaRuedaTrasera = "";
        private double diametroDelantero = 0;
        private double diametroTrasero = 0;

        public Wheel()
        {
            
        }

        public Wheel (string marcaRuedaDelantera, string marcaRuedaTrasera, double diametroDelantero, double diametroTrasero)
        {
            this.marcaRuedaDelantera = marcaRuedaDelantera;
            this.marcaRuedaTrasera = marcaRuedaTrasera;
            this.diametroDelantero = diametroDelantero;
            this.diametroTrasero = diametroTrasero;
        }

        public string getMarcaRuedaDelantera()
        {
            return marcaRuedaDelantera;
        }

        public string getMarcaRuedaTrasera()
        {
            return marcaRuedaTrasera;
        }

        public double getDiametroDelantero()
        {
            return diametroDelantero;
        }

        public double getDiametroTrasero()
        {
            return diametroTrasero;
        }

    }
}
