using System;

namespace maquin
{
    class Program
    {
        static void Main(string[] args)
        {
            producto co = new producto();
            co.nombre = "jugo";
            co.presio = 20;
            co.existencia = 5;
            producto si = new producto();
            si.nombre = "papita";
            si.presio = 5;
            si.existencia = 5;
            producto se = new producto();
            se.nombre = "refresco";
            se.presio = 20;
            se.existencia = 5;

            int p, y, w, e, m = 0,b,aa,bb;
            bool x = true;
            w = si.existencia;
            aa = se.existencia;
            bb = co.existencia;
            while (x)
            {
               

                Console.WriteLine("pagara con moneda o billete? ponga 1 si es moneda y 2 si es billete");
                p = Convert.ToInt32(Console.ReadLine());
                //moneda
                if (p == 1)
                {
                    Console.WriteLine("selecciona lo que quieres comprar");
                    Console.WriteLine("*****papitas(1)******");
                    Console.WriteLine("******refresco(2)****");
                    Console.WriteLine("******jugo(3)*****");
                    e = int.Parse(Console.ReadLine());
                    //papita
                    if (e == 1)
                    {
                        Console.WriteLine("la papita vale 5 pesos");
                        Console.WriteLine("solo monedas de 5, 10,25");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());

                        if (e == 5)
                        {
                            Console.WriteLine("la compra ha sido exitosa");

                        }
                        else if (e == 10)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 5 pesos");

                        }
                        else if (e == 25)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 20 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }
                        
                       
                        w--;
                        
                        m++;
                        Console.WriteLine("solo quedan " + w + " papitas");
                        
                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " papitas");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }
                    }
                    //refresco
                    if (e == 2)
                    {
                        Console.WriteLine("el refresco vale 20 pesos");
                        Console.WriteLine("solo monedas de 5, 10,25");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());

                        if (e == 25)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 5 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }

                        aa--;
                        m++;

                        Console.WriteLine("solo quedan " + aa + " refrescos");
                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " refrescos");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }

                    }
                    //jugo
                    if (e == 3)
                    {
                        Console.WriteLine("el jugo vale 20 pesos");
                        Console.WriteLine("solo monedas de 5, 10,25");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());

                        if (e == 25)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 5 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }

                        bb--;
                        m++;

                        Console.WriteLine("solo quedan " + bb + " jugos");
                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " jugos");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }

                    }





                }
                //billete
                if (p == 2)
                {
                    Console.WriteLine("selecciona lo que quieres comprar");
                    Console.WriteLine("*****papitas(1)******");
                    Console.WriteLine("******refresco(2)****");
                    Console.WriteLine("******jugo(3)*****");
                    e = int.Parse(Console.ReadLine());
                    //papita
                    if (e == 1)
                    {
                        Console.WriteLine("la papita vale 5 pesos");
                        Console.WriteLine("solo billetes de 50, 100,200");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());

                        if (e == 50)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 45 pesos");


                        }
                        else if (e == 100)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 95 pesos");

                        }
                        else if (e == 200)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 195 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }


                        w--;

                        m++;
                        Console.WriteLine("solo quedan " + w + " papitas");

                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " papitas");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }
                    }
                    //refresco
                    if (e == 2)
                    {
                        Console.WriteLine("el refresco vale 20 pesos");
                        Console.WriteLine("solo monedas de 50, 100,200");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());

                        if (e == 50)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 30 pesos");


                        }
                        else if (e == 100)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 80 pesos");

                        }
                        else if (e == 200)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 180 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }

                        aa--;
                        m++;

                        Console.WriteLine("solo quedan " + aa + " refrescos");
                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " refrescos");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }

                    }
                    //jugo
                    if (e == 3)
                    {
                        Console.WriteLine("el jugo vale 20 pesos");
                        Console.WriteLine("solo monedas de 50, 100,200");
                        Console.WriteLine("introdusca la moneda");
                        e = int.Parse(Console.ReadLine());
                        if (e == 50)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 30 pesos");


                        }
                        else if (e == 100)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 80 pesos");

                        }
                        else if (e == 200)
                        {
                            Console.WriteLine("la compra ha sido exitosa");
                            Console.WriteLine("te han sobrado 180 pesos");


                        }
                        else
                        {
                            Console.Write("no es el precio vuelva a intentarlo");
                        }

                        bb--;
                        m++;

                        Console.WriteLine("solo quedan " + bb + " jugos");
                        Console.WriteLine("quiere volver a comprar?");
                        Console.WriteLine("pulce (1) si lo desea y (2) si no ");
                        b = int.Parse(Console.ReadLine());

                        if (b == 2)
                        {
                            x = false;
                            Console.WriteLine("se vendieron " + m + " jugos");
                        }
                        else if (b == 1)
                        {
                            x = true;
                        }

                    }





                }


            }
        }
        
    }
}
