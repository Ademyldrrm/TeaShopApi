# Teashop API Projesi

Bu proje, Teashop adlı kafe için geliştirilmiş çok katmanlı mimari ve Code First yaklaşımını kullanarak oluşturulmuş bir API projesidir. Proje içeriğinde çeşitli içeceklerin yönetimi için temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir API bulunmaktadır.
![Ekran görüntüsü 2023-12-13 232022](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/12765b96-8235-4dd2-95ef-6bfed2697bfb)
![Ekran görüntüsü 2023-12-13 232002](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/16c98e7a-689c-4447-9bc2-c1fa1428f414)
![Ekran görüntüsü 2023-12-13 231941](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/326b96c7-24d7-4318-962f-926a84100308)
![Ekran görüntüsü 2023-12-13 231925](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/8fbf91fb-1447-4310-bc5f-e83612db9418)
![Ekran görüntüsü 2023-12-13 231900](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/dd0a82fa-40d1-4946-bd3c-d2c4ecfbb8f6)
![Ekran görüntüsü 2023-12-13 231848](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/94f9d920-4d33-4906-aead-a85d9a8774f2)
![Ekran görüntüsü 2023-12-13 231825](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/158b1c7d-6838-4461-a58b-704f4214e197)
![Ekran görüntüsü 2023-12-13 231806](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/ad45dfa3-f62c-4bff-bee5-a4385744f571)
![Ekran görüntüsü 2023-12-13 231639](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/48b1b761-4517-4e3d-b012-e324767a19de)
![Ekran görüntüsü 2023-12-13 231623](https://github.com/Ademyldrrm/TeaShopApi/assets/92265631/a5deda1b-77a4-481a-8a6a-229bb2f5b568)


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
  
  ## API Endpoints
  
#Aşağıda projenin API endpoint'leri bulunmaktadır:

- GET /api/drinks: Tüm içecekleri getirir.
- GET /api/drinks/:id: Belirli bir içeceği ID'ye göre getirir.
- POST /api/drinks: Yeni bir içecek ekler.
- PUT /api/drinks/:id: Belirli bir içeceği günceller.
- DELETE /api/drinks/:id: Belirli bir içeceği siler.


