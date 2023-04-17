using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentApp.Model
{
    public class FlatModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_flat { get; set; }   
        public string flat_number { get; set; }
        public int id_rent { get; set; }
        [ForeignKey("rents_id")]
        public RentAmount Rent { get; set; }
        

        public ICollection<TenantModel> Tenants { get; set; }

        public int GetId()
        {
            return id_flat;
        }
    }
}
