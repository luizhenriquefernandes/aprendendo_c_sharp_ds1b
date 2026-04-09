Console.OutputEncoding = System.Text.Encoding.UTF8;
int ponto = 0;

for (int i = 0; i < 10;i++){
    Console.WriteLine("Vai socar a Isis? [s/n]");
    string s = Console.ReadLine()!;
    if (s == "s")
    {
        ponto++;
        Console.WriteLine("O soco na Issis foi bem suceddido 🤜🔥🔥🔥🤩🥵😵‍💫😵");
    }


}
Console.WriteLine($"O total de pontos é: {ponto}");