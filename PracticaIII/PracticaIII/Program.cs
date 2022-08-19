using System;
namespace PracticaIII
{
    internal class Program
    {
        public static void Main(String [] args)
        {
             string[] nombre;
             string[] carrera;
             int[] edad;
             string[] email;
             int[] telefono;

             Console.WriteLine("¿Cuántos registros desea agregar?: ");
             int numRegistros = int.Parse(Console.ReadLine());

             nombre = new string[numRegistros];
             carrera = new string[numRegistros];
             edad = new int[numRegistros];
             email = new string[numRegistros];
             telefono = new int[numRegistros];

             for(int i=0; i<numRegistros; i++)
             {
                 Console.Write("Ingrese el nombre del registro "+"["+(i+1)+"]: ");
                 nombre[i] = Console.ReadLine();

                 Console.Write("Ingrese la carrera " + "[" + (i + 1) + "]: ");
                 carrera[i] = Console.ReadLine();

                 Console.Write("Ingrese la edad " + "[" + (i + 1) + "]: ");
                 edad[i] = int.Parse(Console.ReadLine());

                 Console.Write("Ingrese el email " + "[" + (i + 1) + "]: ");
                 email[i] = Console.ReadLine();

                 Console.Write("Ingrese el telefono  " + "[" + (i + 1) + "]: ");
                 telefono[i] =int.Parse( Console.ReadLine());
                 Console.WriteLine(" ");
             }

             string opcion="si";
             while (opcion=="SI" || opcion=="si")
             {
                 Console.WriteLine("Ingrese el número de registro que desea ver: ");
                 int numRegistro = int.Parse(Console.ReadLine());
                 Console.WriteLine("Nombre: " + nombre[numRegistro] + "\nCarrera: " + carrera[numRegistro] + "\nEdad: " + edad[numRegistro] + "\nEmail: " + email[numRegistro] + "\nTeléfono: " + telefono[numRegistro]);

                 Console.WriteLine("¿Desea consultar otro registro? (Si/No): ");
                 opcion = Console.ReadLine();
             }
            

            //ejercicio II
            
            string[,] tabla = new string[3, 3];

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Ingrese el nombre: ");
                        tabla[i, j] = Console.ReadLine();
                    }else if (j == 1)
                    {
                        Console.Write("Ingrese la edad: ");
                        tabla[i, j] = Console.ReadLine();
                    }else if (j == 2)
                    {
                        Console.Write("Ingrese la carrera: ");
                        tabla[i, j] = Console.ReadLine();
                    }
                    

                }
                Console.WriteLine();
            }

           
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Imprimiento nombre, edad y carrera ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                     
                    Console.Write(tabla[i,j]+"       ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

