using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_CRUD_Departamentos.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        public int Numero { get; set; }

        [Column("DNOMBRE")]
        public String? Nombre { get; set; }

        [Column("LOC")]
        public String? Localidad { get; set; }
    }

}
