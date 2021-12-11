using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using OrderRocessingEngine.Contracts;
using System;

namespace OrderProcessingEngine
{
    /// <summary> Base class implementation to support actions for Payment Rule Processors </summary>
    internal abstract class PaymentRuleProcessorBase /// Normaly the class inject in the constructor with services clients/service client factory to action requests
    {
        #region Public Methods
        /// <summary>Notifies user via email about membership</summary>        
        internal virtual void EmailUserAboutMembership(MembrshipActionType membershiActionType, string membershipOwnerEmailAddress)
        {
            Console.WriteLine($"SMTP client and user email required for implementation notify user of {membershiActionType}");
        }

        /// <summary>Creates or Upgrades Memebership according to action requested</summary>        
        internal virtual void ActionMembershipRequest(MembrshipActionType membrshipAction)
        {
            Console.WriteLine($"{membrshipAction} requested, is in progress.");
        }

        /// <summary>Creates packing splip for product purchased</summary>        
        internal virtual void CreatePackingSlipForProduct(IProduct product)
        {
            Console.WriteLine($"Packing list for {product.ProductType} generated.");
        }

        /// <summary> Adds purchased product to the packing slip </summary>
        internal virtual void AddProductToPackingSlip(IProduct product)
        {
            Console.WriteLine($"Product {product.ProductType} is added to the packing list.");
        }

        /// <summary>Duplicates provided packing splip</summary>       
        internal virtual void DuplicatePackingSlip(string packingSlip)
        {
            Console.WriteLine($"Packing slip {packingSlip} is duplicated for the royalty department");
        }
        /// <summary> Generates comission payment to the agent</summary>
        internal virtual void GenerateComissionPaymentToAgent()
        {
            Console.WriteLine($"Implement payment to the agent.");
        }
        
        /// <summary> Adds video specified for free to packing slip</summary>        
        internal virtual void AddFreeVideoToPackingSlip(string freeVideoToAddName)
        {
            Console.WriteLine($"Added free {freeVideoToAddName} video to packing slip.");
        }
        #endregion
    }
}
