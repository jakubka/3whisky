using Whisky.Db.Entities;

namespace Whisky.Logic.Emails
{
    internal interface IEmailGenerator
    {
        EmailData GenerateAdminOrderNotification(Order order);


        EmailData GenerateCustomerOrderConfirmation(Order order);
    }
}