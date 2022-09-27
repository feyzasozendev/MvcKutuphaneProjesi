using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }   //açıklama satırı

        public bool CategoryStatus { get; set; } //durum olarak çevirebilinir.İlişkili tablolarda silme işlemi gerçekleşmeyeceği için akif yada pasif yapmak için kullanacağız

        public ICollection<Heading> Headings { get; set; }
    }
}
