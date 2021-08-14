namespace Fundamentos.OO.Aulas.AulaThis.Entities
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;    
        }
        
        public string Nome { get; private set; }    

        public void AdotarAnimal()
        {
            var animal = new Animal("Juju", this);
            System.Console.WriteLine($"Agora {animal.Nome} pertence a {animal.Dono.Nome}!");
        }
    }
}