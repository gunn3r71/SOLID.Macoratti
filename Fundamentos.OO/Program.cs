using System;
using Fundamentos.OO.Navegacao;

namespace Fundamentos.OO
{
    class Program
    {
        private static readonly int SAIR = 0;
        
        static void Main(string[] args)
        {
            while(true) 
            {
                Menu.ExibirOpcoes();
                var opcaoSelecionada = int.Parse(Console.ReadLine());  

                if(opcaoSelecionada == SAIR) Menu.Sair();
        
                Menu.AcessarExemploAula(opcaoSelecionada);
            }
        }
    }
}
