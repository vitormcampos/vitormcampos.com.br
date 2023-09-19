using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vitormcampos.com.br.UI.Pages;

public class Contato : PageModel
{
    [BindProperty]
    public string? Name { get; set; }
    [BindProperty]
    public string? Email { get; set; }

    private readonly SmtpService _smtpService;

    public Contato(SmtpService smtpService)
    {
        _smtpService = smtpService;
    }

    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email)) return;
       _smtpService.Send(Name, Email);
    }
}