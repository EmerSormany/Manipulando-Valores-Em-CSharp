# Manipulando-Valores-Em-CSharp
Este repositório é um resumo da aula sobre manipulação de valores do Bootcamp Decola Tech 2024 da DIO.me

### Manipulando Valores com C#

#### Concatenação de strings

É a manipulação de dados do tipo string com o operador de soma (+) e pode ser usada para criar um novo valor com a junção dos valores anteriores. Em sua sintaxe, cada valor manipulado precisará estar entre aspas duplas, contendo o sinal '+' entre eles, ou se os valores forem variáveis, não precisa das aspas, mas é preciso que pelo menos 1 delas seja do tipo string. Se for um valor numérico como double ou int, por exemplo, o '+' vai assumir o papel de somar e não de concatenar, realizando a operação matemática entre os números.

Existe também a interpolação de string, que em sua sintaxe terá o sinal de cifrão seguido de aspas duplas, e dentro das aspas o texto que desejas exibir, e as variáveis que você desejar que seus valores façam parte da string deverão ser colocadas entre chaves. A string será gerada sem aparecer o sinal de cifrão, as chaves e onde as variáveis foram colocadas aparecerão os seus valores. Dentro das chaves também é possível realizar operações matemáticas, como somar valores.

#### Formatando Valores Monotários

Utilizando a interpolação de string é possível formatar valores monetários, utilizando dois pontos dentro das chaves e depois do valor; após os dois pontos, coloca-se a letra 'C'. Isso acontece porque o C# entende que a sintaxe $"{valor:c}" é uma formatação de moeda e irá retornar o valor de acordo com o padrão de moeda da cultura que a máquina na qual está rodando o sistema está configurada.

É possível fazer com que o sistema funcione para uma determinada cultura independente da configuração da máquina utilizando a classe CultureInfo do namespace 'System.Globalization', e passando como argumento para a classe a cultura que desejar, por exemplo, 'pt-BR'. A sintaxe desse modo fica: CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"). Mas isso tem uma desvantagem porque amarra a cultura do sistema todo em uma só.

Também é possível realizar uma formatação específica para um valor utilizando o método ToString, passando como primeiro argumento o 'c' de currency (moeda), como string, e o segundo argumento o método CreateSpecificCulture, da classe CultureInfo, e como argumento desse método, o valor que representa a cultura 'en-US'. Assim, mesmo o sistema tendo a cultura amarrada, é possível formatar um valor específico. A sintaxe desse modo fica: 'valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))'.

Com o ToString também é possível, tendo previamente padronizado uma cultura para o sistema com o 'CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR")', fazer uma formatação personalizada, especificando quantas casas decimais ele vai exibir, passando 'C1' como argumento para o ToString, no qual o 'C' é de currency e o número indica quantas casas deseja exibir.

#### Represetando Porcentagem

Com o ToString também é possível representar porcentagem, utilizando o dado do tipo double com valor iniciado por ponto e após o ponto o valor de porcentagem desejado. Por exemplo: 'valor = .321', e a sintaxe com ToString fica 'valor.ToString("P")', o retorno será de 32,100%. Também é possível configurar quantas casas decimais são desejadas adicionando o número após o 'P', 'valor.ToString("P1")' retornará '32,1%'.

#### Formatando DateTime

O ToString também possibilita a formatação de data, utilizando um formato desejado e aceito de acordo com a documentação do C#. Por exemplo, devemos passar como argumento no ToString os formatos: 'dd-MM-yy HH:mm' ou 'dd-MM-yy' ou 'HH:mm', dentre muitos outros.

Também é possível utilizar os métodos ToShortDateString e ToShortTimeString, que retornarão apenas a data e apenas a hora, respectivamente.

É possível realizar a conversão de dados do tipo string para DateTime, utilizando o método Parse ou TryParse.

E existe também o TryParseExact, que possibilita converter dados string para DateTime, mas com a vantagem de você poder especificar exatamente o formato que a string deve ter para ser convertida corretamente. O TryParseExact não lança uma exceção se a conversão falhar. Em vez disso, ele retorna um booleano indicando se a conversão foi bem-sucedida ou não. O primeiro argumento é a string que será convertida em DateTime, o segundo é o formato exato da data string que será convertida, o terceiro é a cultura desejada, se não for explicitada ele usa a cultura atual (da máquina ou definida no sistema), o quarto argumento é o estilo da data.




