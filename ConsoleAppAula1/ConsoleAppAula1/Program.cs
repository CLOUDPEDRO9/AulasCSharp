/* Idade  
/int idade;
//Console.WriteLine("Informe sua idade!");

//idade = Convert.ToInt32(
//    Console.ReadLine());


//if (idade >= 18)
//{
//    Console.WriteLine($"Sua idade {idade}, você é maior de idade");
//} 
//else
//{
//    Console.WriteLine($"Sua idade {idade}, Você é menor de idade");
//}

//   Console.WriteLine($"Sua idade é {idade}");

*/

/* Salário 
//SAlário mínimo ou salário comum

//const decimal salarioMinimo = 1518m;

//Console.WriteLine("Digite seu salario: R$");
//decimal salarioFuncionario = decimal.Parse(Console.ReadLine());

//if (salarioFuncionario == salarioMinimo)
//{
//    Console.WriteLine($"O funcionario recebe o salário mínimo. {salarioFuncionario:C}");
//}
//else
//{
//    Console.WriteLine($"O funcionario NÃO recebe o salário minimo. {salarioFuncionario:C}");
//}
*/

float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;
string opcao;

while (true)
{

    Console.WriteLine("Informe a operação matemática:\n" +
        "+ ou - ou * ou /");
    operacaoMatematica = Console.ReadLine();

    Console.WriteLine("Informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Informe o segundo valor");
    num2 = float.Parse(Console.ReadLine());

    #region Estrutura IF
    /* ...
    //Soma
    if (operacaoMatematica == "+")
    {
        Console.WriteLine($"Soma: {(num1 + num2):F2}");

    }
    //Multiplicação
    else if (operacaoMatematica == "*")
    {
        Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
    }
    //Divisão
    else if (operacaoMatematica == "/")
    {
        Console.WriteLine($"Divisão: {(num1 / num2):F2}");
    }
    //Subtração
    else if (operacaoMatematica == "-")
    {
        Console.WriteLine($"subtração: {(num1 - num2):F2}");
    }
    else { Console.WriteLine("Operação inválida");  }
    */
    #endregion

    switch (operacaoMatematica)
    {
        case "+":
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;

        case "-":
            Console.WriteLine($"Subtração: {(num1 - num2):F2}");
            break;

        case "/":
            Console.WriteLine($"Divisão: {(num1 / num2):F2}");
            break;

        case "*":
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
            break;

        default:
            Console.WriteLine("Informe uma opção válida!");
            break;
    }

    Console.WriteLine("Deseja continuar s/n");
    opcao = Console.ReadLine();

    if ( opcao != "s" )
    {
        break;
    }else { Console.Clear(); }
}
