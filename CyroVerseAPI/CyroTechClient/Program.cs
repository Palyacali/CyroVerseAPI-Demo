using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyroTechClient
{
    class Program
    {
        // Karakter yapımızı burada da tanımlıyoruz (API'deki ile aynı olmalı)
        public class Character {
            public string Name { get; set; }
            public string Role { get; set; }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("=== CyroTech Merkezi Sistem Bağlantısı ===");
            
            using (HttpClient client = new HttpClient())
            {
                try {
                    // 1. API'ye istek at (API'nin çalıştığı portu kontrol et, 5002 veya 5005)
                    string url = "http://localhost:5002/characters"; 
                    string response = await client.GetStringAsync(url);

                    // 2. Gelen JSON verisini C# listesine çevir
                    var characters = JsonConvert.DeserializeObject<List<Character>>(response);

                    // 3. Veriyi ekrana bas
                    Console.WriteLine("\nBağlantı Başarılı! Karakter Listesi:");
                    foreach (var c in characters) {
                        Console.WriteLine($">> İsim: {c.Name} | Görev: {c.Role}");
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Hata: API'ye ulaşılamadı. Önce API projesini çalıştırmalısın!");
                }
            }
            Console.WriteLine("\nSistem Kapatılıyor...");
        }
    }
}