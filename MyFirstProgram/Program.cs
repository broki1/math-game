using MyFirstProgram;

var date = DateTime.UtcNow;

var menu = new Menu();

var name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name:");

    var name = Console.ReadLine();
    return name;
}