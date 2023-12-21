

using System.Globalization;

// concatenação de string com operador '+'
Console.WriteLine("Hello, " + "World!");

// interpolação de string
string nome = "Sormany";
int idade = 29;
Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos. Em 2 meses completarei {idade+1} anos.");

// Formatando Valores Monetários
Console.WriteLine($"Amanhã vou comprar carne. Ela custou {29:C} da última vez.");

// Definindo padrão de cultura para o sistema todo
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{29:c}"); // retorno será $29.00

// Fortamando cultura específica, mesmo com uma cultura padrão estabelecida para o sistema utilizando ToString
int valorMonetario = 29;
string valorAtualizado = valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("pt-BR"));
Console.WriteLine(valorAtualizado); // retorno será R$ 29,00

// exibindo valor com casas decimais específicas utilizando o ToString
Console.WriteLine(valorMonetario.ToString("C4"));

// formatando porcentagem com ToString
double porcento = .321;
Console.WriteLine(porcento.ToString("P")); // retona 32.100%
Console.WriteLine(porcento.ToString("P1")); // retorna 32.1%

// Manipulando data e hora com ToString
DateTime data = DateTime.Now; 
Console.WriteLine(data); // vai exibir a data pura conforme o modelo de cultura configurado no sistema na linha 17 '12/21/2023 1:17:30 PM'
                         // se não houvesse essa configuração exibiria a data e a hora de acordo com a cultura da máquina.
Console.WriteLine(data.ToString("dd-MM-yy HH:mm")); // vai exibir 21-12-23 13:17
Console.WriteLine(data.ToString("dd-MM-yy")); // vai exibir 21-12-23
Console.WriteLine(data.ToString("HH:mm")); // vai exibir 13:17

// Capturando apenas a data
Console.WriteLine(data.ToShortDateString()); // vai exibir 12/21/2023; padrão de cultura definido na linha 17
// Capturando apenas a hora
Console.WriteLine(data.ToShortTimeString()); // vai exibir 1:22 PM; padrão de cultura definido na linha 17

// Convertendo String em DateTime com Parse
DateTime dataString = DateTime.Parse("02/27/1994 18:00");
Console.WriteLine(dataString);

// Convertendo String em DateTime com TryParse
bool dataConvertida = DateTime.TryParse("02/27/1994 18:00", out DateTime result); // Padrão de cultura definido na linha 17
Console.WriteLine(dataConvertida);
Console.WriteLine(result);

// Validando conversão com TryParse
dataConvertida = DateTime.TryParse("22/27/1994 18:00", out DateTime resultado);
if (!dataConvertida)
{
    Console.Write("Data inválida"); // vai entrar no condicionar e exibir que a cada é inválida
} else
{
    Console.WriteLine(resultado);
}

Console.WriteLine(" ");

// Convertendo String com TryParseExact
bool conversaoComTryParseExact = DateTime.TryParseExact(
    "27/02/1994 18:00", "dd/MM/yyyy HH:mm", 
    CultureInfo.InvariantCulture, DateTimeStyles.None , out DateTime novaData 
);
Console.WriteLine(novaData);

// Validando conversão com TryParseExact
if (!conversaoComTryParseExact)
{
    Console.Write("Data inválida"); 
} else
{
    Console.WriteLine(novaData); // Conversão vai funcionar e exibir a data
}

conversaoComTryParseExact = DateTime.TryParseExact(
    "27/02/1994 18:00", "DD/MM/yyyy HH:mm", 
    CultureInfo.InvariantCulture, DateTimeStyles.None , out DateTime dataNaoConvertida 
);

if (!conversaoComTryParseExact)
{
    Console.Write("Data inválida"); // Conversão não vai funcionar e vai entrar no condicional
} else
{
    Console.WriteLine(dataNaoConvertida);
}