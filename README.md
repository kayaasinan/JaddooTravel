# ✈️ JadooTravel – Seyahat Rezervasyon & Yönetim Sistemi

## 📌 Proje Hakkında
Bu proje, **.NET 9.0 MVC** ile geliştirilmiş tam kapsamlı bir **seyahat rezervasyon platformudur**.  
MongoDB veritabanı üzerinde çalışır, kullanıcı dostu arayüzü ve modern entegrasyonlarıyla gerçek bir uygulama senaryosunu simüle eder.  

Proje hem **müşteri tarafı (rezervasyon, AI asistanı, çoklu dil desteği)** hem de **admin tarafı (dashboard, raporlama & grafikler)** modüllerine sahiptir.  

---

## 🚀 Teknolojiler
- **Backend:** ASP.NET Core MVC (.NET 9.0)  
- **Database:** MongoDB  
- **Frontend:** Bootstrap 5, ApexCharts, jQuery  
- **AI Entegrasyonu:** OpenAI GPT (gpt-4o-mini)  
- **Localization:** Çoklu dil desteği (TR, EN, ES, FR) – `resx` resource dosyaları  
- **Dependency Injection:** Katmanlı servis yapısı  
- **AutoMapper:** DTO ↔ Entity dönüşümleri  

---

## ✨ Öne Çıkan Özellikler

### 🌍 Kullanıcı Arayüzü
- Navbar, kategori, destinasyon, rezervasyon adımları, testimonial ve footer componentleri
- Modern, responsive UI tasarımı
- Çoklu dil desteği (TR, EN, ES, FR) → dinamik olarak değiştirilebilir

### 🤖 AI Entegrasyonu
- **Şehir Araştırma Asistanı**  
- Kullanıcı ülke & şehir adı girer → AI popup’ta gezilecek 10 yer önerir  

### 📊 Admin Dashboard
- **Snapshot Chart Component** ile 3 dinamik gösterge:
  - 📍 Şehir & Kapasite (Bar Chart)  
  - 💰 Şehir & Fiyat Dağılımı (Donut Chart)  
  - 📊 Toplam Ciro (KPI Kartı)  

