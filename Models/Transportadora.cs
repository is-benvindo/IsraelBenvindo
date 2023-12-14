namespace israel_benvindo.Models
{
    public class Transportadora
    {
        public int TransportadoraId {get; set;}
        public string? Nome {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}