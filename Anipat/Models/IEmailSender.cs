namespace Anipat.Models {
    public interface IEmailSender
    {
        public bool SendEmail(string to, string messageText, string subject);    

    }
}
