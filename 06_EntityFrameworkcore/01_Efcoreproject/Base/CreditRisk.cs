using System.ComponentModel.DataAnnotations;

namespace Efcoreproject.Base
{
    public class CreditRisk : EntityBase
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
    }
}