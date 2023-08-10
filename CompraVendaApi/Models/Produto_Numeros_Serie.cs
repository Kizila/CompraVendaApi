using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Produto_Numeros_Serie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int produto_numero_serie_id { get; set; }
        
        public int loja_id { get; set; }
        
        [MaxLength(500)]
        public string numero_serie { get; set; }
        
        public int produto_id { get; set; }

        public int origem_id { get; set; }
        
        public int origem_documento_id { get; set; }

        public bool activo { get; set; } = true;

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }
        public bool apagado { get; set; }
        
    }
}
