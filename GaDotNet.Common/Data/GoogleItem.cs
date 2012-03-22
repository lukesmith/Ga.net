/*
 * Facebook Google Analytics Tracker
 * Copyright 2010 Doug Rathbone
 * http://www.diaryofaninja.com
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace GaDotNet.Common.Data
{
    public class GoogleItem
    {
        public string ProductName { get; set; }

        public string ProductSku { get; set; }

        public string ProductVariant { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string OrderID { get; set; }

        public string Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleTransaction"/> class.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <param name="productSku">The product sku.</param>
        /// <param name="orderID">The order ID. (required)</param>
        /// <param name="category">The category/variation.</param>
        /// <param name="unitPrice">The unit price. (required)</param>
        /// <param name="quanity">The quantity. (required)</param>
        public GoogleItem(string orderID, string productSku, string productName, string category, decimal unitPrice, int quanity)
        {
            ProductName = productName;

            ProductSku = productSku;

            OrderID = orderID;

            Category = category;

            UnitPrice = unitPrice;

            Quantity = quanity;

            Validate();
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        public void Validate()
        {
            if (String.IsNullOrEmpty(OrderID))
            {
                throw new Exception("'OrderID' is a required field");
            }

            if (String.IsNullOrEmpty(ProductSku))
            {
                throw new Exception("'ProductSku' is a required field");
            }

            if (String.IsNullOrEmpty(ProductName))
            {
                throw new Exception("'ProductName' is a required field");
            }
        }
    }
}
