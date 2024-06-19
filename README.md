# News Application

Dotnet 8 kullanılarak 2 farklı endpointe istek atarak yazılmış basit bir haber sitesidir.


## News.Core
Tüm proje genelinde kullanılabilecek yapılarak burada tutulmuştur. 
Response : Servislerin tümü bu yapı kullanılarak cevap dönmüş, tüm projede bütünlük sağlanmıştır.
BaseDto  : Temel dto yapıları burada tutulmuştur.

## News.Dto
Projede kullanılailecek tüm dto sınıfları burada tutulur.

## News.Entities
Projede kullanılacak tüm model sınıfları burada tutulur.

## News.Services

### Abstract

1. INewsService
Haber servisine kalıtım vermesi amacıyla yazılmıştır.
İki farklı servis eklemiştir.
GetAllAsync: Tüm verileri çeker ve arayüz katmanına gönderir.
GetDetailAsync : Haber detayını çeker ve arayüz katmanına gönderir.
### Concrete
1. NewsManager
Haber servisidir. Haberler ile alakalı iş kodları bulunur.

GetAllAsync : Verilen api adresine istek atar ve bulunan 2 farklı listeyi birleştirerek tüm haber servisleri sayfalama yaparak döner. 

Arayüzden seçilen dropdown listesinden bir değer seçilir ve arama yapılır ise ilgili dataya göre filtreleme yapar.

Arayüzden yazılan metine göre haber başlıklarında arama yapar. Eğer varsa ilgili haberleri döner.
GetDetailAsync : İlgili api ye istek haberin detayını getirir.
### Extension
1. ServiceExtension
Sınıfları ve servisleri tek bir alana toplarak kolay yönetilmesini sağlıyoruz.

### Helpers
Apiye istek atmak için yardımcı bir sınıf yazıldı.

## News.Mvc
js, css dosyalarını tutmak için partialviewler oluşturuldu.

Haber ana sayfası için index ve haber detayı için detail sayfası oluşturuldu.

Script vs Css olarak iki farklı section oluşturuldu. Sayfa bazlı stillendirme yapıldı. 
Scriptler sadece çalışacak sayfaya göre yazıldı.
