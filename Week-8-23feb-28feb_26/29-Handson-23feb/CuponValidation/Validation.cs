using System;
using System.Collections.Generic;
using System.Text;

namespace CuponValidation
{
    internal class Validation
    {

        public class Product
        {
            public string name;
            public double price;
            public string coupon;

            public Product(string name, double price, string coupon)
            {
                this.name = name;
                this.price = price;
                this.coupon = coupon;
            }
        }

        public class InvalidCouponException : Exception
        {
            public InvalidCouponException(string message) : base(message) { }
        }

        public class Validator
        {
            public string ValidateCoupon(Product p)
            {
                if (string.IsNullOrEmpty(p.coupon))
                    throw new InvalidCouponException("Coupon cannot be empty");

                string[] parts = p.coupon.Split('-');

                if (parts.Length != 2)
                    throw new InvalidCouponException("Invalid coupon format");

                string productName = parts[0];
                int discount;

                if (!int.TryParse(parts[1], out discount))
                    throw new InvalidCouponException("Invalid discount value");

                if (!productName.Equals(p.name, StringComparison.OrdinalIgnoreCase))
                    throw new InvalidCouponException("Product name does not match");

                if (discount < 10 || discount > 25)
                    throw new InvalidCouponException("Discount must be between 10 and 25");

                return "Coupon is valid";
            }

            public double NetPrice(Product p)
            {
                ValidateCoupon(p);
                int discount = int.Parse(p.coupon.Split('-')[1]);
                double discountAmount = (p.price * discount) / 100;
                return p.price - discountAmount;
            }
        }
    }
}

    