using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace OrderProcessingEngine.Implementations
{
    /// <summary> Implementation of <see cref="IPaymentRuleProcessorFactory"/></summary>
    internal sealed class PaymentRuleProcessorFactory : IPaymentRuleProcessorFactory
    {
        #region Private fields
        private readonly IUnityContainer m_UnityContainer;
        #endregion
        #region Constructors
        /// <summary> Constructor for <see cref="PaymentRuleProcessorFactory"/> </summary>
        public PaymentRuleProcessorFactory(IUnityContainer unityContainer)
        {
            m_UnityContainer = unityContainer;
        }
        #endregion
        #region Public Methods
        public IPaymentRuleProcessor GetPaymentRuleProcessorFromProductType(ProductType productType)
        {
            return m_UnityContainer?.Resolve<IPaymentRuleProcessor>(productType.ToString());
        }
        #endregion
    }
}
