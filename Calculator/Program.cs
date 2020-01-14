using System;

namespace Calculator
{
    class Program
    {
        public static string result { get; set; }

        static void Main()
        {
            program();
        }

        static void program()
        {
            while (true)
            {
                tt(Extensions.c);
                tt(Extensions.aritmethics);
                char aritmethics = Convert.ToChar(Console.ReadLine());

                tt(Extensions.a);
                int firstNum = Convert.ToInt32(Console.ReadLine());

                if (aritmethics >= 5)
                {
                    int zero = 0;
                    engine(firstNum, zero, aritmethics);

                } else
                {

                    tt(Extensions.b);
                    int secondNum = Convert.ToInt32(Console.ReadLine());

                    engine(firstNum, secondNum, aritmethics);
                }

                tt(Extensions.d);

                string addMore = Console.ReadLine().ToLower();

                if (addMore == "y")
                {
                    tt(Extensions.e);
                    int c = Convert.ToInt32(Console.ReadLine());
                    tt(Extensions.c);
                    char t = Convert.ToChar(Console.ReadLine());
                    engine(Convert.ToInt32(result), c, t);
                }

                tt(Extensions.f);
                string goagain = Console.ReadLine().ToLower();
                if (goagain == "exit")
                    break;
                Console.Clear();
            }
        }

        static void engine(int a, int b, char aritmethics)
        {
            switch(aritmethics)
            {
                case '1':
                    result = (a + b).ToString();
                    Console.WriteLine(a + " + " + b + " = " + result);
                    break;
                case '2':
                    result = (a - b).ToString();
                    Console.WriteLine(a + " - " + b + " = " + result);
                    break;
                case '3':
                    result = (a * b).ToString();
                    Console.WriteLine(a + " * " + b + " = " + result);
                    break;
                case '4':
                    if (a == 0 || b == 0)
                    {
                        Console.WriteLine("Cant divide by 0");
                        break;
                    }
                    result = (a / b).ToString();
                    Console.WriteLine(a + " / " + b + " = " + result);
                    break;
                case '5': //Cos
                    result = Math.Cos(a).ToString();
                    Console.WriteLine("Cos(" + a + ") = " + result);
                    break;
                case '6': //Sin
                    result = Math.Sin(a).ToString();
                    Console.WriteLine("Sin(" + a + ") = " + result);
                    break;
                case '7': //Tan
                    result = Math.Tan(a).ToString();
                    Console.WriteLine("Tan(" + a + ") = " + result);
                    break;
                case '8': //Cos-1
                    result = Math.Cosh(a).ToString();
                    Console.WriteLine("Cos-1(" + a + ") = " + result);
                    break;
                case '9': //Sin-1
                    result = Math.Sinh(a).ToString();
                    Console.WriteLine("Sin-1(" + a + ") = " + result);
                    break;
                default:
                    Console.WriteLine("Wrong input parameter");
                    break;
            }
        }

        public static void tt(string b)
        {
            Console.WriteLine(b);
        }

        public static void oo()
        {
            Console.ReadLine();
        }


    }

    public static class Extensions
    {
        public static string a = "Input first number";
        public static string b = "Input second num";
        public static string c = "Input paramter";
        public static string aritmethics = "1: +, 2: -, 3: *, 4: /, 5: Cos, 6: Sin, 7: Tan, 8: Cos-1, 9: Sin-1";
        public static string d = "Do you wanna add more to your result? y / n";
        public static string e = "Input third num";
        public static string f = "Go again? Or type 'exit' to exit";
    }
}
