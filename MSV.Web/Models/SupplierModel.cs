using CMC.MSV.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CMC.Northwind.Models
{
    public class SupplierModel
    {
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string ContactTitle { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Region { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Fax { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string HomePage { get; set; }

        public IList<Product> Products { get; set; }

        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string Sort { get; set; }
        public bool IsAsc { get; set; }
        public IList<Supplier> Suppliers { get; set; }

        public SupplierModel()
        {
            TotalPages = 0;
            CurrentPage = 0;
            PageSize = 0;
            PageIndex = 0;
            Suppliers = new List<Supplier>();
        }
    }
}
