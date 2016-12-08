using System;
using System.Net.Mail;

namespace ValidationEngineTests
{
    public class Validator
    {
        private string emailAddres;
        private bool validEmailAddress;
        public string exceptionMessage;

        public Validator(string emailAddres, bool validEmailAddress)
        {
            this.emailAddres = emailAddres;
            this.validEmailAddress = validEmailAddress;
        }

        
        public bool ValidateEmailAddress(string addressToValidate)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(addressToValidate))
                {
                    return false;
                }

                MailAddress m = new MailAddress(addressToValidate);

                return true;
            }
            catch (FormatException fEx)
            {
                exceptionMessage = fEx.Message;
                return false;
            }
        }
    }
}