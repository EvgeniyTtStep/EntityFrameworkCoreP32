using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EntityFrameworkCoreP32;

[Table("Engines")]
public class Engine
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(250)]
    public string Name { get; set; }
    
    List<Toyota> Toyotas { get; set; }
}