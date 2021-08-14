namespace Fundamentos.OO.Aulas.AulaClasses.Entities
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString()
        {
            return $"Olá, meu nome é {this.Nome} {this.Sobrenome}";
        }       
    }
}