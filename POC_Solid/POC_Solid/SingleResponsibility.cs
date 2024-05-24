using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace POC_Solid
{
    /// <summary>
    /// Each class should have only one reason to change.

    /// Example:
    ///     ProductService: Handles product-related operations.
    ///     EmailService: Handles email notifications.
    /// </summary>
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductService
    {
        private readonly IEmailService _emailService;
        private readonly ISMSService _smssService;

        public ProductService(IEmailService emailService, ISMSService sMSService)
        {
            _emailService = emailService;
            _smssService = sMSService;
        }

        public void AddProduct(Product product)
        {
            // Logic to add the product to the database
            _emailService.SendProductAddedEmail(product);
            _smssService.SendProductAddedSMS(product);
        }
    }

    public interface IEmailService
    {
        void SendProductAddedEmail(Product product);
    }

    public class EmailService : IEmailService
    {
        public void SendProductAddedEmail(Product product)
        {
            // Logic to send email
        }
    }

    public interface ISMSService
    {
        void SendProductAddedSMS(Product product);
    }

    public class SMSService : ISMSService
    {
        public void SendProductAddedSMS(Product product)
        {
            // Logic to send email
        }
    }
}
