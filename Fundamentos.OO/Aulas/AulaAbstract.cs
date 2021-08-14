namespace Fundamentos.OO.Aulas
{
    public abstract class AulaAbstract
    {
        public string Titulo { get; protected set; }
        
        public abstract void InicializarExemplo();
    }
}