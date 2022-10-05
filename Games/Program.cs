namespace Games
{
    class Program
    {
        static void Matrix(int[] numbers)
        {

        }
        static void Main(string[] args)
        {
            string program;
            int number, k, s = 0, attempts = 0, sum;
            int delitel = 0, q = 0, a = 0;

            int[,] array = new int[10, 10];
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    array[i, j] = i * j;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++) ;
            }

            while (q < 9)
            {
                Console.WriteLine("\nВыберите программу (вводите число): \n 1. Угадай число \n 2. Таблица умножения \n 3. Вывод делителей числа");
                program = Console.ReadLine();
                switch (program)
                {
                    case "1":
                        Random rnd = new Random();
                        number = rnd.Next(-1, 101);
                        Console.WriteLine("Добро пожаловать в игру Угадай число");
                        Console.WriteLine("Вводите любое число, а мы будем говорить вам, ниже или выше");

                        while (s != number)
                        {
                            Console.WriteLine("Введите число: ");
                            k = int.Parse(Console.ReadLine());

                            if (k < number)
                            {
                                Console.WriteLine("Число выше");
                                attempts++;
                            }

                            if (k > number)
                            {
                                Console.WriteLine("Число ниже");
                                attempts++;
                            }

                            if (k == number)
                            {
                                Console.WriteLine("Вы угадали число! Поздравляем! Вы выиграли дом в Геленджике!");
                                Console.WriteLine("Ваше кол-во попыток: " + attempts);
                                s = s + number;
                            }
                        }
                        break;
                    case "2":
                        for (int i = 1; i < array.GetLength(0); i++)
                        {
                            Console.WriteLine();
                            for (int j = 1; j < array.GetLength(1); j++)
                                Console.Write("{0,3}", array[i, j]);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Введите число: ");
                        delitel = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= delitel; i++)
                        {
                            if (delitel % i == 0)
                                Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
