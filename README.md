# Teashop API Projesi

![Teashop Logo](teashop-logo.png)

Bu proje, Teashop adlı kafe için geliştirilmiş bir API projesidir. Proje içeriğinde çeşitli içeceklerin yönetimi için temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir API bulunmaktadır.

## Kullanılan Teknolojiler

- **Backend:**
  - Node.js
  - Express.js
  - MongoDB (Veritabanı)
  
- **Frontend:**
  - React.js
  - Axios (HTTP istekleri için)

## Başlarken

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz.

### Gereksinimler

- Node.js
- MongoDB

### Kurulum

1. Proje klasörünü yerel ortamınıza kopyalayın.
2. Terminal veya komut istemcisini açın ve proje klasörüne gidin.
3. Backend için:

    ```bash
    cd backend
    npm install
    npm start
    ```

4. Frontend için:

    ```bash
    cd frontend
    npm install
    npm start
    ```

5. Tarayıcınızda [http://localhost:3000](http://localhost:3000) adresine gidin.

## API Endpoints

- **GET /api/drinks:** Tüm içecekleri getirir.
- **GET /api/drinks/:id:** Belirli bir içeceği ID'ye göre getirir.
- **POST /api/drinks:** Yeni bir içecek ekler.
- **PUT /api/drinks/:id:** Belirli bir içeceği günceller.
- **DELETE /api/drinks/:id:** Belirli bir içeceği siler.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak istiyorsanız, lütfen forklayın ve pull request gönderin. Büyük değişikliklerden önce, önce değişikliğinizi tartışmak için bir konu açın.
