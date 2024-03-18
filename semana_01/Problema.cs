using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Problema
    {
       public void Start()
        {
            problema();
        }

        bool continueflag = true;
        public void problema ()
        {
            while (continueflag)
            {
                Console.WriteLine("Elige que figura quieres sacar su area");

                Console.WriteLine("Rectangulo");
                Console.WriteLine("Circulo");
                Console.WriteLine("Triangulo");

                string Option = Console.ReadLine();

                switch (Option)
                {
                    case "Rectangulo":
                        float rBase, rAltura;

                        Console.WriteLine("Ingresa la base de su rectangulo");
                        rBase = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la altura de su rectangulo");
                        rAltura = float.Parse(Console.ReadLine());

                        Rectangulo rectangulo = new Rectangulo(rBase, rAltura);
                        Console.WriteLine($"El area del rectangulo es {rectangulo.AreaRectangulo()}");

                        break;
                    case "Circulo":
                        float cRadio, pi = 3.14f;

                        Console.WriteLine("Ingresa el radio del circulo");
                        cRadio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(cRadio, pi);
                        Console.WriteLine($"El area del circulo es {circulo.AreaCirculo()}");

                        break;
                    case "Triangulo":
                        float tBase, tAltura;

                        Console.WriteLine("ingresa la base del triangulo");
                        tBase = float.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa la altura del triangulo");
                        tAltura = float.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(tBase, tAltura);
                        Console.WriteLine($"El area del triangulo es {triangulo.AreaTriangulo()}");
                        break;
                }

                Console.WriteLine("Deseas continuar, SI/NO");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }
            }

            Console.WriteLine();

        }

    }
}
