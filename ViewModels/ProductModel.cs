using ExamJanvier2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamJanvier2023.ViewModels
{
    class ProductModel
    {
        private readonly Product _product;

        public ProductModel(Product current)
        {
            _product = current;
        }

        public int ProductId
        {
            get { return _product.ProductId; }
        }

        public String ProductName
        {
            get { return _product.ProductName; }
        }

        public String ProductCategory
        {
            get 
            {
                if (_product.Category != null)
                {
                    return _product.Category.CategoryName;
                }
                return "";
            }
        }

        public String ProductSupplier
        {
            get
            {
                if (_product.Supplier != null)
                {
                    return _product.Supplier.ContactName;
                }
                return "";
            }
        }
    }
}
