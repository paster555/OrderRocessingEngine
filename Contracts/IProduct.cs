using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine.Contracts
{
    /// <summary> Contract for product </summary>
    public interface IProduct
    {
        /// <summary> Product type </summary>
        ProductType ProductType { get; set; }

        /// <summary> Product name </summary>
        string ProductName { get; set; }
    }
}
