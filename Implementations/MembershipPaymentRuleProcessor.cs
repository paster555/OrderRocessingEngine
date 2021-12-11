using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingEngine.Implementations
{
    /// <summary> Implementation of IPaymentRuleProcessor </summary>
    internal sealed class MembershipPaymentRuleProcessor : PaymentRuleProcessorBase, IPaymentRuleProcessor
    {
        #region Public Methods
        /// <summary>Applies specific action for the product payment</summary>  
        public void ProcessProductPayment(IProduct product)
        {
            if (product.ProductType.Equals(ProductType.Membership))
                ProcessMembershipPayment(MembrshipActionType.MemebershipActivation, "userEmailAddress");
            else if (product.ProductType.Equals(ProductType.UpgradeToMembership))
                ProcessMembershipPayment(MembrshipActionType.MemebershipUpgrade, "userEmailAddress");
        }
        #endregion
        #region Private Methods
        private void ProcessMembershipPayment(MembrshipActionType membrshipActionType, string userEmailAddress)
        {
            ActionMembershipRequest(membrshipActionType);
            if (string.IsNullOrEmpty(userEmailAddress))
                EmailUserAboutMembership(membrshipActionType, userEmailAddress);
        }
        #endregion
    }
}
