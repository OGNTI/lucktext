string name;
string klass;
string feelingToday;

Console.WriteLine("Hello, what is your name?");
name = Console.ReadLine();

Console.WriteLine("Which class do you go in?");
klass = Console.ReadLine();

Console.WriteLine("How are you feeling today?");
feelingToday = Console.ReadLine();

Console.WriteLine($"{name} from class {klass} is feeling {feelingToday} today.");
Console.ReadLine();