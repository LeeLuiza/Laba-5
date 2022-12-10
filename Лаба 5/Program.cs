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
    }
}