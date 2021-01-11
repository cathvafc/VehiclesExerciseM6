using System;
using System.Collections.Generic;
using System.Text;

namespace M6Exercise.dto
{
    class Utilities
    {
        bool matriculaNotCorrect = true;
        bool wheelsNotCorrect = true;
        bool priorResult = true;
        string matricula = "";
        string marca = "";
        string color = "";
        string marcaRuedasDelanteras = "";
        string marcaRuedasTraseras = "";
        double diametroRuedasDelanteras = 0;
        double diametroRuedasTraseras = 0;

        public bool ComprobarMatricula(string matricula) // La matricula tiene que tener 4 numeros y 2 o 3 letras.
        {
            bool result = true;           
            int lengthMatricula = 0;

            lengthMatricula = matricula.Length;

            if (lengthMatricula < 6 || lengthMatricula > 7)
            {
                result = true;
                priorResult = false;
            }
            else
            {
                //Checkers
                for (int i = 0; i < 4; i++)
                {
                    priorResult = char.IsLetter(matricula[i]);

                    if (!priorResult)
                    {
                        break;
                    }

                }

                if (priorResult)
                {
                    for (int j = 4; j < matricula.Length; j++)
                    {
                        priorResult = char.IsDigit(matricula[j]);

                        if (!priorResult)
                        {
                            break;
                        }
                    }
                }       
               
            }

            if (priorResult) // Si todos los campos son correctos. Se devuelve false     
            {
                result = false;
            }


            return result;
        }

        public bool ComprobarRuedas(double diametro) // El diametro de las ruedas tiene que estar entre (0.4 y 4).
        {
            bool result = true;

            if (diametro > 0.4 && diametro < 4)
            {
                result = false; 
            }

            return result;
        }

        public void RellenarInfoCoche()
        {
            while (matriculaNotCorrect) // Hasta que la matrícula no sea correcta no paramos de pedirla
            {
                Console.WriteLine("Introdueix la matrícula del cotxe: ");
                matricula = Console.ReadLine();

                matriculaNotCorrect = ComprobarMatricula(matricula); //Metodo que comprueba que el formato de la matrícula es correcto TODO:MAGL

            }
            Console.WriteLine("Introdueix la marca del cotxe: ");
            marca = Console.ReadLine();

            Console.WriteLine("Introdueix el color del cotxe: ");
            color = Console.ReadLine();

          
            Console.WriteLine("Introdueix la marca de les rodes delanteres: ");
            marcaRuedasDelanteras = Console.ReadLine();

            while (wheelsNotCorrect) // Comprovamos que el diametro de las ruedas es correcto
            {
                Console.WriteLine("Introdueix el diametre de les rodes delanteres. El valor ha d'estar entre 0.4 y 4: ");
                diametroRuedasDelanteras = Convert.ToDouble(Console.ReadLine());

                wheelsNotCorrect = ComprobarRuedas(diametroRuedasDelanteras);

            }

            Console.WriteLine("Introdueix la marca de les rodes traseres: ");
            marcaRuedasTraseras = Console.ReadLine();

            wheelsNotCorrect = true; // Reiniciamos el booleano para comprobar la parte trasera

            while (wheelsNotCorrect)// Comprovamos que el diametro de las ruedas es correcto
            {
                Console.WriteLine("Introdueix el diametre de les rodes traseres. El valor ha d'estar entre 0.4 y 4: ");
                diametroRuedasTraseras = Convert.ToDouble(Console.ReadLine());

                wheelsNotCorrect = ComprobarRuedas(diametroRuedasTraseras);

            }

            

            Wheel ruedas1 = new Wheel(marcaRuedasDelanteras, marcaRuedasTraseras, diametroRuedasDelanteras,diametroRuedasTraseras);
            Car coche = new Car(ruedas1, matricula, marca, color);

        }

        public void RellenarInfoMoto()
        {
            while (matriculaNotCorrect) // Hasta que la matrícula no sea correcta no paramos de pedirla
            {
                Console.WriteLine("Introdueix la matrícula de la moto: ");
                matricula = Console.ReadLine();

                matriculaNotCorrect = ComprobarMatricula(matricula); //Metodo que comprueba que el formato de la matrícula es correcto TODO:MAGL

            }
            Console.WriteLine("Introdueix la marca de la moto: ");
            marca = Console.ReadLine();

            Console.WriteLine("Introdueix el color de la moto: ");
            color = Console.ReadLine();

            while (wheelsNotCorrect)
            {
                Console.WriteLine("Introdueix la marca de la roda delantera: ");
                marcaRuedasDelanteras = Console.ReadLine();

                while (wheelsNotCorrect) // Comprovamos que el diametro de la rueda es correcto
                {
                    Console.WriteLine("Introdueix el diametre de la roda delantera. El valor ha d'estar entre 0.4 y 4: ");
                    diametroRuedasDelanteras = Convert.ToDouble(Console.ReadLine());

                    wheelsNotCorrect = ComprobarRuedas(diametroRuedasDelanteras);

                }

                Console.WriteLine("Introdueix la marca de la roda trasera: ");
                marcaRuedasTraseras = Console.ReadLine();

                wheelsNotCorrect = true; // Reiniciamos el booleano para comprobar la parte trasera

                while (wheelsNotCorrect)// Comprovamos que el diametro de la rueda es correcto
                {
                    Console.WriteLine("Introdueix el diametre de la roda trasera. El valor ha d'estar entre 0.4 y 4: ");
                    diametroRuedasTraseras = Convert.ToDouble(Console.ReadLine());

                    wheelsNotCorrect = ComprobarRuedas(diametroRuedasTraseras);

                }

            }

            Wheel ruedas2 = new Wheel(marcaRuedasDelanteras, marcaRuedasTraseras, diametroRuedasDelanteras, diametroRuedasTraseras);
            Bike moto = new Bike(ruedas2, matricula, marca, color);

        }
    }
}
