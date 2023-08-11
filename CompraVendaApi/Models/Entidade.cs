using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Entidade
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entidade_id { get; set; }

        public int? segmento_id { get; set; }

        public int tipo_entidade { get; set; }
        
        [StringLength(300)]
        public string codigo { get; set; }

        [StringLength(500)]
        public string designacao { get; set; }

        [StringLength(150)]
        public string contribuinte { get; set; }

        [StringLength(500)]
        public string? morada { get; set; }
        
        [StringLength(100)]
        public string? telefone { get; set; }
        
        public string? email { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; } = true;

        public bool apagado { get; set; }

        public List<Fornecedor>? fornecedores { get; set; }
    }
}
