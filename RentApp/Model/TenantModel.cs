using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentApp.Model
{
    public class TenantModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_tenant { get; set; }
        public string tenant_name { get; set; }
        public string tenant_surname { get; set; }
        public int tenant_tel_number { get; set; }
        public int flats_id { get; set; }

        [ForeignKey("flats_id")]
        public FlatModel Flat { get; set; }
        
        public DateTime tenant_ar_date { get; set; }
        public DateTime tenant_ex_date { get; set; }
        public Boolean tenant_is_here { get; set; }

        public int GetId()
        {
            return id_tenant;
        }
    }
}
