class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите номер задания" + "\nДля выхода нажмите - '0'");
        {
            string number = Console.ReadLine();
            while (true)
            {
                if (number == "1" || number == "2" || number == "3" || number == "4") break;
                else
                {
                    Console.WriteLine("Введите номер задания от 1-4");
                    number = Console.ReadLine();
                }
            }
            switch (number)
            {
                case "1":
                    IntFunction();
                    break;
                case "2":
                    ParseNumber();
                    break;
                case "3":
                    IntFunction2();
                    break;
                case "4":
                    ChangingArray();
                    break;
            }
        }

       
        static void IntFunction()
        {
            Console.WriteLine("Введите вещественное число");
            string floatnum = Console.ReadLine();

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
                    if (s == floatnum) break;
                }
            }
        }


        static void ParseNumber()
        {
            string intnumber = Console.ReadLine();

            char[] charnum = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
            int[] intnum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int summ = 0;
            for (int t = 0; t < intnumber.Length; t++)
            {
                int k = 0;
                for (int i = 0; i < charnum.Length; i++)
                    if (intnumber[t] == charnum[i]) k = k + 1;
                if (k == 0)
                {
                    Console.WriteLine("Число введено не корректно");
                    break;
                }

                for (int h = 0; h < intnum.Length; h++)  //считаем сумму
                    if (intnumber[t] == charnum[h]) summ += intnum[h];
            }

            Console.Write("Сумма ");
            Console.Write(summ);
        }


        static void IntFunction2()
        {
            string s = "4.5";
            int a = checkint(s);
            float float1 = checkfloat(s);
            float float2 = checkfloat(s);
            char c = checkchar(s);

            if (float1 == float2)
                Console.WriteLine("f и l равны");

            var sum = a + float1; // тип float

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


        static void ChangingArray()
        {
            string[] array;
            double[] arrayresult;
            string k;
            int n;
            double f;

            while (true)
            {
                Console.WriteLine("Введите длину массива");
                int x = int.Parse(Console.ReadLine());

                array = new string[x];

                for (int i = 0; i < x; i++) 
                {
                    Console.WriteLine(i + 1 + " элемент массива");
                    array[i] = (Console.ReadLine());
                }

                arrayresult = new double[x];
                
                for (int i = 0; i < x; i++) //заполнение массива arrayresult
                {
                    k = array[i];
                    if (check(k) == 0)
                    {
                        Console.WriteLine("Массив введен не верно. Вводите только вещественные числа и целые");
                        break;
                    }
                    else if (check(k) == 1)
                    {
                        n = int.Parse(array[i]);
                        if (n > 0) arrayresult[i] = Factorial(n);
                        else arrayresult[i] = n;
                    }
                    else
                    {
                        f = double.Parse(array[i]);
                        f = (f % (int)f) * 100;
                        arrayresult[i] = Math.Round(f);
                    }
                }
                break;
            }
            foreach (var e in array) //вывод
                Console.Write(e + " ");
            Console.WriteLine();
            foreach (object e in arrayresult)
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