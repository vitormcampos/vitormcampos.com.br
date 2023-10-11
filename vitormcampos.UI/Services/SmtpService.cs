using System.Net;
using System.Net.Mail;
using dotenv.net;

namespace vitormcampos.com.br.UI.Services;

public class SmtpService
{
    public void Send(string senderName, string senderEmail, string message)
    {
        var env = DotEnv.Read();
        var userName = env["USERNAME"];
        var password = env["PASSWORD"];
        var smtp = env["SERVER"];
        var port = Convert.ToInt32(env["PORT"]);
        var email = env["EMAIL"];
        
        var client = new SmtpClient(smtp, port)
        {
            Credentials = new NetworkCredential(userName, password),
            EnableSsl = true
        };
        client.Send(email, email, $"Contato de {senderName}", $"Novo email de {senderName} com endereço {senderEmail}<br>${message}");
    }
}