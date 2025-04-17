BlogProjeCore7.0
BlogProjeCore7.0, ASP.NET Core 7.0 ve Entity Framework Core kullanarak geliştirilmiş bir blog platformudur. Kullanıcılar, kategoriler, yazılar ve iletişim gibi çeşitli içerikleri yönetebilir. Admin paneli üzerinden blog yazıları ve kullanıcılar üzerinde tam kontrol sağlanabilir. Ayrıca, blog yazılarının listelenmesi ve detayları gibi kullanıcı dostu bir ön yüz de sunulmaktadır.

Özellikler
Admin Paneli: Kategoriler, yazılar ve kullanıcılar üzerinde CRUD (Create, Read, Update, Delete) işlemleri yapılabilir.

Kategoriler: Yazılar kategorilere ayrılabilir ve kategorilere özel içerik görüntülenebilir.

Yazılar (Posts): Blog yazıları oluşturulabilir, düzenlenebilir ve silinebilir.

Kullanıcı Yönetimi: Kullanıcılar admin tarafından yönetilebilir.

İletişim Formu: Kullanıcılar site üzerinden iletişim kurabilir.

Responsive Tasarım: Web sitesi her cihazda sorunsuz çalışacak şekilde tasarlanmıştır.

Proje Yapısı
Areas/Admin: Yönetim paneline ait controller'lar ve view'lar.

Controllers: CategoriesController, PostsController, UsersController gibi admin paneli için gerekli olan controller'lar yer alır.

Views: Kategoriler, yazılar, kullanıcılar ve iletişim sayfalarının görünümleri (Create, Edit, Delete, Index vb.).

Controllers: Blog'un genel işlevlerini yöneten controller'lar.

HomeController: Ana sayfa işlevleri.

LoginController: Kullanıcı girişi işlemleri.

PostsController: Blog yazıları yönetimi.

Data: Veritabanı bağlantısı ve Entity Framework Core ile veritabanı işlemleri gerçekleştiren context dosyaları.

Entities: Uygulamanın veritabanı modelleri (Category, Contact, Post, User).

Migrations: Veritabanı şeması değişikliklerini takip eden migration dosyaları.

Models: Hata ve veri taşımak için kullanılan modeller (ErrorViewModel).

wwwroot: Statik dosyalar (CSS, JS, resimler vb.) içerir.

Kullanılan Teknolojiler
ASP.NET Core 7.0: Uygulamanın temel altyapısı.

Entity Framework Core: Veritabanı işlemleri ve ORM (Object-Relational Mapping) için kullanılır.

SQL Server: Veritabanı yönetim sistemi olarak kullanılmıştır.

HTML5, CSS3, JavaScript: Web sayfasının ön yüzü için.
