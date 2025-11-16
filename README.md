# 🗒️ C# Not Defteri Uygulaması (Notepad Clone)

Bu proje, C# programlama dili ve Visual Studio ortamında, Windows Forms (WinForms) kullanılarak geliştirilmiş basit bir Not Defteri (Notepad) klonudur. Temel dosya işlemlerini (Açma, Kaydetme, Yeni oluşturma) gerçekleştirmektedir.

## ✨ Özellikler

* **Yeni Belge:** Metin alanını temizleyerek yeni bir belge oluşturur.
* **Dosya Aç:** Kullanıcının bilgisayarından `.txt` uzantılı bir dosyayı uygulamaya yükler.
* **Dosya Kaydet:** Metin alanındaki içeriği kullanıcının belirlediği bir isimle `.txt` formatında kaydeder.
* **Çıkış:** Uygulamayı güvenli bir şekilde kapatır.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Ortam:** .NET Framework (veya .NET Core / .NET 5+)
* **Arayüz:** Windows Forms (WinForms)
* **IDE:** Visual Studio

## 🚀 Kurulum ve Çalıştırma

Uygulamayı yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/KULLANICI_ADINIZ/NotDefteriProjesi.git](https://github.com/KULLANICI_ADINIZ/NotDefteriProjesi.git)
    ```
    *(Yukarıdaki URL'yi kendi GitHub depo adresinizle değiştirin.)*
2.  **Visual Studio'da Açın:** Proje klasörüne gidin ve `.sln` (Solution) dosyasını Visual Studio ile açın.
3.  **Çalıştırın:** Visual Studio'da **F5** tuşuna basarak veya `Start` (Başlat) butonuna tıklayarak uygulamayı derleyin ve çalıştırın.

## 📜 Temel Kodlama Detayları

Dosya işlemleri için kullanılan temel C# sınıfları:

| İşlev | Kullanılan Bileşen/Metot | Açıklama |
| :--- | :--- | :--- |
| **Kaydetme** | `SaveFileDialog`, `System.IO.File.WriteAllText()` | Kullanıcıdan dosya yolu alır ve içeriği yazar. |
| **Açma** | `OpenFileDialog`, `System.IO.File.ReadAllText()` | Kullanıcıdan dosya yolu alır ve içeriği okur. |
| **Arayüz** | `MenuStrip`, `TextBox` | Temel menü ve metin giriş alanını sağlar. |

---
## 🧑‍💻 Geliştirici

Meral Yavuztürk
