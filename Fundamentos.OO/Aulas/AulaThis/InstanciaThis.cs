using System;
using Fundamentos.OO.Aulas.AulaThis.Entities;

namespace Fundamentos.OO.Aulas.AulaThis
{
    public class InstanciaThis : AulaAbstract
    {
        public InstanciaThis()
        {
            this.Titulo = "Instância e operador this";
        }

        public override void InicializarExemplo()
        {
            var pessoa = new Pessoa("Luis");

            pessoa.AdotarAnimal();
        }
    }
}