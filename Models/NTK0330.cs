using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiKham330.Model
{

public class NTK0330
{
    [Key]
     [StringLength(20)]
    public int NTKId { get; set; }
    [StringLength(50)]
    public string? NTKName { get; set; }
      public Boolean NTKGender {get; set;}

}
}