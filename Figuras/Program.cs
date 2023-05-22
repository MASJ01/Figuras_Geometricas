using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;   //Con esta instruccion se cambia el color de fondo
            int opcion; 

            double lado, bas, altura, perimetro, apotema, area, diagomay, diagomen, basmay, basmen, diagonal;

            double radio, area1, perimetro1; 

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;   
                Console.Clear();
                

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|   AREAS Y PERIMETROS      |");
                Console.WriteLine("|                           |");
                Console.WriteLine("|  1.- Cuadrado             |");
                Console.WriteLine("|  2.- Triángulo Equilatero |");
                Console.WriteLine("|  3.- Circulo              |");
                Console.WriteLine("|  4.- Rectangulo           |");
                Console.WriteLine("|  5.- Rombo                |");
                Console.WriteLine("|  6.- Trapecio             |");
                Console.WriteLine("|  7.- Pentágono            |");
                Console.WriteLine("|  8.- Salir                |");
                Console.WriteLine("|                           |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite la opcion correcta");
                Console.Write(" (   )");
                Console.SetCursorPosition(3, 15);
                opcion = int.Parse(Console.ReadLine());

                

                switch (opcion)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CALCULAR AREA Y PERIMETRO DEL CUADRADO");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el lado del cuadrado");
                        lado = double.Parse(Console.ReadLine());

                        if (lado <= 0)
                        {
                            Console.WriteLine("Operacion no valida");
                            Console.WriteLine("Se devolvera al menú");
                           
                        }

                        else
                        {

                            area = lado * lado;
                            perimetro = lado + lado + lado + lado;

                            Console.WriteLine("El area del cuadrado es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);

                            Console.WriteLine("---------------");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("---------------");
                        }
                        Console.ReadLine();
                        break; 

                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DEL TRIANGULO");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese la base del triangulo");
                        bas = double.Parse(Console.ReadLine());
                        Console.WriteLine(" ");

                        altura= Math.Sqrt((bas*bas)-((bas/2)*(bas/2))); 

                        if (bas <= 0)
                        {
                           
                                Console.WriteLine("Operacion no valida");
                                Console.WriteLine("Se devolvera al menú");
                                Console.ReadLine(); 
                        }
                        else
                        {

                            area = (bas * altura) / 2;
                            perimetro = bas + bas + bas;

                            Console.WriteLine("El area del triangulo es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del triangulo es: " + perimetro);

                            Console.WriteLine("          ..          ");
                            Console.WriteLine("         . ..         ");
                            Console.WriteLine("        .   ..        ");
                            Console.WriteLine("       .     ..       ");
                            Console.WriteLine("      .       ..      ");
                            Console.WriteLine("     .         ..     ");
                            Console.WriteLine("    .           ..    ");
                            Console.WriteLine("   .             ..   ");
                            Console.WriteLine("  -----------------");

                            Console.ReadLine();
                        }
                        break; 

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DEL CIRCULO");
                        Console.WriteLine("Ingrese el valor del radio");
                        radio = double.Parse(Console.ReadLine());

                        if (radio <= 0)
                        {
                            Console.WriteLine("Operacion no valida");
                            Console.WriteLine("Se devolvera al menú");
                        }
                        else
                        {
                            area1 = radio * radio * Math.PI;
                            perimetro1 = 2 * Math.PI * radio;

                            Console.WriteLine("El area del circulo es: " + area1);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del circulo es: " + perimetro1);


                            Console.WriteLine("                 .  .   .                 ");
                            Console.WriteLine("             .              .             ");
                            Console.WriteLine("          .                    .          ");
                            Console.WriteLine("        .                        .        ");
                            Console.WriteLine("      .                            .      ");
                            Console.WriteLine("    .                                .    ");
                            Console.WriteLine("   .                                  .   ");
                            Console.WriteLine("  .                                    .  ");
                            Console.WriteLine(" .                                      . ");
                            Console.WriteLine(".                                       . ");
                            Console.WriteLine(".                                       . ");
                            Console.WriteLine(".                                       . ");
                            Console.WriteLine(".                                       . ");
                            Console.WriteLine(" .                                     .  ");
                            Console.WriteLine("  .                                   .   ");
                            Console.WriteLine("   .                                 .    ");
                            Console.WriteLine("     .                             .      ");
                            Console.WriteLine("       .                         .        ");
                            Console.WriteLine("         .                     .          ");
                            Console.WriteLine("            .                .             ");
                            Console.WriteLine("               .    .    .                ");

                        }
                        Console.ReadLine();
                        break; 

                    case 4:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.Cyan; 
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DEL RECTANGULO");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingresa el valor de la base del rectangulo");
                        bas = double.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingresa el valor de la altura del rectangulo");
                        altura = double.Parse(Console.ReadLine());

                        if (bas <= 0)
                        {
                            if (altura <= 0)
                            {
                                Console.WriteLine("Operacion no valida");
                                Console.WriteLine("Se devolvera al menú");
                            }
                        }

                        else
                        {
                            area = bas * altura;
                            perimetro = 2 * bas + 2 * altura;

                            Console.WriteLine("El area del rectangulo es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);

                            if (bas > altura)
                            {
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("|                                    |");
                                Console.WriteLine("|                                    |");
                                Console.WriteLine("|                                    |");
                                Console.WriteLine("|                                    |");
                                Console.WriteLine("--------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("--------------");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("|            |");
                                Console.WriteLine("---------------");
                            }
                        }
                        Console.ReadLine(); 
                        break; 

                    case 5:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DE UN ROMBO");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el valor de la diagonal mayor del rombo");
                        diagomay = double.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el valor de la diagonal menor del rombo");
                        diagomen = double.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el valor de un lado del rombo");
                        lado = double.Parse(Console.ReadLine());

                        if (lado < 0)
                        {
                            if (diagomay < 0)
                            {
                                if (diagomen < 0)
                                {
                                    Console.WriteLine("Operacion no valida");
                                    Console.WriteLine("Se devolvera al menú");
                                }
                            }
                        }

                        else
                        {

                            area = (diagomay * diagomen) / 2;
                            perimetro = lado + lado + lado + lado;

                            Console.WriteLine("El area del rombo es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del rombo es: " + perimetro);

                            if (diagomay > diagomen)
                            {
                                Console.WriteLine("          ..          ");
                                Console.WriteLine("        .   ..        ");
                                Console.WriteLine("       .     ..       ");
                                Console.WriteLine("      .       ..      ");
                                Console.WriteLine("     .         ..     ");
                                Console.WriteLine("      .       ..      ");
                                Console.WriteLine("       .     ..       ");
                                Console.WriteLine("        .   ..        ");
                                Console.WriteLine("          ..          ");
                            }
                            else
                            {

                                Console.WriteLine("                 ..                   ");
                                Console.WriteLine("              .       ..              ");
                                Console.WriteLine("           .             ..           ");
                                Console.WriteLine("        .                   ..        ");
                                Console.WriteLine("     .                        ..      ");
                                Console.WriteLine("        .                    .        ");
                                Console.WriteLine("           .             .            ");
                                Console.WriteLine("               .      .               ");
                                Console.WriteLine("                  ..                  ");

                            }



                        }
                        Console.ReadLine(); 
                        break; 

                    case 6:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DE UN TRAPECIO");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el valor de la base mayor del trapecio");
                        basmay = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la base menor del trapecio");
                        basmen = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura del trapecio");
                        altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la diagonal");
                        diagonal = int.Parse(Console.ReadLine());
                        

                        if (basmay <= 0)
                        {
                            if (basmen <= 0)
                            {
                                if (altura <= 0)
                                {
                                    Console.WriteLine("Operacion no valida");
                                    Console.WriteLine("Se devolvera al menú");                                    
                                }
                            }
                        }

                        else
                        {

                            area = ((basmay * basmen) * altura) / 2;
                            perimetro = basmay + basmen + diagonal+diagonal;

                            Console.WriteLine("El area del trapecio es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del trapecio es: " + perimetro);


                            if (basmay > basmen)
                            {
                                Console.WriteLine("          ..........          ");
                                Console.WriteLine("         .          .         ");
                                Console.WriteLine("        .            .        ");
                                Console.WriteLine("       .              .       ");
                                Console.WriteLine("      .                .      ");
                                Console.WriteLine("     .                  .     ");
                                Console.WriteLine("    .                    .    ");
                                Console.WriteLine("   .                      .   ");
                                Console.WriteLine("  ..........................  ");
                            }
                            else
                            {
                                Console.WriteLine("  ..........................  ");
                                Console.WriteLine("   .                      .   ");
                                Console.WriteLine("    .                    .    ");
                                Console.WriteLine("     .                  .     ");
                                Console.WriteLine("      .                .      ");
                                Console.WriteLine("       .              .       ");
                                Console.WriteLine("        .            .        ");
                                Console.WriteLine("         .          .         ");
                                Console.WriteLine("          ..........          ");

                            }
                        }
                        Console.ReadLine(); 
                        break; 

                    case 7:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DE UN PENTAGONO");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el valor de la apotema del pentágono");
                        apotema = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de un lado del pentágono");
                        lado = double.Parse(Console.ReadLine());

                        if (lado <= 0)
                        {

                            if (apotema <= 0)
                            {
                                Console.WriteLine("Operacion no valida");
                                Console.WriteLine("Se devolvera al menú");
                            }
                        }
                        else
                        {
                            perimetro = lado + lado + lado + lado + lado;
                            area = (perimetro * apotema) / 2;

                            Console.WriteLine("El area del pentágono es: " + area);
                            Console.WriteLine(" ");
                            Console.WriteLine("El perimetro del pentágono es: " + perimetro);

                            Console.WriteLine("                 ..                    ");
                            Console.WriteLine("              .     ..                 ");
                            Console.WriteLine("            .          ..              ");
                            Console.WriteLine("          .              ..            ");
                            Console.WriteLine("        .                  ..          ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .                      ..        ");
                            Console.WriteLine("      .........................        ");
                        }
                        Console.ReadLine(); 
                        break; 
                }




            }while(opcion!=8);

        }
    }
}

