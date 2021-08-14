using System;
using Fundamentos.OO.Aulas.AulaClasses.Entities;

namespace Fundamentos.OO.Aulas.AulaClasses
{
    public class ClassesObjetos : AulaAbstract
    {
        public ClassesObjetos()
        {
            this.Titulo = "Classes e objetos";
        }
        
        public override void InicializarExemplo()
        {
            Console.Write("Olá, por favor, digite seu nome e sobrenome: ");
            var nomeCompleto = Console.ReadLine().Split(" ");

            var pessoa = new Pessoa(nome: nomeCompleto[0], sobrenome: nomeCompleto[1]);

            Console.WriteLine(pessoa);
        }
    }
}