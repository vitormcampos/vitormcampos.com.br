using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vitormcampos.com.br.UI.Services;

namespace vitormcampos.com.br.UI.Pages;

public class Contato : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "Nome é obrigatório")]
    public string? Name { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "E-mail é obrigatório")]
    public string? Email { get; set; }
    
    [BindProperty]
    [Required(ErrorMessage = "Mensagem é obrigatório")]
    public string? Message { get; set; }

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
        if (!ModelState.IsValid) return;

        _smtpService.Send(Name, Email, Message);

        ViewData["isSent"] = true;
    }
}