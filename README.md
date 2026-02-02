🚀 CyroVerse Web API Core Demo
CyroVerseAPI, CyroTech ekosisteminin veri yönetim katmanını temsil eden, modern .NET teknolojileriyle geliştirilmiş bir RESTful API prototipidir. Bu proje, ölçeklenebilir backend mimarileri ve veri akışı prensiplerini test etmek amacıyla oluşturulmuş bir demodur.

Geliştirici Notu: Bu API, CyroTech evrenindeki sistemlerin (Dashboard, mobil uygulamalar vb.) birbiriyle konuşmasını sağlayan merkezi sinir sistemi olarak kurgulanmıştır.

🛠 Teknik Mimari & Özellikler
ASP.NET Core Web API: Yüksek performanslı ve asenkron veri işleme yeteneği.

RESTful Standartları: HTTP metodları (GET, POST, PUT, DELETE) ve anlamlı durum kodları ile tam uyumlu yapı.

Dependency Injection (DI): Esnek ve test edilebilir bir yapı için .NET'in yerleşik DI konteyner kullanımı.

JSON Serialization: İstemci ve sunucu arasında hızlı ve standart veri değişimi.

Error Handling: Merkezi hata yönetimi ile tutarlı API yanıtları.

🧬 Kullanılan Teknolojiler
Framework: .NET 10.0 / .NET Core

Language: C#

Documentation: Swagger / OpenAPI (API endpoint'lerini test etmek ve dökümante etmek için)

IDE: Visual Studio Code / Visual Studio

📂 Proje Yapısı
Plaintext
├── CyroVerseAPI/
│   ├── Controllers/    # API Endpoint tanımlamaları ve istek yönetimi
│   ├── Models/         # Veri transfer nesneleri (DTOs) ve varlıklar
│   ├── Program.cs      # Uygulama yapılandırması ve Middleware ayarları
│   └── appsettings.json # Konfigürasyon dosyaları
└── README.md
🛤 Yol Haritası (Roadmap)
Demo aşamasından üretim aşamasına geçiş planları:

[ ] Entity Framework Core: Veritabanı entegrasyonu (SQL Server/PostgreSQL).

[ ] JWT Authentication: Güvenli veri erişimi için token tabanlı kimlik doğrulama.

[ ] Unit Testing: xUnit veya NUnit ile iş mantığının test edilmesi.

[ ] Logging: Serilog ile detaylı sistem loglama mekanizması.

🚦 Başlangıç
API'yi yerel ortamınızda ayağa kaldırmak için:

Projeyi klonlayın.

Terminale dotnet run komutunu yazın.

Tarayıcıda https://localhost:[port]/swagger adresine giderek API'yi test etmeye başlayın.
