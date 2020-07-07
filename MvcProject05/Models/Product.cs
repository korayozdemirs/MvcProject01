using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProject05.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim Alanı Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "En fazla 50 araba da 5")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fiyat Alanı Boş Geçilemez")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok Alanı Boş Geçilemez")]
        [Range(5, 50, ErrorMessage = "5 ile 50 araında olmalı")]
        public int UnistInStock { get; set; }

        public bool Ready { get; set; }
    }
}