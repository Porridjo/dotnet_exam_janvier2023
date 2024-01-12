using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamJanvier2023.ViewModels
{
    class GroupingModel
    {
        private readonly string _country;
        private readonly int _productCount;
        public GroupingModel(string country, int productCount)
        {
            _country = country;
            _productCount = productCount;
        }

        public string Country { get { return _country;} }

        public int ProductCount { get { return _productCount;} }
    }
}
