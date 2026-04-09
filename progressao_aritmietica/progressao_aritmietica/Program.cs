Console.OutputEncoding = System.Text.Encoding.UTF8;
//variaveis
int termos, t1 = 0, t2 = 1, t3 = 0 ;
Console.Write("Digite o nº de Termos: ");
int.TryParse(Console.ReadLine()!, out termos);
//Console.Write("Digite o nº do Salto: ");
//int.TryParse(Console.ReadLine()!, out salto);
Console.Write($"{t1}➡️{t2}➡️");
for (int i = 1; i <= termos; i++)
{
    t3 = t1 + t2;
    t1 = t2;
    t2 = t3;
      
    Console.Write($"{t3}➡️");
}
Console.Write("😡🤯");


