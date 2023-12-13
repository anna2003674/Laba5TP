using TP_Laba4;

LogicClass logicClass = new LogicClass();

List<string> lst = new();
List<int> lst2 = new();
int number, number1, number2;
string test = "", str;

while (true)
{
    Console.Write("Введите номер теста: ");
    test = Console.ReadLine();
    switch (test)
    {
        case "1":
            Console.Write("\n-----Тест-1-----\n");
            Console.Write("Введите первое число: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.NumbersDelta(number1, number2));
            break;

        case "2":
            Console.Write("\n-----Тест-2-----\n");
            Console.WriteLine("(для окончания ввода нажать Enter)");
            while (true)
            {
                Console.Write("Введите строку: ");
                str = Console.ReadLine();
                if (str == "") break;
                lst.Add(str);
            }
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.ListLength(lst));
            lst.Clear();
            break;

        case "3":
            Console.Write("\n-----Тест-3-----\n");
            Console.Write("Введите дату ВОВ: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.YearOfWar(number));
            break;

        case "4":
            Console.Write("\n-----Тест-4-----\n");
            Console.Write("Введите номер месяца: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.Seasons(number));
            break;

        case "5":
            Console.Write("\n-----Тест-5-----\n");
            Console.Write("Введите количество часов: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.CountMinutes(number));
            break;

        case "6":
            Console.Write("\n-----Тест-6-----\n");
            Console.Write("Введите текущую тему: ");
            str = Console.ReadLine();
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.EditTopic(str));
            break;

        case "7":
            Console.Write("\n-----Тест-2-----\n");
            Console.WriteLine("(для окончания ввода ввести -1)");
            while (true)
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());
                if (number == -1) break;
                lst2.Add(number);
            }
            Console.WriteLine("---Результат---");
            Console.WriteLine(logicClass.ArrayTrippledSumm(lst2));
            lst2.Clear();
            break;
    }
}