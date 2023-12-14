namespace israel_benvindo.Models
{
    public class Pagamento
    {
        public int PagamentoId {get; set;}
        public DateTime DataLimite {get; set;}
        public double Valor {get; set;}
        public bool Pago {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}