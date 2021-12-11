using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine
{
    /// <summary> Contract for Payment Rule Processor </summary>
    public interface IPaymentRuleProcessor
    {
        /// <summary> Applies specific requirement/rule upon payment for the product </summary>
        /// <param name="product">Product being purchased</param>
        void ProcessProductPayment(IProduct product);
    }
}
