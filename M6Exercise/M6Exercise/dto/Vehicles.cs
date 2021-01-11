using System;
using System.Collections.Generic;
using System.Text;

namespace M6Exercise.dto
{
    class Vehicles
    {
        private string matricula = "";
        private string marca = "";
        private string color = "";
        private Wheel ruedas = new Wheel();

        public Vehicles()
        {

        }

        public Vehicles(Wheel ruedas, string matricula, string marca, string color )
        {
            this.ruedas = ruedas;
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        } 

        public string getMatricula()
        {
            return matricula;
        }

        public string getMarca()
        {
            return marca;
        }

        public string getColor()
        {
            return color;
        }

        public Wheel getWheels()
        {
            return ruedas;
        }

        public void setWheel(Wheel ruedas)
        {
            this.ruedas = ruedas;
        }
    }
}
