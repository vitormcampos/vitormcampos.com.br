using Microsoft.AspNetCore.Mvc;

namespace vitormcampos.com.br.UI.Components;

public class ProjectsViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var timeline = new List<Experiencia>
        {
            new(
                "Desenvolvedor Full Stack",
                "Procorretor",
                "2024 - Presente",
                [
                    @"Liderei a migração de um projeto originalmente em WordPress para uma solução multi-usuário desenvolvida em ASP.NET 8 com MariaDB, reduzindo custos de manutenção e viabilizando escalabilidade para múltiplos clientes.",
                    @"Estruturei a camada de front-end em Angular 19, permitindo que cada cliente tenha um site automatizado e personalizável.",
                    @"Participei da definição de arquitetura e processos de CI/CD para acelerar deploys e reduzir falhas em produção.",
                ]
            ),
            new(
                "Desenvolvedor Back-end",
                "Marketplace de Moda",
                "2023 - 2024",
                [
                    "Atuei no desenvolvimento do back-end de um marketplace escalável utilizando NestJS, Postgres e RabbitMQ.",
                    "Estruturei módulos de logística própria e de terceiros, garantindo flexibilidade para diferentes modelos de entrega.",
                    "Desenvolvi integrações com gateways de pagamento, incluindo split de pagamento, atendendo às regras complexas do marketplace.",
                    "Contribuí para a escalabilidade do sistema com arquitetura orientada a eventos e filas de processamento. ",
                ]
            ),
            new(
                "Desenvolvedor Full Stack",
                "TeclaT",
                "2022 - 2023",
                [
                    "Participei da construção de um marketplace MVP utilizando WordPress com WooCommerce.",
                    "Desenvolvi e personalizei plugins internos e adaptei soluções de terceiros para atender regras específicas do negócio.",
                    "o Implementei módulos de logística integrados com transportadoras externas, aumentando a eficiência das operações.",
                ]
            ),
        };

        var projetosRelevantes = new List<Projeto>
        {
            new(
                "Sistema de integração para venda de ingressos",
                @"
                    Produzi um plugin Wordpress para uma integração completa de um sistema de venda de ingressos, podendo selecionar o evento, comprar ingressos e acompanhar seu pedido. Suportando métodos de pagamento diversos e autenticação via sistema externo usando cookies. 
                "
            ),
            new(
                "Dashboard para visualização de dados logísticos (BI)",
                @"Participei do desenvolvimento de um sistema para visualização de dados de forma inteligente, onde como back-end produzi queries SQL Server para entregar dados de um sistema Protheus (TOTVS) para o fron-end via o framework ASP .NET 6."
            ),
        };

        ViewData["Experiencias"] = timeline;
        ViewData["ProjetosRelevantes"] = projetosRelevantes;

        return View("/Components/Projects/Default.cshtml");
    }
}

public record Projeto(string Titulo, string Descricao);

public record Experiencia(string Titulo, string Projeto, string Periodo, List<string> Descricao);
