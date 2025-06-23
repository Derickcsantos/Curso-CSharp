//  Conhecimentos básicos de C#

// Declaração de variaveis / Tipos de dados
string nome = "Dérick";
int idade = 20;
double altura = 1.80;
decimal salario = 2500.50m;
bool ativo = true;

// Exibição de dados
// Como utilizar console, e como exibir mensagens no terminal
Console.WriteLine($"Olá, {nome}! Você tem {idade} anos, mede {altura} metros, recebe um salário de {salario:C} e o status é ativo: {ativo}.");

// Para rodar, escreva "dotnet run" no terminal
// Para compilar, escreva "dotnet build" no terminal

//-------------------------------------------------------------------------------------------------------------

//Como criar funções em c#
// Função que recebe dois números e retorna a soma
int Somar(int a, int b)
{
    return a + b;
}

// Função que recebe dois números e retorna a subtração
int Subtrair(int a, int b)
{
    return a - b;
}       

// Função que recebe dois números e retorna a multiplicação
int Multiplicar(int a, int b)
{
    return a * b;
}

// Função que recebe dois números e retorna a divisão
double Dividir(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Divisão por zero não é permitida.");
    }
    return (double)a / b;
}

// Exemplo de uso das funções
Console.WriteLine($"Soma: {Somar(10, 5)}");
Console.WriteLine($"Subtração: {Subtrair(10, 5)}");
Console.WriteLine($"Multiplicação: {Multiplicar(10, 5)}");
Console.WriteLine($"Divisão: {Dividir(10, 5)}");

//--------------------------------------------------------------------------------------------------------------

// Exercicio de pegar notas e retornar a média

double calcularMedia(double nota1, double nota2, double nota3){
    double soma = nota1 + nota2 + nota3;
    return soma / 3;
}

calcularMedia(7.5, 8.0, 9.0);
Console.WriteLine($"A média do aluno {nome} é {calcularMedia(7.5, 8.0, 9.0)}");