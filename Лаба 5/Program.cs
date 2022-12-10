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
    }
}