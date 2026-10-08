using ChatApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Lägg till SignalR-tjänsten.
//    Detta gör att servern kan hantera realtidskommunikation.
builder.Services.AddSignalR();

// 2. Tillåt statiska filer (HTML, JS, CSS).
builder.Services.AddRouting();

var app = builder.Build();

// 3. Tvinga HTTPS (TLS).
app.UseHttpsRedirection();

// 4. Servera wwwroot-mappen.
app.UseStaticFiles();

app.UseRouting();

// 5. Mappa SignalR-hubben på /chathub.
//    Klienten kommer ansluta hit.
app.MapHub<ChatHub>("/chathub");

// 6. En enkel startsida.
app.MapGet("/", () => "ChatApp körs. Gå till /chat.html för att chatta.");

app.Run();
