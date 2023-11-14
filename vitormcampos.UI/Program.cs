using dotenv.net;
using vitormcampos.com.br.UI;
using vitormcampos.com.br.UI.Services;

DotEnv.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddRazorPages();

builder.Services.AddScoped<SmtpService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        b =>
            b.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
    );
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();