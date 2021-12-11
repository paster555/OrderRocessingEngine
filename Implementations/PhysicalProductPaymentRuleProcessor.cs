using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine.Implementations
{
    /// <summary> Implementation of <see cref="IPaymentRuleProcessor"/> </summary>
    internal sealed class PhysicalProductPaymentRuleProcessor : PaymentRuleProcessorBase, IPaymentRuleProcessor
    {
        public void ProcessProductPayment(IProduct product)
        {
            if (product.ProductType != Enums.ProductType.PhysicalProduct)
                return;
            CreatePackingSlipForProduct(product);
            GenerateComissionPaymentToAgent();
        }
    }
}
