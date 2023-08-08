using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class ProdutoBundle
    {
        [Key]
        public int product_id_bundle { get; set; }

        public int product_id_bundle_include { get; set; }

        public int product_id { get; set; }

        public Produto Produto { get; set; }

        public string codigo_bundle { get; set; }

        public string descricao_bundle { get; set; }

        public decimal preco { get; set; }

        public int quantidade { get; set; } = 1;

        public DateTime criado_data { get; set; }

        public string criado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public string atualizado_user { get; set; }

        public bool activo { get; set; }

        public bool apagado { get; set; }
    }
}
