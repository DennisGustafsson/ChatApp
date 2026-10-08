using Microsoft.AspNetCore.SignalR;

namespace ChatApp;

/// <summary>
/// SignalR-hubben är "hjärtat" i chatten.
/// Klienter anropar SendMessage(), och servern skickar vidare meddelandet till alla.
/// </summary>
public class ChatHub : Hub
{
    /// <summary>
    /// Klienten anropar denna metod när ett meddelande ska skickas.
    /// </summary>
    /// <param name="user">Användarnamnet som klienten anger.</param>
    /// <param name="message">Själva meddelandet.</param>
    public async Task SendMessage(string user, string message)
    {
        // Clients.All = alla anslutna klienter.
        // SendAsync("ReceiveMessage") = klienterna lyssnar på detta event.
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
