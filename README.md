# ApsiyonProject
ApsiyonProject Patika apsiyon bootcamp bitirme projesidir. Kullanım ve tasarım detayları aşağıda listelenmiştir.


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
- paymentService
  - PaymentService
 
 
----------------------------

 - ApsiyonProject.Domain = Projedeki tüm entitler burada tutuluyor. 
 - ApsiyonProject.Application = Projedeki tüm Interface, Dto, Mapping Configurasyonları burada tutuluyor. 
 - ApsiyonProject.Persistance= Projedeki tüm veritabanı operasyonları bu katmandan sağlanır. 
 - ApsiyonProject.Infrastructure= Projenin tüm operasyonlarının api servislerinin bulunduğu katmandır. Presantation katmanı işlemlerini bu sayfa üzerinden gerçekleştirir. 
 - ApsiyonProject.Presentation= Viewların ve ViewComponentlerin tutulduğu katmandır. 
 - PaymentService:Ödeme işlemlerinin yapıldığı api servisidir.
 
  Kurulum
 -----------------
 - Database tablolarını oluşturmak için configurasyon dosyası ApsiyonProject.Infrastructure katmanının appsettings dosyasında tutuluyor ve tüm diğer katmanlar
   db erişimleri için bu connection string'i refereasn alıyor. Sqlserver'ızın connection string bilgilerini bu alanda tanımlanması gerekiyor. 
   
    ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/Setup.png?raw=true)
 - Sonraki aşamada daha zahmetsiz bir kurulum için Migration classlarını silip package manager'da migration ve database operasyonlarını gerçekleştirebilirsiniz.
 - Normal şartlarda karşılaşılmaz ama Presentation katmanı farklı bir dizine kopyalanmış ise ApsiyonProject.Presentation katmanının Start up Class'ında da düzenlenmesi 
   gereken bir path adresi bulunuyor.
   
    ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/Setup2.png?raw=true)
    
 DataBase İlişki Modeli
 -----------------
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/DbModel.png?raw=true)
 
 HouseOwners tablosu hem site yöneticilerini hem de daire sahiplerini tutan tablodur. AdministratorId kolonu ile Id kolonuna self join yapılmıştır. Bu şekilde AdministratorId
 kolonu boş olan kayıtlar site yöneticileri anlamına gelirken AdministratorId kolonu dolu olan kayıtlar daire sahibi anlamına gelmektedir. İlişkiyi sırası ile lineerleştirmek 
 gerekirse öncelikle;
  
  HouseOwner oluşturulur (Yönetici) --> Site Eklenir(Site Durumu ve Tipi zorunlu seçilir)[1-n]-->Siteye Katlar Eklenir--> Katlara Daireler Eklenir(Daire Durumu ve Tipi zorunlu seçilir)-->Dairelere Ev Sahibi Eklenir(Yönetici Başka Kullanıcılar oluşturup dairelere atar)-->Ev Sahiplerine Fatura Eklenir / Ev sahiplerine Araç eklenir.

 Uygulama İçi Notlar
 -----------------
 - Apsiyon.Project uygulamasındaki tüm katmanlar veribatanı bağlantısı için ApsiyonProject.Infrastructure katmanının appsettings dosyasını kullanır.
 - Uygulamadaki Presentation katmanının controllerı direkt olarak veriyi api katmanından alır. api katmanı verileri UnitofWork paterni ile Persistance katmanından alır.
 - ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/Api.png?raw=true)
 - Site ve Daire Ekleme arayüzlerinde tipi ve durum kolonu drop down listelerinden seçilmelidir. Eğer kayıt yoksa oluştur butonundan oluşturulmalıdır.
 - Presentation katmanı olabildiğinde viewcomponentlerle modal yapıda tasarlanmaya çalışılmıştır.
 
  Uygulama İçi Ekran Görüntüleri
   -----------------
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AccountIndex.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddBuildingStatus.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddBuildingType.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddBuilding.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddFlatStatus.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddFlatType.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddFlat.png?raw=true)
 ![alt text](https://github.com/emretuna01/ApsiyonProject/blob/main/img/AddHouseOwner.png?raw=true)
      
