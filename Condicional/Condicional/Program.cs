// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.Write(Console.BackgroundColor = ConsoleColor.Green);
Console.WriteLine("Digite sim ou não [s/n]: ");
int.TryParse(Console.ReadLine(), out int x);
if (x < 5 && x < 10)
{
    Console.WriteLine("Bem vindo therian 🐣🐥");
}
else
{
    Console.WriteLine("Bem vindo Jansen 🧓🪄");
}

