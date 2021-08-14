namespace Fundamentos.OO.Aulas.AulaClasses.Entities
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; private set; }

        public override string ToString()
        {
            return $"Olá, meu nome é {this.Nome}";
        }       
    }
}