using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Documento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int documento_id { get; set; }

        public int? documento_parent_id { get; set; }
        
        public Documento? documento_parent { get; set; }

        public string codigo { get; set; }

        public string designacao { get; set; }

        public string? notas { get; set; }

        public bool activo { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool apagado { get; set; }

        public List<Documento?> documento_parents { get; set; }

        public List<Fornecedor_Encomenda?> fornecedor_encomendas { get; set; }

    }
}
