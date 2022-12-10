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
        static void L1()
        {
            Console.WriteLine("Введите вещественное число");
            string f = Console.ReadLine();

            int b;
            while (true)
            {

                Console.WriteLine("Введите число" +
                    "\nq - если хотите завершить работу программы");
                string s = Console.ReadLine();


                if (s == "q") break;

                if (int.TryParse(s, out b))
                    Console.WriteLine(s);
                else
                {
                    if (s == f) break;
                }
            }
        }
        static void L2()
        {
            string x = Console.ReadLine();

            char[] a = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
            int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int summ = 0;
            for (int t = 0; t < x.Length; t++)
            {
                int k = 0;
                for (int i = 0; i < a.Length; i++)
                    if (x[t] == a[i]) k = k + 1;
                if (k == 0)
                {
                    Console.WriteLine("Число введено не корректно");
                    break;
                }

                for (int h = 0; h < c.Length; h++)  //считаем сумму
                    if (x[t] == a[h]) summ += c[h];
            }

            Console.Write("Сумма ");
            Console.Write(summ);
        }
        static void L4()
        {
        v:
            Console.WriteLine("Введите длину массива");
            int x = int.Parse(Console.ReadLine());

            var array = new string[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i + 1 + " элемент массива");
                array[i] = (Console.ReadLine());
            }

            var a = new object[x];
            string k;
            int n;
            double f;
            for (int i = 0; i < x; i++) //заполнение массива a
            {
                k = array[i];
                if (check(k) == 0)
                {
                    Console.WriteLine("Массив введен не верно. Вводите только вещественные числа и целые");
                    goto v;
                }
                else if (check(k) == 1)
                {
                    n = int.Parse(array[i]);
                    if (n > 0) a[i] = Factorial(n);
                    else a[i] = n;
                }
                else
                {
                    f = double.Parse(array[i]);
                    f = (f % (int)f) * 100;
                    a[i] = Math.Round(f);
                }
            }
            foreach (var e in array)
                Console.Write(e + " ");
            Console.WriteLine();
            foreach (object e in a)
                Console.Write(e + " ");
        }
        static int check(string s)
        {
            double f;
            int n;
            if (int.TryParse(s, out n))
            {
                n = int.Parse(s);
                return 1;
            }
            else if (double.TryParse(s, out f))
            {
                f = double.Parse(s);
                return 2;
            }
            else return 0;
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result = result * i;
            return result;
        }
    }
}