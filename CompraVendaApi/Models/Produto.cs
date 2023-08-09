using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CompraVendaApi.Models
{
    public class Produto
    {
        [Key]
        public int product_id { get; set; }

        public string codigo { get; set; }

        public string codigo_barra { get; set; }

        public string descricao { get; set; }

        public int imposto_id { get; set; }

        [JsonIgnore]
        public Imposto? Imposto { get; set; }

        public int marca_id { get; set; }

        [JsonIgnore]
        public Marca? Marca { get; set; } 

        public int categoria_id { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; } 

        public int apresentacao_id { get; set; }

        [JsonIgnore]
        public Apresentacao? Apresentacao { get; set; } 

        public decimal preco { get; set; }

        public decimal preco_custo { get; set; }

        public bool bundle { get; set; }

        public bool controla_serial_no { get; set; }

        public bool move_stock { get; set; }

        public bool tipo_artigo { get; set; }

        public List<ProdutoBundle>? product_bundle { get; set; } 

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; }

        public bool apagado { get; set; }
    }
}
