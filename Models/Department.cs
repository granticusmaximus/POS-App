using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pos_app.Models
{
    public class Department
    {
        [Key]
        public int DeptID {get;set;}
        public string DeptTitle {get;set;}
        [ForeignKey("Product")]
        public int ProdID {get;set;}
        public Product Product {get;set;}
        public IEnumerable<Product> Products {get;set;}
    }
}