
namespace AkarSoftware.Parking.Core.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get ; set ; } // PK
        public bool IsActive { get ; set ; }
        public DateTime CreatedDate { get ; set ; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
