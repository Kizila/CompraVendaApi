using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Fornecedor_Encomenda
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int encomenda_fornecedor_id { get; set; }

        public int documento_id { get; set; }

        public int loja_id { get; set; }

        public int armazem_id { get; set; }

        public int fornecedor_id { get; set; }

        public int moeda_id { get; set; }

        public int? tipo_pagemento_id { get; set; }

        public string documento_referencia { get; set; }

        public int documento_numero { get; set; }

        public int? documento_ano { get; set; }

        public int documento_cambio { get; set; }

        public int documento_estado { get; set; }

        public string documento_data { get; set; }

        public decimal documento_total_mercadoria { get; set; }

        public decimal documento_total_imposto { get; set; }

        public decimal documento_total_desconto { get; set; }

        public decimal documento_total_valor { get; set; }

        public string? notas { get; set; }

        public bool activo { get; set; } = true;

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool apagado { get; set; }

        
    }
}
