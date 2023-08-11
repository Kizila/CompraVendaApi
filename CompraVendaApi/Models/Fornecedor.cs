using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Fornecedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fornecedor_id { get; set; }

        public int entidade_id { get; set; }

        public Entidade? entidade { get; set; }
        
        public int? imposto_id { get; set; }

        [JsonIgnore]
        public Imposto? imposto { get; set; }
        
        public int? condicoes_pagemento_id { get; set; }

        public string codigo { get; set; }
        
        public decimal? saldo_actual { get; set; }

        public decimal? saldo_limite { get; set; }

        public decimal? desconto { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; } = true;

        public bool apagado { get; set; }

        
    }
}
