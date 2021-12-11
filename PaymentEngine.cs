using OrderProcessingEngine.Contracts;
using OrderRocessingEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace OrderProcessingEngine
{
    /// <summary>   Implementation of <see cref="IPaymentRuleProcessingEngine"/> </summary>
    public class PaymentEngine : IPaymentRuleProcessingEngine
    {

        #region Private fields
        readonly IUnityContainer m_UnityContainer;
        readonly IPaymentRuleProcessorFactory m_PaymentRuleProcessorFactory;
        #endregion
        #region Constructors
        /// <summary> Constructor for <see cref="PaymentEngine"/></summary>
        /// <param name="unityContainer"></param>
        public PaymentEngine(IUnityContainer unityContainer)
        {
            m_UnityContainer = unityContainer;
            m_PaymentRuleProcessorFactory = m_UnityContainer?.Resolve<IPaymentRuleProcessorFactory>();
        }
        #endregion
        #region Public Methods
        public void StartProcessing(IProduct product)
        {           
            IPaymentRuleProcessor ruleProcessor = m_PaymentRuleProcessorFactory?.GetPaymentRuleProcessorFromProductType(product.ProductType);
            ruleProcessor?.ProcessProductPayment(product);
        }
        #endregion
    }
}
