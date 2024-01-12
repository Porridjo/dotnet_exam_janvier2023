using ExamJanvier2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.ViewModels;

namespace ExamJanvier2023.ViewModels
{
    class ProductVM
    {
        private NorthwindContext dc = new NorthwindContext();

        private ObservableCollection<ProductModel> _ProductsList;
        private ObservableCollection<GroupingModel> _ProductsCountList;
        private ProductModel _selectedProduct;
        private DelegateCommand _abandonCommand;

        public ObservableCollection<ProductModel> ProductsList
        {
            get { return _ProductsList = _ProductsList ?? loadProducts(); }
        }

        public ObservableCollection<GroupingModel> ProductsCountList
        {
            get { return _ProductsCountList = _ProductsCountList ?? loadProductsCount(); }
        }

        public ObservableCollection<GroupingModel> loadProductsCount()
        {
            ObservableCollection<GroupingModel> localCollection = new ObservableCollection<GroupingModel>();
            var query = from Product p in dc.Products.AsEnumerable()
                        where p.OrderDetails.Any()
                        group p by p.Supplier.Country into groupedProducts
                        orderby groupedProducts.Count() descending
                        select new
                        {
                            Country = groupedProducts.Key,
                            ProductCount = groupedProducts.Count()
                        };

            foreach (var item in query)
            {
                localCollection.Add(new GroupingModel(item.Country, item.ProductCount));
            }
            return localCollection;
        }

        public ObservableCollection<ProductModel> loadProducts()
        {
            ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
            foreach (var item in dc.Products)
            {
                if (!item.Discontinued)
                {
                    localCollection.Add(new ProductModel(item));
                }
                
            }
            return localCollection;
        }

        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }
        }

        public DelegateCommand AbandonCommand
        {
            get { return _abandonCommand = _abandonCommand ?? new DelegateCommand(AbandonProduct); }
        }

        private void AbandonProduct()
        {
            var product = dc.Products.FirstOrDefault(p => p.ProductId == SelectedProduct.ProductId);
            if (product != null)
            {
                product.Discontinued = true;
                ProductsList.Remove(SelectedProduct);
                dc.SaveChanges();
                loadProducts();
            }
            /*
            if (SelectedProduct != null)
            {
                ProductsList.Remove(SelectedProduct);
            }
            */
        }
    }
}
