//Imagine que você trabalha para uma fábrica e precisa fazer um inventário do depósito para determinar o número atual de produtos finais que estão prontos para o envio. Além do número total de produtos finais, você também pode querer imprimir uma contagem e o total atual de cada compartimento individual do depósito em que os produtos finais são armazenados. Imprimir esse total atual criaria uma trilha de auditoria para verificar novamente o trabalho e identificar reduções.

//Executar um loop em uma matriz usando o foreach

string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}




//Criar e inicializar uma matriz de int

int[] inventory = { 200, 450, 700, 175, 250 };


//Adicionar uma instrução foreach para iterar na matriz

int[] inventory = { 200, 450, 700, 175, 250 };

foreach (int items in inventory)
{

}




//Adicionar uma variável para somar o valor de cada elemento na matriz

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}





//Exibir o valor final da soma

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");





//Criar uma variável para armazenar o número do compartimento atual e exibir o total atual

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");




