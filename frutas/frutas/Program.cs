using System;
namespace Frutas
{
    class Program
    {
        static void Main(string[] args)
        {
            string fru1, fru2, fru3, fru4, fru5, fru6, fru7,
                   fru8, fru9, fru10, fru11, fru12, fru13, fru14, fru15,
           fru16, fru17, fru18, fru19, fru20, fru21, fru22, fru23, fru24, fru25;

            Console.WriteLine("Bienvenido a nuestro sistema que adivinará la fruta en la que estes pensando.");

            Console.WriteLine("Piensa una de estas frutas.");

            Console.WriteLine("Mango, Naranja, Piña, Manzana, Kiwi, Fruta del dragón, Melón, Fresa, Sandía, Pera, Guanábana, Lichi");

            Console.WriteLine("Maracuyá, Cereza, Higo, Melocotón, Granada, Arándano, Pérsimon, Uva, Frambuesa, Mora azul, Limón");

            Console.WriteLine("Aguacate, Mamey");

            Console.WriteLine("La fruta en que piensas ¿inicia con la letra A?");
            fru1 = Console.ReadLine();
            if (fru1 == "si" || fru1 == "Si" || fru1 == "sí" || fru1 == "Sí" || fru1 == "SI" || fru1 == "SÍ" || fru1 == "sI" || fru1 == "sÍ")
            {
                Console.WriteLine("¿Tu fruta es roja?");
                fru2 = Console.ReadLine();
                if (fru2 == "si" || fru2 == "Si" || fru2 == "sí" || fru2 == "Sí" || fru2 == "SI" || fru2 == "SÍ" || fru2 == "sI" || fru2 == "sÍ")
                {
                    Console.WriteLine("Tu fruta es el arandano");
                }
                else
                {
                    Console.WriteLine("Tu fruta es el aguacate");
                }
            }
            else
            {
                Console.WriteLine("La fruta en que piensas ¿inicia con la letra C?");
                fru3 = Console.ReadLine();
                if (fru3 == "si" || fru3 == "Si" || fru3 == "sí" || fru3 == "Sí" || fru3 == "SI" || fru3 == "SÍ" || fru3 == "sI" || fru3 == "sÍ")
                {
                    Console.WriteLine("Tu fruta es la cereza");
                }
                else
                {
                    Console.WriteLine("La fruta en que piensas ¿inicia con la letra D?");
                    fru4 = Console.ReadLine();
                    if (fru4 == "si" || fru4 == "Si" || fru4 == "sí" || fru4 == "Sí" || fru4 == "SI" || fru4 == "SÍ" || fru4 == "sI" || fru4 == "sÍ")
                    {
                        Console.WriteLine("Tu fruta es el durazno");
                    }
                    else
                    {
                        Console.WriteLine("La fruta en que piensas ¿inicia con la letra F?");
                        fru5 = Console.ReadLine();
                        if (fru5 == "si" || fru5 == "Si" || fru5 == "sí" || fru5 == "Sí" || fru5 == "SI" || fru5 == "SÍ" || fru5 == "sI" || fru5 == "sÍ")
                        {
                            Console.WriteLine("¿Tu fruta es oriental?");
                            fru6 = Console.ReadLine();
                            if (fru6 == "si" || fru6 == "Si" || fru6 == "sí" || fru6 == "Sí" || fru6 == "SI" || fru6 == "SÍ" || fru6 == "sI" || fru6 == "sÍ")
                            {
                                Console.WriteLine("Tu fruta es fruta del dragón");
                            }
                            else
                            {
                                Console.WriteLine("¿Tu fruta es una baya?");
                                fru7 = Console.ReadLine();
                                if (fru7 == "si" || fru7 == "Si" || fru7 == "sí" || fru7 == "Sí" || fru7 == "SI" || fru7 == "SÍ" || fru7 == "sI" || fru7 == "sÍ")
                                {
                                    Console.WriteLine("Tu fruta es la frambuesa");
                                }
                                else
                                {
                                    Console.WriteLine("Tu fruta es la fresa");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La fruta en que piensas ¿inicia con la letra G?");
                            fru8 = Console.ReadLine();
                            if (fru8 == "si" || fru8 == "Si" || fru8 == "sí" || fru8 == "Sí" || fru8 == "SI" || fru8 == "SÍ" || fru8 == "sI" || fru8 == "sÍ")
                            {
                                Console.WriteLine("¿Tu fruta es roja?");
                                fru9 = Console.ReadLine();
                                if (fru9 == "si" || fru9 == "Si" || fru9 == "sí" || fru9 == "Sí" || fru9 == "SI" || fru9 == "SÍ" || fru9 == "sI" || fru9 == "sÍ")
                                {
                                    Console.WriteLine("Tu fruta es la granada");
                                }
                                else
                                {
                                    Console.WriteLine("Tu fruta es la guanabana");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La fruta en que piensas ¿inicia con la letra H?");
                                fru10 = Console.ReadLine();
                                if (fru10 == "si" || fru10 == "Si" || fru10 == "sí" || fru10 == "Sí" || fru10 == "SI" || fru10 == "SÍ" || fru10 == "sI" || fru10 == "sÍ")
                                {
                                    Console.WriteLine("Tu fruta es el higo");
                                }
                                else
                                {
                                    Console.WriteLine("La fruta en que piensas ¿inicia con la letra K?");
                                    fru11 = Console.ReadLine();
                                    if (fru11 == "si" || fru11 == "Si" || fru11 == "sí" || fru11 == "Sí" || fru11 == "SI" || fru11 == "SÍ" || fru11 == "sI" || fru11 == "sÍ")
                                    {
                                        Console.WriteLine("Tu fruta es el kiwi");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La fruta en que piensas ¿inicia con la letra L?");
                                        fru12 = Console.ReadLine();
                                        if (fru12 == "si" || fru12 == "Si" || fru12 == "sí" || fru12 == "Sí" || fru12 == "SI" || fru12 == "SÍ" || fru12 == "sI" || fru12 == "sÍ")
                                        {
                                            Console.WriteLine("¿Tu fruta es roja?");
                                            fru13 = Console.ReadLine();
                                            if (fru13 == "si" || fru13 == "Si" || fru13 == "sí" || fru13 == "Sí" || fru13 == "SI" || fru13 == "SÍ" || fru13 == "sI" || fru13 == "sÍ")
                                            {
                                                Console.WriteLine("Tu fruta es lichi");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Tu fruta es el limón");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("La fruta en que piensas ¿inicia con la letra M?");
                                            fru14 = Console.ReadLine();
                                            if (fru14 == "si" || fru14 == "Si" || fru14 == "sí" || fru14 == "Sí" || fru14 == "SI" || fru14 == "SÍ" || fru14 == "sI" || fru14 == "sÍ")
                                            {
                                                Console.WriteLine("¿Tu fruta es roja?");
                                                fru15 = Console.ReadLine();
                                                if (fru15 == "si" || fru15 == "Si" || fru15 == "sí" || fru15 == "Sí" || fru15 == "SI" || fru15 == "SÍ" || fru15 == "sI" || fru15 == "sÍ")
                                                {
                                                    Console.WriteLine("Tu fruta es la manzana");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("¿Tu fruta es amarilla?");
                                                    fru16 = Console.ReadLine();
                                                    if (fru16 == "si" || fru16 == "Si" || fru16 == "sí" || fru16 == "Sí" || fru16 == "SI" || fru16 == "SÍ" || fru16 == "sI" || fru16 == "sÍ")
                                                    {
                                                        Console.WriteLine("¿Tiene hueso?");
                                                        fru24 = Console.ReadLine();
                                                        if (fru24 == "si" || fru24 == "Si" || fru24 == "sí" || fru24 == "Sí" || fru24 == "SI" || fru24 == "SÍ" || fru24 == "sI" || fru24 == "sÍ")
                                                        {
                                                            Console.WriteLine("Tu fruta es el mango");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Tu fruta es la maracuyá");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("¿Tu fruta es azul?");
                                                        fru17 = Console.ReadLine();
                                                        if (fru17 == "si" || fru17 == "Si" || fru17 == "sí" || fru17 == "Sí" || fru17 == "SI" || fru17 == "SÍ" || fru17 == "sI" || fru17 == "sÍ")
                                                        {
                                                            Console.WriteLine("Tu fruta es la mora azul");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("¿Tu fruta es utilizada para hacer agua?");
                                                            fru18 = Console.ReadLine();
                                                            if (fru18 == "si" || fru18 == "Si" || fru18 == "sí" || fru18 == "Sí" || fru18 == "SI" || fru18 == "SÍ" || fru18 == "sI" || fru18 == "sÍ")
                                                            {
                                                                Console.WriteLine("Tu fruta es el melón");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Tu fruta es el mamey");
                                                            }
                                                            
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("La fruta en que piensas ¿inicia con la letra N?");
                                                fru19 = Console.ReadLine();
                                                if (fru19 == "si" || fru19 == "Si" || fru19 == "sí" || fru19 == "Sí" || fru19 == "SI" || fru19 == "SÍ" || fru19 == "sI" || fru19 == "sÍ")
                                                {
                                                    Console.WriteLine("Tu fruta es la naranja");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("La fruta en que piensas ¿inicia con la letra P?");
                                                    fru20 = Console.ReadLine();
                                                    if (fru20 == "si" || fru20 == "Si" || fru20 == "sí" || fru20 == "Sí" || fru20 == "SI" || fru20 == "SÍ" || fru20 == "sI" || fru20 == "sÍ")
                                                    {
                                                        Console.WriteLine("¿Tu fruta es verde?");
                                                        fru21 = Console.ReadLine();
                                                        if (fru21 == "si" || fru21 == "Si" || fru21 == "sí" || fru21 == "Sí" || fru21 == "SI" || fru21 == "SÍ" || fru21 == "sI" || fru21 == "sÍ")
                                                        {
                                                            Console.WriteLine("Tu fruta es la pera");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("¿Tu fruta es amarilla?");
                                                            fru22 = Console.ReadLine();
                                                            if (fru22 == "si" || fru22 == "Si" || fru22 == "sí" || fru22 == "Sí" || fru22 == "SI" || fru22 == "SÍ" || fru22 == "sI" || fru22 == "sÍ")
                                                            {
                                                                Console.WriteLine("Tu fruta es la piña");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Tu fruta es el persimon");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("La fruta en que piensas ¿inicia con la letra S?");
                                                        fru23 = Console.ReadLine();
                                                        if (fru23 == "si" || fru23 == "Si" || fru23 == "sí" || fru23 == "Sí" || fru23 == "SI" || fru23 == "SÍ" || fru23 == "sI" || fru23 == "sÍ")
                                                        {
                                                            Console.WriteLine("Tu fruta es la sandía");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("La fruta en la que piensas ¿Inicia con la letra U?");
                                                            fru25 = Console.ReadLine();
                                                            if (fru25 == "si" || fru25 == "Si" || fru25 == "sí" || fru25 == "Sí" || fru25 == "SI" || fru25 == "SÍ" || fru25 == "sI" || fru25 == "sÍ")
                                                            {
                                                                Console.WriteLine("Tu fruta es la uva");
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
