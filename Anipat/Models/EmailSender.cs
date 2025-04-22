namespace Anipat.Models {
    public class EmailSender : IEmailSender 
    {
        public bool SendEmail(string to, string messageText, string subject)
        {
            return  true; 
        }
    }
}
