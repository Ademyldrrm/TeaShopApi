# Teashop API Projesi

Bu proje, Teashop adlı kafe için geliştirilmiş çok katmanlı mimari ve Code First yaklaşımını kullanarak oluşturulmuş bir API projesidir. Proje içeriğinde çeşitli içeceklerin yönetimi için temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir API bulunmaktadır.

## Kullanılan Teknolojiler

### Backend

- **C#:** Backend tarafında C# dili kullanılmıştır.
- **MSSQL:** Veritabanı olarak Microsoft SQL Server kullanılmıştır.
- **Swagger:** API dokümantasyonu için Swagger kullanılmıştır.
- **Code First Yaklaşımı

### Frontend

- **HTML:** Sayfaların yapılandırılması için HTML kullanılmıştır.
- **CSS:** Stillerin belirlenmesi için CSS kullanılmıştır.
- **Bootstrap:** Hızlı ve etkili bir şekilde arayüz tasarımı için Bootstrap kullanılmıştır.
- **JavaScript:** Sayfa etkileşimleri için JavaScript kullanılmıştır.

## Proje Yapısı ve Katmanlı Mimarisi

Proje, aşağıdaki katmanlı mimari yapısını takip eder:

- **Controllers:** API isteklerini karşılayan Controller sınıfları bulunur.
- **Services:** İş mantığı kurallarının uygulandığı Service sınıfları bulunur.
- **Repositories:** Veritabanı işlemlerinin yapıldığı Repository sınıfları bulunur.
- **DTOs (Data Transfer Objects):** Gerekli olan verilerin sadece belirli bileşenlerle paylaşıldığı DTO sınıfları bulunur.

  ## Gereksinimler
- .NET Core SDK
- Microsoft SQL Server
  
  ##API Endpoints
  
#Aşağıda projenin API endpoint'leri bulunmaktadır:

- GET /api/drinks: Tüm içecekleri getirir.
- GET /api/drinks/:id: Belirli bir içeceği ID'ye göre getirir.
- POST /api/drinks: Yeni bir içecek ekler.
- PUT /api/drinks/:id: Belirli bir içeceği günceller.
- DELETE /api/drinks/:id: Belirli bir içeceği siler.


