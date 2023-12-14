namespace israel_benvindo.Models
{
    public class Cliente
    {
        public int ClienteId {get; set;}
        public string? Nome {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}