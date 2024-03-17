using System.ComponentModel.DataAnnotations;

namespace AdsRemedy.Models
{
    public class CreateOrder
    {
        [Key]
        public int CO_Id {  get; set; }
        public string ? User_Name { get; set; }
        public string ? User_Contact { get; set; }
        public string ? CO_Name { get; set; }
        public int ? CO_Qty { get; set; }
        public string ? CO_Size { get; set; }
    }
}
