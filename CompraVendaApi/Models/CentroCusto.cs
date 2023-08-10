using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class CentroCusto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int centro_custo_id { get; set; }

        public int? centro_custo_parent_id { get; set; }
        public CentroCusto? centro_custo_parent { get; set; }

        public string codigo { get; set; }

        public string designacao { get; set; }

        public string? notas { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; } = true;

        public bool apagado { get; set; }

        public List<CentroCusto>? centro_custo_parents { get; set; }
        
    }
}
