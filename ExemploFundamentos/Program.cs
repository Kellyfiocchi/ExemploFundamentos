﻿using ExemploFundamentos.Common.Models;


Pessoa pessoa1 = new Pessoa()
 {   Nome = "Kelly ",
     Sobrenome = "Fiochi",
      Idade = 34,
      Profissao = "QA",
    Hobby = "Tecnologia"
  };
 pessoa1.Apresentar();



















// Pessoa pessoa2 = new Pessoa()
// {
//     Nome = "Cedric",
//     Sobrenome = "Fiochi",
//     Idade = 5,
//     Profissao = "Estudante",
//     Hobby = "Jogar Ps4"


// };
// pessoa2.Apresentar();



// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);



// double altura = 1.70;

// decimal preco = 10.50M;

// bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);


// DateTime dataAtual = DateTime.Now.AddDays(12);
// Console.WriteLine("dataAtual = " + dataAtual.ToString("dd/MM/yyyy HH:mm"));



// Operação de atribuição


// int a = 10;
// int b = 20;
// int c = a + b;

// //c = c + 5; // 30 + 5

// c *= 5;

// Console.WriteLine(c);


// // Cast - Casting
//  int a = Convert.ToInt32(null);
//  //int a = int.Parse(null);
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);




//int a = 5;
//double b = a;

//Console.WriteLine(b);

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);
//Console.WriteLine(b);

// int a = int.MaxValue;
// long b = Convert.ToInt32(a);

// Console.WriteLine(b);


// double a = 4 / (2 + 2);
// Console.WriteLine(a);



// string a = "15-";

// int b = 0;
// int.TryParse(a, out b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");



// Operador condicional

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade  compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");

// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque!");
// }


// // Apredendendo o switch case

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if(letra == "a"
// || letra == "e"
// || letra == "i"
// || letra == "o"
// || letra == "u")
// {
//     Console.WriteLine("Vogal");

// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }








// }
// else if(letra == "e")
// {
//     Console.WriteLine("Vogal");

// }
// else if(letra == "i")
// {
//     Console.WriteLine("Vogal");

// }
// else if(letra == "o")
// {
//     Console.WriteLine("Vogal");

// }
// else if(letra == "u")
// {
//     Console.WriteLine("Vogal");

// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada Proibida!");
// }




// bool possuiPresencaMinima = true;
// double mediaFinal = 7.5;

// if (possuiPresencaMinima && mediaFinal >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }



// bool choveu = false;
// bool estaTarde = false;

// if (!choveu &&  !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia!");
// }





//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(10, 5);

//calc.Potencia(3, 3);

//  calc.Seno(30);
//  calc.Coseno(30);
//  calc.Tangente(30);
//calc.RaizQuadrada(9);
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento ++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 10;

// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 10");
// numeroDecremento --;
// Console.WriteLine(numeroDecremento);






// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }






// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}* Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }

// }










// int soma = 0, numero = 0;

// do
// {

// Console.WriteLine("Digite um número (0 para parar)");
// numero = Convert.ToInt32 (Console.ReadLine());

// soma += numero;

// } while(numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");











//  string opcao;
// bool exibirMenu = true;

//  while(exibirMenu)
//  {
//      //Console.Clear();
//      Console.WriteLine("Digite a sua opção:");
//   Console.WriteLine("1 - Cadastar cliente");
//    Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();
    
//   switch(opcao)
//  {
//      case "1":
//     Console.WriteLine("Cadastro de cliente");
//        break;

//       case "2":
//        Console.WriteLine("Busca de cliente");
//        break;

//      case "3":
//         Console.WriteLine("Apagar cliente");
//      break;

//        case "4":
//         Console.WriteLine("Encerrando o sistema...");
//        exibirMenu = false;
//        //Environment.Exit(0);
//         break;

//        default:
//       Console.WriteLine("Opção inválida");
//       break;

//    }

//    Console.WriteLine("O programa se encerrou com sucesso!");
//  }


    
