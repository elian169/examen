using System;

namespace SueldoMayor
{

    public class Program
    {


        static void Main(string[] args)
        {

            int SueldoMayor = 0;
            String Empleado;
            int[] Sueldo = new int[6];
            string[] Nombre = new string[6];
                  
            Console.WriteLine("Ingrese el Nombre del Primer Empleado: ");
            Nombre[1] = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo del Primer Empleado");
            Sueldo[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del Segundo Empleado: ");
            Nombre[2] = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo del Segundo Empleado");
            Sueldo[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del Tercer Empleado: ");
            Nombre[3] = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo del Tercer Empleado");
            Sueldo[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del Cuarto Empleado: ");
            Nombre[4] = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo del Cuarto Empleado");
            Sueldo[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del Quinto Empleado: ");
            Nombre[5] = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo del Quinto Empleado");
            Sueldo[5] = int.Parse(Console.ReadLine());



            void SalarioMayor()
            {

                //Calcula el salario mayor
                if (Sueldo[1] > Sueldo[2] && Sueldo[1] > Sueldo[3] && Sueldo[1] > Sueldo[4] && Sueldo[1] > Sueldo[5])
                {
                    SueldoMayor = Sueldo[1];                    
                }
                else if (Sueldo[2] > Sueldo[1] && Sueldo[2] > Sueldo[3] && Sueldo[2] > Sueldo[4] && Sueldo[2] > Sueldo[5])
                {
                    SueldoMayor = Sueldo[2];                    
                }
                else if (Sueldo[3] > Sueldo[1] && Sueldo[3] > Sueldo[2] && Sueldo[3] > Sueldo[4] && Sueldo[3] > Sueldo[5])
                {
                    SueldoMayor = Sueldo[3];                    
                }
                else if (Sueldo[4] > Sueldo[1] && Sueldo[4] > Sueldo[2] && Sueldo[4] > Sueldo[3] && Sueldo[2] > Sueldo[5])
                {
                    SueldoMayor = Sueldo[4];                    
                }
                else
                {
                    SueldoMayor = Sueldo[5];
                }


                //Me dice que empleado tiene dicho salario
                if (SueldoMayor == Sueldo[1])
                {
                    Empleado = Nombre[1];
                }
                else if (SueldoMayor == Sueldo[2])
                {
                    Empleado = Nombre[2];
                }
                else if (SueldoMayor == Sueldo[3])
                {
                    Empleado = Nombre[3];
                }
                else if (SueldoMayor == Sueldo[4])
                {
                    Empleado = Nombre[4];
                }
                else
                {
                    Empleado = Nombre[5];
                }

            }
            
            SalarioMayor();

            Console.WriteLine("El sueldo mayor es de: " + Empleado);
            Console.WriteLine("Con un sueldo de: " + SueldoMayor);
            Console.ReadKey();
        }            
    }
}
