using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public bool IsDelete { get; set; }
    }
}
