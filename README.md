# 🚀 ASP.NET Core 6.0 ile Admin Panelli Portföy Sitesi
Bu repository, M&Y Yazılım Akademi bünyesinde yaptığım ilk proje olan Admin Panelli Portföy Sitesi projesini içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

Bu proje, .NET 6.0 ile ASP.NET Core Web Application kullanılarak geliştirilmiş ve Entity Framework Core kullanılarak veritabanı işlemleri gerçekleştirilmiş, admin paneli üzerinden yönetilebilen dinamik bir portfolyo sitesidir. Projede tek katmanlı bir yapı üzerinde çalışılmış, ancak klasör tasarımıyla birlikte katmanlı mimari düzenine uygun bir yapı kurulmuştur. Klasör yapısı Entities, Controllers, Models, Views ve ViewComponents şeklinde düzenlenmiş ve dosya organizasyonu SOLID prensiplerine dikkat edilerek tasarlanmıştır. Bu sayede kod tekrarı minimuma indirilmiş ve düzenli bir proje yapısı oluşturulmuştur.

Proje içerisinde Ana Sayfa, Hakkında, Kategoriler, Eğitimler, Deneyimler, Pozisyonlar, Mesajlar, Portfolyo, Hizmetler, Yetenekler, Sosyal Medya ve Referanslar gibi dinamik olarak yönetilebilen bölümler yer almaktadır. Her bölüm için ayrı veritabanı tabloları oluşturulmuş ve Entity Framework Core'un Code First yaklaşımı kullanılarak veri tabanı bağlantıları sağlanmıştır.

Genel anlamda projede tek katman kullanılmış olsa da, iç yapı itibarıyla Entity Layer (Varlık Katmanı), Data Access Layer (Veri Erişim Katmanı) ve UI Layer (Sunum Katmanı) olacak şekilde katmanlı bir mantık uygulanmıştır. Entity Layer kısmında veri tabanı tablolarını temsil eden sınıflar ve property'ler tanımlanmıştır. Data Access Layer, veri tabanı işlemleri için gerekli etkileşimleri sağlamış, UI Layer ise kullanıcıya sunulan arayüz tasarımlarını barındırmıştır.

Sayfalar arasında parçalı yapı yönetimi için ViewComponent yapıları kullanılmış ve tasarım tarafında Bootstrap 5 tercih edilerek modern, mobil uyumlu ve kullanıcı dostu bir arayüz oluşturulmuştur. Bu projede öncelikli hedef, .NET Core teknolojileri ile bir admin panelli sistem kurmak ve Back-End geliştirme alanında güçlü bir altyapı sunmaktır. Front-End tarafında ise ileride yapılabilecek iyileştirmelere açık bir temel hazırlanmıştır. Bu proje sayesinde, modern yazılım geliştirme standartlarına uygun, yönetilebilir ve geliştirilebilir bir portfolyo sitesi ortaya çıkarılmıştır.

Projede genel anlamda 2 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in hakkımda, kategoriler, eğitimler, deneyimler, referanslar ve mesajlar gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı bölümdür.  
2- Ana Sayfa: Burada da Melih Çolak ve hayatı ile ilgili bilgiler yer alıyor.

Kullandığım Teknolojiler <br>
⚙️ ASP.NET Core 6.0 Web Application (MVC Yapısı) <br>
🛢️ Entity Framework Core (Code First) <br>
🎨 HTML5, CSS3, Bootstrap 5 ve JavaScript <br>
🗂️ Katmanlı yapı: Entities, Controllers, Models, Views <br>
🧩 ViewComponent kullanımı <br><br>

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Ana Sayfa
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/0c67d8a188bdd88b167afe8646fee30c5f4d09a1/default.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/c230f9573a7f8d80d41b4db93f516b2703a23894/ss2/contact2.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Admin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/about.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/category.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/contact.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/education.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/experience.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/jobtitle.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/message.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/portfolio.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/c230f9573a7f8d80d41b4db93f516b2703a23894/ss2/portfolio2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/services.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/skill.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/socialmedia.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/statistics.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/testimonial.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hata Sayfası
<div align="center">
  <img src="https://github.com/melihcolak0/My_Portfolio/blob/8ffe72118e72a838348e73590a77b33e9714aaac/ss/404.jpg" alt="image alt">
</div>
