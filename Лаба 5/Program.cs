class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите номер задания");
        {
            Console.WriteLine("Для выхода нажмите - '0'");
            string point = Console.ReadLine();
            switch (point)
            {

                case "1":
                    L1();
                    break;
                case "2":
                    L2();
                    break;
                case "3":
                    L3();
                    break;
                case "4":
                    L4();
                    break;
            }
        }
        static void L3()
        {
            string s = "4.5";
            int a = checkint(s);
            float f = checkfloat(s);
            float l = checkfloat(s);
            char c = checkchar(s);

            if (f == l)
                Console.WriteLine("f и l равны");

            var sum = a + f; // тип float

            char a1 = (char)a;
            Console.WriteLine(a1);

            if (a1 == c)
                Console.WriteLine("a и c равны");
        }
        static float checkfloat(string s)
        {
            Console.WriteLine("Введите вещественное число");
            float f;
            while (true)
            {
                s = Console.ReadLine();
                if (float.TryParse(s, out f))
                {
                    f = float.Parse(s);
                    break;
                }
                else Console.WriteLine("Введенное число не корректно. Повторите попытку");
            }
            return f;
        }
        static char checkchar(string s)
        {
            Console.WriteLine("Введите символ");
            char f;
            while (true)
            {
                s = Console.ReadLine();
                if (char.TryParse(s, out f))
                {
                    f = char.Parse(s);
                    break;
                }
                else Console.WriteLine("Введенные символы не корректны. Повторите попытку");
            }
            return f;
        }
        static int checkint(string s)
        {
            Console.WriteLine("Введите целое число");
            int f;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out f))
                {
                    f = int.Parse(s);
                    break;
                }
                else Console.WriteLine("Введенное число не корректно. Повторите попытку");
            }
            return f;
        }
    }
}