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
            Console.Write("Olá, por favor, digite seu nome: ");
            var nome = Console.ReadLine();

            var pessoa = new Pessoa(nome: nome);

            Console.WriteLine(pessoa);
        }
    }
}