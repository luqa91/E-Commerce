using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace E_Commerce
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Dołącz tutaj usługę poczty e-mail, aby wysłać wiadomość e-mail.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Dołącz tutaj usługę wiadomości SMS, aby wysłać wiadomość SMS.
            return Task.FromResult(0);
        }
    }

    // Skonfiguruj menedżera użytkowników aplikacji używanego w tej aplikacji. Interfejs UserManager jest zdefiniowany w produkcie ASP.NET Identity i jest używany przez aplikację.
   
    // Skonfiguruj menedżera logowania aplikacji używanego w tej aplikacji.
   
}
