using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace RentApp.Model
{
    public class RentAmount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_rent { get; set; }
        public int rent_fee { get; set; }
        public int disposal_fee { get; set; }
        public int water_fee { get; set; }
        public int shared_electricity_fee { get; set; }

        public ICollection<FlatModel> Flats { get; set; }

        public int GetWholeRent()
        {
            int WholeRent = rent_fee + disposal_fee + water_fee + shared_electricity_fee;
            return WholeRent;
        }
    }
}
