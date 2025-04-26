# :gem:ASP.NET Core 6.0 ile Admin Panelli Portföy Sitesi
Bu repository, M&Y Yazılım Akademi bünyesinde yaptığım ilk proje olan Admin Panelli Portföy Sitesi projesini içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core Framework) kullanarak dinamik bir Portföy sitesi oluşturdum. Bu projede tek katman üzerinde çalıştım. Klasör tasarımını bozmadan katmanlı mimari düzenini tek katmanda kurmaya çalıştım. SOLID prensiplerine ve dosya organizasyonuna uygun şekilde geliştirme yaparak kod tekrarını en aza indirmeye çalıştım. Entity Framework Core - Code First yaklaşımını kullanarak veri tabanı bağlantılarını oluşturdum.

Genel anlamda tek katman üzerinde projeyi oluşturmama rağmen klasör tasarımı ile DataAccessLayer ve UI Layer olarak iki katman kullandım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası Code-First yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım. UI Layer (Sunum Katmanı) ise kullanıcının görüntülediği bölümdür. Burada arayüz tasarımlarını oluşturdum. 

Bu projede değiştirilmesi gereken bazı noktalar olabilir fakat burada asıl amaç Back-end Development anlamında .Net Core ile admin panelli bir sistem kurmaktır. Front-end anlamında düzeltmeler yapılabilir.

Projede genel anlamda 2 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in hakkımda, yetenekler, deneyimler, referanslar, mesajlar gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı bölümdür.  
2- Ana Sayfa: Burada da Melih Çolak ve hayatı ile ilgili bilgiler yer alıyor.

Kullandığım Teknolojiler
- ASP.NET Core 6.0
- Entity Framework Core (EF Core)
- MS SQL Server
- HTML5 - CSS3 - Bootstrap
- JavaScript
- Razor View Engine
- Partial Views
- ViewComponent

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Ana Sayfa
<div align="center">
  <img src="https://github.com/melihcolak0/PortfolioBasic/blob/d8aa7ce87dff1ef2ce68b963bfa78de96eebdafd/localhost_7168_Default_Index.png" alt="image alt">
</div>

### :triangular_flag_on_post: Admin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/PortfolioBasic/blob/bdf5775244844a5dcb1d155907b4116f6f28ccb0/ss/localhost_7168_AdminDashboard_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/PortfolioBasic/blob/bdf5775244844a5dcb1d155907b4116f6f28ccb0/ss/localhost_7168_AdminToDoList_Index.png" alt="image alt">
</div>
