/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Mandates.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class SepaDirectDebitPaymentProduct771SpecificInputBase : AbstractSepaDirectDebitPaymentProduct771SpecificInput
    {
        public string ExistingUniqueMandateReference { get; set; } = null;

        public CreateMandateBase Mandate { get; set; } = null;
    }
}
