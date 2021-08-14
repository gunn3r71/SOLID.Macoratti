namespace Fundamentos.OO.Aulas.AulaThis.Entities
{
    public class Animal
    {
        public Animal(string nome, Pessoa dono)
        {
            Nome = nome;
            Dono = dono;
        }

        public string Nome { get; private set; }
        public Pessoa Dono { get; private set; }
    }
}