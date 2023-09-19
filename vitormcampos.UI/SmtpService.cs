using System.Net;
using System.Net.Mail;

namespace vitormcampos.com.br.UI;

public class SmtpService
{
    private readonly IConfiguration _configuration;

    public SmtpService(IConfiguration configuration )
    {
        _configuration = configuration;
    }
    
    public void Send(string senderName, string senderEmail)
    {
        var userName = _configuration.GetValue<string>("MailSettings:UserName");
        var password = _configuration.GetValue<string>("MailSettings:Password");
        var smtp = _configuration.GetValue<string>("MailSettings:Server");
        var port = _configuration.GetValue<int>("MailSettings:Port");
        var email = _configuration.GetValue<string>("MailSettings:Email");
        
        var client = new SmtpClient(smtp, port)
        {
            Credentials = new NetworkCredential(userName, password),
            EnableSsl = true
        };
        client.Send(email, email, $"Contato de {senderName}", $@"
            Novo email de {senderName} com endereço {senderEmail}
        ");
    }
}