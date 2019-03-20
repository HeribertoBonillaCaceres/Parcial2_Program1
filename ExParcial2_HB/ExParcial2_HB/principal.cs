using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcial2_HB
{
    class principal
    {
        static void Main(string[] args)
        {
            auxiliar Ej1=new auxiliar();
            auxiliar Ej2=new auxiliar();
            auxiliar Ej3=new auxiliar();
            auxiliar Ej4=new auxiliar();

            int a,b,c;

            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese primer numero entero:");
                        a=int.Parse(Console.ReadLine());
                        if (a==0) 
                        {
                            Console.WriteLine("El producto de 0 por cualquier nùmero es 0");
                            else
                            {
                                Console.WriteLine("Ingrese segundo numero entero:");
                                b=int.Parse(Console.ReadLine());
                                Ej3.setp1(a,b);
                                Console.WriteLine("La multiplicaciòn es: "+getp1());
                                Console.ReadKey();
                            }
                        }
                    }break;
                case 2:
                    {
                        Console.WriteLine("Ingrese primer numero entero:");
                        a=int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo numero entero:");
                        b=int.Parse(Console.ReadLine());
                        if (b==0) 
                        {
                            Console.WriteLine("Error. No se puede dividir entre cero");
                          else
                            {  
                                Ej2.setp2(a,b);
                                Console.WriteLine("La divisiòn es: "+getp2());
                            }
                        }
                        Console.ReadKey();
                    }break;
                case 3:
                    {
                       Ej3.CapturaNombre();
                        Console.ReadKey();
                    }break;
                case 4:
                    {
                       Ej4.CapturaEdad();
                       Console.ReadKey();
                    }break;
                default:
                    {
                        Console.WriteLine("Selecciòn no vàlida");
                        Console.ReadKey();
                    }

                    }

            }

        }
    }

