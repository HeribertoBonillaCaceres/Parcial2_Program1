using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcial2_HB
{
    class auxiliar
    {
        private int a, b;
        int i, mult,edad;
        double div;
        string nombre;

        public setp1(int a,int b)
        {
            this.a=a;
            this.b=b;
        }

        public multiplicar()
        {
            mult=a*b;
        }
    
        public getp1()
        {
             return mult;
        }

        public setp2(int a,int b)
        {
            this.a=a;
            this.b=b;
        }

        public dividir()
        {
            div=a/b;
        }
    
        public getp2()
        {
             return mult;
        }

        public CapturaNombre()
        {
            for(i=1;i<=5;i++)
            {
                Console.WriteLine("Digite nombre de alumno: ");
                nombre=Console.ReadLine();
                Console.WriteLine("El nombre del alumno "+i+" es "+nombre);
            }
            Console.ReadKey();
        }

        public CapturaEdad()
        {
            i=1;
            do
            {
                Console.WriteLine("Digite edad de alumno: ");
                edad=int.Parse(Console.ReadLine());
                Console.WriteLine("La edad del alumno "+i+" es "+edad);
            }while(i<=5);
            Console.ReadKey();
        }
     }
}
