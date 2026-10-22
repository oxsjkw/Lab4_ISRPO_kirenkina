Console.WriteLine("Здравствуйте!!!!!!");
Console.Write("Введите ФИО: ");
string name = Console.ReadLine();
Console.Write("Введите группу: ");
string group = Console.ReadLine();
Console.Write("""Меню:
1 — Показать ФИО
2 — Показать группу
3 — Показать дату
4 — Выход""");
int command = Console.ReadLine();
if command == 1 { Console.WriteLine(name); }
else if command == 2 { Console.WriteLine(group); }
else if command == 3 {  };
else if command == 4 { exit };