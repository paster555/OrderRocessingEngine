using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine.Contracts
{
    /// <summary>Contract for Payment  Rule Processor Factory</summary>
    public interface IPaymentRuleProcessorFactory
    {
        /// <summary> Provides specific payment rule processor based on product type</summary>
        /// <param name="productType"></param>
        /// <returns></returns>
        IPaymentRuleProcessor GetPaymentRuleProcessorFromProductType(ProductType productType);
    }
}
