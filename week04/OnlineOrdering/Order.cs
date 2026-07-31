using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _comments = new List<Product>(); // Initializes internal list
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal productSubtotal = 0;
            foreach (Product product in _products)
            {
                productSubtotal += product.GetTotalCost();
            }

            decimal shippingCost = _customer.LivesInUSA() ? 5.00m : 35.00m;

            return productSubtotal + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- PACKING LABEL ---");
            foreach (Product product in _products)
            {
                sb.AppendLine($"Product: {product.GetName()} | ID: {product.GetProductId()}");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- SHIPPING LABEL ---");
            sb.AppendLine(_customer.GetName());
            sb.AppendLine(_customer.GetAddress().GetFullAddress());
            return sb.ToString();
        }
    }
}
