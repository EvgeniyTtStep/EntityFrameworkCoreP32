using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreP32;


[Table("Toyotas")]
public class Toyota
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("IdToyotaNew")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(150)]
    [Column("ToyotaNameNew")]
    public string Name { get; set; }
    
    [Column("ReleaseDateNew")]
    public DateTime? ReleaseDate { get; set; }
    
    public Engine? Engine { get; set; }
}