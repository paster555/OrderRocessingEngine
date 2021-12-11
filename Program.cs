using OrderProcessingEngine.Contracts;
using OrderProcessingEngine.Enums;
using OrderProcessingEngine.Implementations;
using OrderRocessingEngine.Contracts;
using Unity;

namespace OrderProcessingEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            RegisterDependencies(container);

            IPaymentRuleProcessingEngine engine = container.Resolve<IPaymentRuleProcessingEngine>();
            engine.StartProcessing(
                new Product
                {
                    ProductType = ProductType.Video,
                    ProductName = "learning to Ski,"
                });
            System.Console.ReadKey();
        }

        private static void RegisterDependencies(IUnityContainer container)
        {
            container.RegisterType<IPaymentRuleProcessor, BookProductPaymentRuleProcessor>(ProductType.Book.ToString());
            container.RegisterType<IPaymentRuleProcessor, PhysicalProductPaymentRuleProcessor>(ProductType.PhysicalProduct.ToString());
            container.RegisterType<IPaymentRuleProcessor, VideoProductPaymentRuleProcessor>(ProductType.Video.ToString());
            container.RegisterType<IPaymentRuleProcessor, MembershipPaymentRuleProcessor>(ProductType.Membership.ToString());
            container.RegisterType<IPaymentRuleProcessor, MembershipPaymentRuleProcessor>(ProductType.UpgradeToMembership.ToString());
            container.RegisterType<IPaymentRuleProcessorFactory, PaymentRuleProcessorFactory>();
            container.RegisterType<IPaymentRuleProcessingEngine, PaymentEngine>();
        }

        /// <summary> Implementation of <see cref="IProduct"/> </summary>
        private class Product : IProduct
        {
            public ProductType ProductType { get; set; }
            public string ProductName { get; set; }
        }
    }
}
