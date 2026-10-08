# ChatApp SignalR-chatt

## Funktionalitet
- Flera användare kan chatta i realtid.
- Användarnamn krävs.
- SignalR använder WebSockets/fallback.
- TLS (HTTPS) med self-signed certifikat.

## Kör lokalt
1. Installera .NET SDK.
2. Generera certifikat:

   ```bash
   dotnet dev-certs https -ep ./cert.pfx -p Lösenord123!
   dotnet dev-certs https --trust
3. Kör: dotnet run
4. Öppna: https://localhost:5001/chat.html

## AI-användning
- Struktur för projektet.
- Kodexempel för server och klient.
- Fördjupade förklaringar.

## Anpassningar
- Namn, mappar och filstruktur anpassad för mitt projekt.

## Förståelse
- Jag kan förklara hur SignalR fungerar.
- Jag kan förklara vad TLS skyddar och inte skyddar.
- Jag kan förklara hur klienten ansluter och skickar meddelanden.

## Sammanfattning
Min chattapplikation använder TLS‑kryptering via ett self‑signed certifikat.
Det betyder att all kommunikation mellan klient och server är krypterad under transporten, inklusive WebSocket‑trafiken som SignalR använder.
TLS skyddar mot avlyssning och manipulation av trafiken, men skyddar inte vad som händer inne i servern eller klienten.
Jag använder SignalR för realtidskommunikation, och användaren måste ange ett användarnamn för att få skicka meddelanden.