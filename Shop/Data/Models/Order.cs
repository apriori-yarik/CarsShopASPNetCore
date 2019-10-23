using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {

        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "Name's length must be five or more symbols")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [StringLength(25)]
        [Required(ErrorMessage = "Surname's length must be five or more symbols")]
        public string Surname { get; set; }

        [Display(Name = "Address")]
        [StringLength(35)]
        [Required(ErrorMessage = "Address's length must be five or more symbols")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number's length must be at least 10 symbols")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Email's length must be at least 5 symbols")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
