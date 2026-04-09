Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Lavinha🥑Good🍆Vibe🍒");
Console.WriteLine("Calculadora de IMC");
/*----------------------------------------------------------------------------------------------
 
                Criação de Variaveis
 
 ----------------------------------------------------------------------------------------------*/
float peso, altura, imc=0;
Console.Write("Digite o seu peso: ");
float.TryParse(Console.ReadLine()!.Replace(".",","), out peso);
Console.Write("Digite o seu altura: ");
float.TryParse(Console.ReadLine()!.Replace(".", ","), out altura);
imc = (float)(peso / Math.Round(Math.Pow(altura, 2),2));
//testando a variável com console

/*Abaixo de 18,5: Abaixo do peso (Magreza)
18,5 a 24,9: Peso normal (Eutrofia)
25,0 a 29,9: Sobrepeso (Excesso de peso)
30,0 a 34,9: Obesidade Grau I
35,0 a 39,9: Obesidade Grau II
40,0 ou mais: Obesidade Grau III (Obesidade Mórbida) 
*/
if (imc <= 18.50)
{
    Console.WriteLine("Abaixo do peso (Magreza)");
}
else if (imc <= 24.99)
{
    Console.WriteLine("Peso normal (Eutrofia)");
}
else if (imc <= 29.99)
{
    Console.WriteLine("Sobrepeso (Excesso de peso)");
}
else if (imc <= 34.99)
{
    Console.WriteLine("Obesidade Grau I");
}
else if (imc <= 39.9)
{
    Console.WriteLine("Obesidade Grau II");
}
else if (imc <= 40)
{
    Console.WriteLine("Obesidade Grau III (Obesidade Mórbida)");
}

Console.WriteLine(imc);




