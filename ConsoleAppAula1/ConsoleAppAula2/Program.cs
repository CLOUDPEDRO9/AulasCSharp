//Se o aluno tiver mais que 3 faltas
//rodo

//se a noto do aluno for menor q 60
//rodo

/*
int nota;
int faltas;
string acao;

while (true)
{

    Console.WriteLine("Informe a nota");
    nota = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe as faltas");
    faltas = Convert.ToInt32(Console.ReadLine());


    if (nota >= 60 && faltas <= 3)
    {
        Console.WriteLine("Aprovado");
    }
    else { Console.WriteLine("Reprovado"); }

    Console.WriteLine("Deseja continuar colocando as notas? s/n");
    acao = Console.ReadLine();

    if (acao != "s")
    {
        break;
    }
    else Console.Clear();

}
*/

#region Estrutura de Repeticao

//FOR
/*
int contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada:");
tabuada = Convert.ToInt32(Console.ReadLine()); 

for(contador = 0; contador < 11; contador++)
{
    Console.WriteLine(
        $"{tabuada} X {contador} = {tabuada * contador}");
}
*/

//WHILE
/*
int contador = 0;

while(contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do{

    Console.WriteLine(contador);
    contador++;

} while(contador < 10);
*/

//Foreach
/*
string[] nomes = { "Abacaxi", "Maça", "Banana" };
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int i in numeros)
{
    Console.WriteLine(i);
}

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);



int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);
Console.WriteLine(numeros[3]);
Console.WriteLine(numeros[4]);
Console.WriteLine(numeros[5]);
Console.WriteLine(numeros[6]);
Console.WriteLine(numeros[7]);
Console.WriteLine(numeros[8]);
Console.WriteLine(numeros[9]);

Console.ReadKey();
*/
/*
string[] cores = { "Vermelho", "Rosa", "Laranja", "Verde" };

foreach (string i in cores)
{
    Console.WriteLine(i);
}

Console.ReadKey();
*/

//Bool
/*
int idadeAluno;

bool MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MaiorDeIdade2(int idade)
{
    if (idade >= 18)
    {
        Console.WriteLine("aluno maior de idade");
    }
    else
    {
        Console.WriteLine("Aluno menor de idade");
    }
}

MaiorDeIdade2(15);

Console.WriteLine("Informe sua idade");
idadeAluno= Convert.ToInt32(Console.ReadLine());

if(MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de idade");
}
else { Console.WriteLine("Aluno menor de idade"); }
*/

//Função para somar do tipo Void

void Somar (int num, int num2)
{
    Console.WriteLine (
        $"soma dos valores : {num + num2}");
}
Somar(10, 20);
Somar(100, 200);


//Função que retorne a multiplicação Resulatdo int

int Multiplicacao(int numb, int numb2)
{
    return numb * numb2;
}

int resultado = Multiplicacao(10, 10);
resultado = Multiplicacao(100, 100);

#endregion