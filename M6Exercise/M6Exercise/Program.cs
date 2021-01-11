using System;

namespace M6Exercise.dto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool notCorrect = true;

            Utilities utilityObject = new Utilities();


            Console.WriteLine("Vols crear un Cotxe, opció 1, o una Moto, opció 2.");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (notCorrect)
            {
                if (opcion == 1) // Si opcion es igual a 1, inicializamos un coche
                {
                    utilityObject.RellenarInfoCoche();
                    notCorrect = false;
                }
                else if (opcion == 2) // Si opcion es igual a 2, inicializamos una moto
                {
                    utilityObject.RellenarInfoMoto();
                    notCorrect = false;
                }
                else // Si opcion es diferente de 1 y 2, mostramos un mensaje y volvemos a pedir.
                {
                    Console.WriteLine("La opción introducida es incorrecta. Por favor, intentelo de nuevo.");
                }
            }
        }
    }
}
