// 16. Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным.

// Ввели день недели.
System.Console.WriteLine("Введите номер дня недели ");
int numberOfWeek = Convert.ToInt32(System.Console.ReadLine());

// Задали условие чтобы узнать какие дни относятся к одному из типов дня недели
if ((numberOfWeek > 5) && (numberOfWeek < 8))
{
    System.Console.WriteLine("День недели выходной");
}
else
{
    System.Console.WriteLine("Будний день недели");
}
