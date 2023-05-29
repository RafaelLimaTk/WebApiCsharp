using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductApi.Model.Base;

public class BaseEnity
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
}
