# ApsiyonProject
ApsiyonProject Patika apisyon bootcamp bitirme projesidir. Kullanım ve tasarım detayları aşağıda listelenmiştir.


Projenin Katmanları
-------
- core
   - ApsiyonProject.Application
   - ApsiyonProject.Domain
- infrastructure 
  - ApsiyonProject.Infrastructure
  - ApsiyonProject.Persistance  
- presentation  
  - ApsiyonProject.Presentation  
-paymentService
 - PaymentService


 ApsiyonProject.Domain = Projedeki tüm entitler burada tutuluyor.
 ApsiyonProject.Application = Projedeki tüm Interface, Dto, Mapping Configurasyonları burada tutuluyor.
 ApsiyonProject.Persistance= Projedeki tüm veritabanı operasyonları bu katmandan sağlanır.
 ApsiyonProject.Infrastructure= Projenin tüm operasyonlarının api servislerinin bulunduğu katmandır. Presantation katmanı işlemlerini bu sayfa üzerinden gerçekleştirir.
 ApsiyonProject.Presentation= Viewların ve ViewComponentlerin tutulduğu katmandır.
 PaymentService:Ödeme işlemlerinin yapıldığı api servisidir.
 
 DataBase İlişki Modeli
 -----------------
 HouseOwners tablosu hem site yöneticilerini hem de daire sahiplerini tutan tablodur. AdministratorId kolonu ile Id kolonuna self join yapılmıştır. Bu şekilde AdministratorId
 kolonu boş olan kayıtlar site yöneticileri anlamına gelirken AdministratorId kolonu dolu olan kayıtlar daire sahibi anlamına gelmektedir. İlişkiyi sırası ile lineerleştirmek 
 gerekirse öncelikle;
  
  HouseOwner oluşturulur (Yönetici) --> Site Eklenir(Site Durumu ve Tipi zorunlu seçilir)[1-n]-->Siteye Katlar Eklenir--> Katlara Daireler Eklenir(Daire Durumu ve Tipi zorunlu seçilir)-->Dairelere Ev Sahibi Eklenir(Yönetici Başka Kullanıcılar oluşturup dairelere atar)-->Ev Sahiplerine Fatura Eklenir / Ev sahiplerine Araç eklenir.

 Uygulama İçi Notlar
 -----------------
 - Apsiyon.Project uygulamasındaki tüm katmanlar veribatanı bağlantısı için ApsiyonProject.Infrastructure katmanının appsettings dosyasını kullanır.
 - Uygulamadaki Presentation katmanının controllerı direkt olarak veriyi api katmanından alır. api katmanı verileri UnitofWork paterni ile Persistance katmanından alır.
 - Site ve Daire Ekleme arayüzderlerinde tipi ve durum drop down listelerden seçilmelidir. Eğer kayıt yoksa oluştur butonunundan oluşturulmalıdır.
 - Presentation katmanı olabildiğinde viewcomponentlerle modal yapıda tasarlanmaya çalışılmıştır.
 
 
 
 
