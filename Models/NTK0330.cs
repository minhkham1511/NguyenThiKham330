using System.ComponentModel.DataAnnotations;

namespace NguyenThiKham330.Model
{

public class NTK0330
{
    [Key]
     [StringLength(20)]
    public int UniversityId { get; set; }
    [StringLength(50)]
    public string? UniversityName { get; set; }
}
}