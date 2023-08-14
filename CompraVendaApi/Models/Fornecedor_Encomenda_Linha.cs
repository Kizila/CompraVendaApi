using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Fornecedor_Encomenda_linha
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int encomenda_fornecedor_linha_id { get; set; }

        public int encomenda_fornecedor_id { get; set; }
        
        public Fornecedor_Encomenda? encomenda_fornecedor { get; set; }
        
        public int? produto_id { get; set; }
        
        public Produto? produto { get; set; }
        
        public int? imposto_id { get; set; }
        
        public Imposto? imposto { get; set; }
        
        public int? apresentacao_id { get; set; }
        
        public Apresentacao? apresentacao { get; set; }
        
        public int? qtd_apresentacao { get; set; }
        
        public decimal? preco { get; set; }

        public decimal? desconto_cabecalho { get; set; }

        public decimal? desconto1 { get; set; }
        
        public decimal? desconto2 { get; set; }

        public decimal? impostoValor { get; set; }

        public decimal? total_desconto { get; set; }

        public decimal? total_imposto { get; set; }

        public decimal? total_mercadoria { get; set; }

        public decimal? total_valor { get; set; }

        public string? comentario { get; set; }

        public int? estado_entrega { get; set; }

        public short order { get; set; }
        
        public bool activo { get; set; } = true;

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool apagado { get; set; }

        
    }
}
