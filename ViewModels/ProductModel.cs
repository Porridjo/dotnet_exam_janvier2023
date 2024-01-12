using ExamJanvier2023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamJanvier2023.ViewModels
{
    class ProductModel : INotifyPropertyChanged
    {
        private readonly Product _product;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


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

        public bool Discontinued
        {
            get { return _product.Discontinued; }
            set
            {
                _product.Discontinued = value;
                OnPropertyChanged(nameof(Discontinued));
            }
        }
    }
}
