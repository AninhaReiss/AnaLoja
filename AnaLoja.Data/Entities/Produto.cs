namespace AnaLoja.Data.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao{ get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}