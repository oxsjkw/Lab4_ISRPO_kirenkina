Console.WriteLine("Здравствуйте!!!!!!!!");
Console.Write("Введите ФИО: ");
string name = Console.ReadLine();
Console.Write("Введите группу: ");
string group = Console.ReadLine();
Console.WriteLine("МЕНЮ:");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine($"ФИО: {name}");
        break;
    case 2:
        Console.WriteLine($"Группа: {group}");
        break;
    case 3:
        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
        break;
    case 4:
        break;
}