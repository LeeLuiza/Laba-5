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