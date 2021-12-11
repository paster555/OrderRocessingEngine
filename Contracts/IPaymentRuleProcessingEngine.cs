using OrderProcessingEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRocessingEngine.Contracts
{
    /// <summary> Contract for Payment Rule Processing Engine </summary>
    public interface IPaymentRuleProcessingEngine
    {
        /// <summary> Invokes process of identification and application of product related rule upon payment</summary>
        /// <param name="product">Product being purchased</param>
        void StartProcessing(IProduct product);
    }
}
