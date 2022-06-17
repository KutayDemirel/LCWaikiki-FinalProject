![](https://github.com/KutayDemirel/Csharp/blob/main/Images/MiniCommerce.jpg)
<hr>

LC Waikiki ve Patika.dev iş birliği ile yapılan **LC Waikiki .Net Bootcamp** 'inin bitirme projesi olarak **LCW Mini Commerce** adlı uygulamayı geliştirdim.

### 1-Kullanıcı Rolü 

* :shopping: **Ürün görüntüleme İşlemleri :** Kullanıcı bu sayfada giriş yapmadan ürünleri görüntüleyebilir. Kategoriye göre ürünleri listeleyebilir. İnceleme, satın alma, teklif verme işlemleri için giriş yapma sayfasına yönlendirilir.
* :newspaper: **Üye Olma İşlemleri :** Kullanıcı gerekli validasyonları sağladığında **LCW Mini Commerce** sitesine kayıt olabilir.
* :door: **Üye Giriş İşlemleri :** Kullanıcı'nın **LCW Mini Commerce** sitesine girişini sağlar, kullanıcı'nın hatalı girdileri ekrana yansıtılır.
* :tshirt: **Ürün Listeleme İşlemleri :** Ürünler stok durumlarına göre listelenir. Kategoriye göre listeleme mevcuttur. Ürün teklif verilmeye açıksa teklif verilebilir. Satın alınan ürünler'de teklif verme veya satın alma işlemi gerçekleştirilemez
* :man: **Kullanıcı İşlemleri :** Kullanıcı  **LCW Mini Commerce** aracılığı ile Hesabım, Ürün Ekleme, Çıkış sayfalarına erişebilir. Ürünlerin detaylarına bakabilir. Satın alma veya teklif verme işlemlerini ürünlerin aktiflik durumlarına göre yapabilir.
* :calling:  **Hesabım Sayfası İşlemleri** : Kullanıcı  **LCW Mini Commerce** aracılığı ile bütün eklediği ürünleri görüntüleyebilir, durumlarını gözlemleyebilir. Yaptığı teklifleri ve aldığı teklifleri görüntüleyebilir. Aldığı teklifleri onaylayıp ürün fiyatını teklif yapan kişi için otomatik günceller, reddebilir. Verdiği teklifler onaylanmışsa ürünü satın alabilir veya tekliflerini geri çekebilir.
* :speaking_head:  **Teklif Yapma İşlemleri** : Kullanıcı  **LCW Mini Commerce** aracılığı ile teklif yapılabilen ürünlere hazırlanmış yüzdelik teklifler yapabilir veya kendi istediği teklifi girebilir. Teklif yapmak için seçtiği bir alan ötekini etkisiz hale getirir.
* :money_with_wings:  **Satın Alma İşlemleri** : Kullanıcı  **LCW Mini Commerce** aracılığı ile ürün detaylarından ulaştığı satın alma işlemini pop-up penceresiyle gerçekleştirir. Teklif üzerinden veya ürün üzerinden ulaştığı satın alma işlemini detayları görüntüleyerek gerçekleştirir.
* :bookmark:  **Ürün Ekleme İşlemleri** : Kullanıcı  **LCW Mini Commerce** aracılığı ile kendi ürününü ekleyebilir. Resim, kategori, kullanım durumu gibi alanlar listeden seçilir veya elle girilir. Marka ve renk gibi alanlar liste içerisinden boş seçilebilir.

---
**Diagram**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/Diagram.png)
---
**Üye Ol**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/Video_220617005324.gif)
---
**Giriş Yap ve Satın Al**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/Login.gif)
---
**Teklif Yap ve Kategoriye Göre Ürün Getir**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/Offer.gif)
---
**Hesabım, Teklifleri Değerlendir**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/OfferResponse.gif)
---
**Ürün Ekle**
---
![](https://github.com/KutayDemirel/Csharp/blob/main/Images/AddProduct.gif)

  ## :computer: Projenin Kurulumu
  Proje’yi çalıştırmak için PostgreSql veya Docker üzerinden PostrgeSql Image' dosyasının bilgisayarımızda yüklü ve çalışıyor olması gerekmektedir.
  Node.js bilgisayarınızda yüklü olmalıdır.
  MiniCommerce.API katmanı üzerinden 'appsettings.json' dosyası içindeki connection stringle kendi database'inize bağlanabilirsiniz
  ```
  "ConnectionStrings": {
    "DefaultConnection": "User ID=(DatabaseUserBuraya(postgres));Password=(ŞifreBuraya);Host=(HostIp veya 'localhost');Port=(PortNumarası(5432));Database=MiniCommerceDb;Integrated Security=true;Pooling=true"
  },
  ```
  (Postgresql ile Docker Container şifrelerinin aynı olmasına dikkat edilmeli)
  Başlangıç projemizi **MiniCommerce.API** olarak belirledikten sonra package manager console’umuzda varsayılan projemizi **MiniCommerce.Persistence** olarak belirliyor ve **update-database** komutunu giriyoruz. Bu noktadan sonra Api üzerinde [https://localhost:44381/swagger/index.html] portunda inceleme yapabilirsiniz.MVC projesi bağlantısı için konsol üzerinden 'npm install' ve 'npm start' komutları girilmeli. Son olarak projeyi çalıştırmak için Solution dosyası üzerinden **Multiple Start-Up** projesi seçilerek **MiniCommerce.API** ve **MiniCommerce.UI** aynı anda işaretlenmelidir. Start butonuyla [https://localhost:44359/] portu üzerinden üyelik alabilir ve siteyi keşfedebilirsiniz.  
  
<h2> 🛠 &nbsp;Kullanılan Teknolojiler</h2>

<table style"float:right;">
  <tr>
    <td><img src="https://img.shields.io/badge/-ASP.NETCore-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
    <td><img src="https://img.shields.io/badge/-MVC-5C2D91?logo=.net"/></td>
    <td><img src="https://img.shields.io/badge/-EntityFramework-5C2D91?style=flat&logo=.net&logoColor=white"/></td>  
    <td><img src="https://img.shields.io/badge/PostgreSQL-316192?logo=postgresql&logoColor=white"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-FluentValidation-CC2927?style=flat-square&logo=.net&logoColor=ffffff"/></td>
    <td><img src="https://img.shields.io/badge/-AutoMapper-5C2D91?style=flat&logo=.net&logoColor=white"/</td>  
    <td><img src="https://img.shields.io/badge/-IdentityCore-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
    <td><img src="https://img.shields.io/badge/-Docker-61DAFB?logo=docker"/></td> 
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Github-black?style=flat&logo=github"/></td>
    <td> <img src="https://img.shields.io/badge/-Git-black?style=flat&logo=git"/></td>   
    <td><img src="https://img.shields.io/badge/-JavaScript-black?style=flat&logo=javascript"/></td>
    <td><img src="https://img.shields.io/badge/-npm-CB3837?logo=npm"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Bootstrap-563D7C?style=flat&logo=bootstrap"/></td>
    <td><img src="https://img.shields.io/badge/-HTML5-E34F26?style=flat&logo=html5&logoColor=white"></td>
 		<td><img src="https://img.shields.io/badge/-CSS3-1572B6?style=flat&logo=css3"/></td>
    <td><img src="https://img.shields.io/badge/-json-02569B?style=flat&logo=json"/></td>
  </tr>

</table>




## :phone: İletişim


<img style="width:50%;" justify-content="center" src="https://raw.githubusercontent.com/TanZng/TanZng/master/assets/hollor_knight3.gif" width="200"/>                                               
 <details align="center">
   <summary><b> <samp> İletişime Geçin </samp></b></summary>
   <br>
   <samp>
     <b><h2 style="color: #fc6203">KUTAY &nbsp; DEMİREL</h2></b>
     <br>
     Projenin Linki: <a href="https://github.com/KutayDemirel/LCWaikiki-FinalProject">LCW Mini Commerce</a>
     <br>
     <br>
     LinkedIn: <a href="https://www.linkedin.com/in/kutaydemirel/"> LinkedIn Hesabım</a>
     <br>
     Instagram: <a href="https://www.instagram.com/kutaydemirel/"> Instagram Hesabım</a>
     <br>
      Mail Adresim: <a href="#"> kty.demirel@gmail.com</a>
   </samp>
 </details>
