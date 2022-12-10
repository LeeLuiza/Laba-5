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
    }
}