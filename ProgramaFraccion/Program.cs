using System;

namespace ProgramaFraccion
{
class Fraccion
    {
        private int num;
        private int dem;

        public Fraccion(int num, int dem)
        {
            this.num = num; this.dem = dem;
        }

        public Fraccion()
        {
            num = 1;
            dem = 1;
        }

        public static Fraccion operator + (Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.num*y.dem+x.dem*y.num,x.dem*y.dem);
            return result;
        }

        public static Fraccion operator -(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.num * y.dem - x.dem * y.num, x.dem * y.dem);
            return result;
        }

        public static Fraccion operator *(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.num * y.num, x.dem * y.dem);
            return result;
        }

        public static Fraccion operator  /(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.num * y.dem, x.dem * y.num);
            return result;
        }

        public void Imprime() => Console.WriteLine(" {0}\n---\n {1}\n", num, dem);

        public void Imprime_Suma() => Console.WriteLine("" +
            "|| La suma de fraccion es: \n\n {0}\n---\n {1}\n", num, dem);

        public void Imprime_Resta() => Console.WriteLine("" +
            "|| La Resta de fraccion es: \n\n {0}\n---\n {1}\n", num, dem);

        public void Imprime_Multi() => Console.WriteLine("" +
            "|| La Multiplicacion de fraccion es: \n\n {0}\n---\n {1}\n", num, dem);

        public void Imprime_Div() => Console.WriteLine("" +
            "|| La División de fraccion es: \n\n {0}\n---\n {1}\n", num, dem);

        public decimal A_decimal()
        {
            return num / dem;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Fraccion a = new Fraccion(1, 3);
            Fraccion b = new Fraccion(2, 5);
            Fraccion c = a + b ;
            Fraccion d = a - b;
            Fraccion e = a * b;
            Fraccion f = a / b;

            a.Imprime(); 
            b.Imprime();
            c.Imprime_Suma();
            d.Imprime_Resta();
            e.Imprime_Multi();
            f.Imprime_Div();

            Console.ReadKey();
        }
    }
}
