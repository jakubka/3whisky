using System.Collections.Generic;

using Whisky.Db.Entities;
using Whisky.Logic.Orders;
using Whisky.TextFormatting;

namespace Whisky.Logic.Emails
{
    internal class HardcodedStringsEmailGenerator : IEmailGenerator
    {
        private readonly IShipmentDateCalculator _shipmentDateCalculator;


        public HardcodedStringsEmailGenerator(IShipmentDateCalculator shipmentDateCalculator)
        {
            _shipmentDateCalculator = shipmentDateCalculator;
        }


        public EmailData GenerateAdminOrderNotification(Order order)
        {
            string htmlBody = @"<h1>Nova objednavka cislo " + order.UniqueNumber + "</h1>"
                              + "Zakaznik: " + order.Name + ", " + order.Email + "<br />"
                              + "Produkt: " + order.Product.Name + " za " + order.TotalPrice + "<br />"
                              + "Detaily: " + order.ShipmentMethod + ", " + order.PaymentMethod + ", " + order.DeliveryAddress + ", " + order.Note;

            var emailData = new EmailData()
            {
                SenderAddress = "info@3whisky.cz",
                RecipientAddresses = new List<string>
                {
                    "jakub.kadlubiec@gmail.com",
                    "hvlasak@gmail.com",
                    "roman.mazur@hotmail.com",
                },
                Subject = "Nova objednavka!!!!!!",
                HtmlBody = htmlBody,
            };

            return emailData;
        }


        public EmailData GenerateCustomerOrderConfirmation(Order order)
        {
            string htmlBody = "<p>Vážený zákazníku,</p>" +
                              "<p>děkujeme za Váš nákup na <a href=\"http://3whisky.cz\">3whisky.cz</a>. Tímto emailem potvrzujeme, že jsme v pořádku přijali Vaši objednávku a zasíláme upřesňující informace.</p>" +
                              "<p>" +
                              "<b>Číslo objednávky:</b> " + order.UniqueNumber +
                              "<br /><b>Přijato:</b> " + order.Created.ToShortDateString() +
                              "<br /><b>Způsob platby:</b> " + order.PaymentMethod +
                              "<br /><b>Způsob dopravy:</b> " + order.ShipmentMethod +
                              "<br /><b>Celková cena:</b> " + order.TotalPrice.AsPrice() +
                              "<br /><b>Adresa pro doručení:</b> " + order.DeliveryAddress +
                              "<br /><b>Předpokládané datum předání dopravci:</b> " + _shipmentDateCalculator.CalculateShipmentDate(order.Created).ToShortDateString() +
                              "</p>" +
                              "<p>Ještě jednou děkujeme za objednávku na <a href=\"http://3whisky.cz\">3whisky.cz</a> a přejeme příjemný den.</p>" +
                              "<br />" +
                              "<p>S přátelským pozdravem,</p>" +
                              "<p>tým 3whisky</p>";

            var emailData = new EmailData()
            {
                SenderAddress = "info@3whisky.cz",
                Subject = "Potvrzeni objednavy na eshopu 3whisky",
                HtmlBody = htmlBody,
            };
            emailData.RecipientAddresses.Add(order.Email);

            return emailData;
        }
    }
}