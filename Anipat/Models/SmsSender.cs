namespace Anipat.Models {
    public class SmsSender : IEmailSender {
        public bool SendEmail(string to, string messageText, string subject)
        {
            //SMS
            return true;
        }
    }
    

}

