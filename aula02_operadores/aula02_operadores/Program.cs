// See https://aka.ms/new-console-template for more information
/*
 * Console.OutputEncoding = System.Text.Encoding.UTF8;
Por que isso acontece?
Codificação de Saída: O console precisa saber que você está enviando 
caracteres especiais. Sem o comando acima, ele tenta converter o emoji 
em um caractere simples, resultando em um quadrado □ ou uma interrogação ?.
Fonte do Terminal: Além do código, a fonte escolhida no terminal (como Consolas ou 
Lucida Console) precisa ter o desenho do emoji. Fontes mais modernas como Cascadia 
Code ou JetBrains Mono funcionam melhor.
Configuração do Visual Studio: 
Notei pela sua imagem que você está nas opções de 
"Terminal". No Windows 10 e 11, o Terminal do Windows (mais moderno) lida muito melhor com emojis do que o antigo cmd.exe.
 */
//permite usar emoji no terminal
Console.OutputEncoding = System.Text.Encoding.UTF8;
//declaração de variáveis
float celsius, resultado;
//exibe ###### no terminal
Console.WriteLine("###########################################");
// exibe a mensagem para o usuário
Console.WriteLine("Convesor de Célcius C° para Fahrenheit F°🔥🌡️🌡️" +
    "\n Digite o Valor em Cº: ");
//tipo.tentativa de análise, leitura de variável, e atribui para a variável celsius
// converte o valor digitado e atribui para a variável celsios convertido em float
float.TryParse(Console.ReadLine(), out celsius);
/*a variável resultado terá uma conta aritmética
 resultado = (37*9/5)+32
 */
resultado = (celsius * 9 / 5) + 32;
Console.WriteLine($"A Converção de C°{celsius}°: é Fº: {resultado}🤒");

