using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.OAuth;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
.AddCookie()
.AddGoogle(options =>
{
    //Colocar as credenciais do Google aqui

    //options.ClientId = "your-client-id-here";
    //options.ClientSecret = "your-client-secret-here";
    options.CallbackPath = "/signin-google"; // Rota de callback padrão
    options.Events = new OAuthEvents // tratamento de erros
    {
        OnRemoteFailure = context =>
        {
            context.Response.Redirect("/Home/Error?message=" + context.Failure.Message);
            context.HandleResponse();
            return Task.CompletedTask;
        }
    };

});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
