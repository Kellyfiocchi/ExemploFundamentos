using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
         public required string  Nome { get; set; }
      
         public required int Idade { get; set; }
       
        public required string Sobrenome  { get; set; }

        public required string Profissao { get; set; }

        public required string Hobby { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! meu nome é {Nome} {Sobrenome}, e tenho {Idade} anos,\n sou {Profissao} e gosto muito de {Hobby}");
        }
    }
}