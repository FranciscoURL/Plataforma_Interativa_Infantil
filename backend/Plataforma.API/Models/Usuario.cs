namespace Plataforma.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string SenhaHash { get; set; }
        public required string Papel { get; set; } // pai, professor, admin, especialista
    }
}
