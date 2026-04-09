Console.OutputEncoding = System.Text.Encoding.UTF8;
//declarar variáveis
int cont = 0;
Console.WriteLine("Calculadora de Números Primos");
Console.Write("Digite o Número: ");
int.TryParse(Console.ReadLine(), out int primo);
for(int i = 1; i <= primo; i++)
{
    if(primo%i == 0)
    {
        cont++;        
    }
    Console.Write($"{i}➡️");
}
Console.Write("🤩");
if(cont == 2)
{
    Console.WriteLine($"\nO número {primo} é primo");
}
else
{
    Console.WriteLine($"O número {primo} não é primo");
}


