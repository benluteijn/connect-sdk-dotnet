/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Mandates;
using Ingenico.Connect.Sdk.Domain.Mandates.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Mandates
{
    public class CreateMandateExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                BankAccountIban bankAccountIban = new BankAccountIban();
                bankAccountIban.Iban = "DE46940594210000012345";

                MandateContactDetails contactDetails = new MandateContactDetails();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";

                MandateAddress mandateAddress = new MandateAddress();
                mandateAddress.City = "Monumentenvallei";
                mandateAddress.CountryCode = "NL";
                mandateAddress.Street = "Woestijnweg";
                mandateAddress.Zip = "1337XD";

                MandatePersonalName name = new MandatePersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";

                MandatePersonalInformation personalInformation = new MandatePersonalInformation();
                personalInformation.Name = name;
                personalInformation.Title = "Miss";

                MandateCustomer customer = new MandateCustomer();
                customer.BankAccountIban = bankAccountIban;
                customer.CompanyName = "Acme labs";
                customer.ContactDetails = contactDetails;
                customer.MandateAddress = mandateAddress;
                customer.PersonalInformation = personalInformation;

                CreateMandateRequest body = new CreateMandateRequest();
                body.Customer = customer;
                body.CustomerReference = "idonthaveareference";
                body.Language = "nl";
                body.RecurrenceType = "UNIQUE";
                body.SignatureType = "UNSIGNED";

                CreateMandateResponse response = await client.Merchant("merchantId").Mandates().Create(body);
            }
#pragma warning restore 0168
        }

        private Client GetClient()
        {
            string apiKeyId = "someKey";
            string secretApiKey = "someSecret";

            CommunicatorConfiguration configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
