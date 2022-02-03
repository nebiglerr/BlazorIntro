using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ürün adı gereklidir")]
        [StringLength(20, ErrorMessage ="Max karakter aşıldı")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Açıklama adı gereklidir")]
        [StringLength(40, ErrorMessage = "Max karakter aşıldı")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ürün kategorisi gereklidir")]
        public int CategoryId { get; set; }
    }
}
