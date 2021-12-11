using OrderProcessingEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine.Implementations
{
    /// <summary> Implementation of <see cref="IPaymentRuleProcessor"/> </summary>
    internal sealed class VideoProductPaymentRuleProcessor : PaymentRuleProcessorBase, IPaymentRuleProcessor
    {
        public void ProcessProductPayment(IProduct product)
        {
            if (!string.IsNullOrEmpty(product.ProductName)
                && product.ProductName.Equals("Learning to Ski,", StringComparison.InvariantCultureIgnoreCase))
                AddFreeVideoToPackingSlip("First Aid");
        }              
    }
}
