using System.ComponentModel.DataAnnotations;



namespace SleighList.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string? Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

    }
}


