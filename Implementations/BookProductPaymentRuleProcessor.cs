using OrderProcessingEngine.Contracts;

namespace OrderProcessingEngine.Implementations
{
    /// <summary> Implementation of IPaymentRuleProcessor </summary>
    internal sealed class BookProductPaymentRuleProcessor : PaymentRuleProcessorBase, IPaymentRuleProcessor
    {
        /// <summary>Applies specific action for the product payment</summary>        
        public void ProcessProductPayment(IProduct product)
        {
            if (product.ProductType != Enums.ProductType.Book)
                return;
            DuplicatePackingSlip("packing slip");
            GenerateComissionPaymentToAgent();
        }
    }
}
