namespace TRC.Core.Modelo
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estado_Id { get; set; }
        public Estado EstadoNavegation { get; set; }
    }
}
