using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class NivelStock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int nivel_stock_id { get; set; }

        public int armazem_id { get; set; }

        public Armazem? Armazem { get; set; }

        public int quantidade { get; set; }

        public int quantidade_bundle { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; } = true;

        public bool apagado { get; set; }
    }
}
