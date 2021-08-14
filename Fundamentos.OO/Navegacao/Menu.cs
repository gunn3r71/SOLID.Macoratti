using System;
using System.Collections.Generic;
using Fundamentos.OO.Aulas;
using Fundamentos.OO.Aulas.AulaClasses;

namespace Fundamentos.OO.Navegacao
{
    public static class Menu
    {
        private static Dictionary<int, AulaAbstract> _aulas = new Dictionary<int, AulaAbstract>{
            {1, new ClassesObjetos()}
        };

        public static void ExibirOpcoes()
        {
            foreach (var aula in _aulas)
            {
                Console.WriteLine($"{aula.Key} - {aula.Value.Titulo}");
            }
            Console.WriteLine("0 - SAIR");
            Console.Write("> ");
        }

        public static void AcessarExemploAula(int aulaId) 
        {
            if (_aulas.TryGetValue(aulaId, out AulaAbstract aula))
            {
                aula.InicializarExemplo();
            } 
            else 
            {
                Console.WriteLine($"A aula {aulaId} não foi encontrada.");
            }
        }

        public static void Sair()
        {
            Console.WriteLine("Saindo da aplicação...");
            Environment.Exit(0);
        }
    }
}