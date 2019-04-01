# Singleton-Design-Pattern

### Çalışma Mantığı
Singleton design pattern, bir sınıfın tek bir örneğini oluşturmak için kullanılır. Bunun amacı, oluşturulan nesneye global bir erişim noktası sağlamaktır. Oluşturduğumuz tek örnek, gelen tüm isteklere kendi üzerinden cevap verir. Sistem çalıştığı sürece, ikinci bir örnek oluşturmaz. Sınıf örneği new operatörü ile alınamaz. Geliştirilen teknik ile sınıf ilk çağrıldığın anda statik örnek oluşturulur ve bundan sonraki çağırımlarda tüm istemcilere aynı örnek gönderilir. Burada **dikkat edilmesi gereken nokta**, çok istemcili sistemlerde ilk örnek oluşturulurken güvenli örnekleme yapılması ve oluşturulacak objenin kilitlenmesidir.

Kilitleme yapılmaz ve güvenli hale getirilmez ise elimizde birden fazla örnek olmuş olur. Bunun sebebi iki farklı **thread**'in birbirine çok yakın zamanlarad singleton sınıfını çağırması ve işlemci mimarisi gereği önce biri sonra diğerini çağırıldığında iki **thread** birbirinin sonucuna ulaşamadan yeni örneklendirme yapmasıdır.
Sistemimiz çoklu istemciye hizmet vermeyecekse bu önlemi almamıza gerek yoktur.
Singleton design pattern, deminde bahsettiğimiz gibi tek bir nesne oluşturmak istediğimiz zaman kullanırız. Config, Connection, Utility, Helper gibi her istemci için yeni bir örnek oluşturulan yerlerde ve yardımcı fonksiyonlarda bu kalıbı kullanmalıyız.

Dikkat edilmesi gereken bir nokta, eğer bu fonksiyonlar her kullanıcı için özel veri manipülasyonu yapacak veya bazı veriler saklayacaksa bu kalıbı kullanmamalıyız.

### Ne zaman kullanılır?

Sistem üzerinde tek bir nesne oluşturmak istediğimizde kullanırız. Connection gibi her istek başına yeniden açılan ve sistem kaynağı tüketen sınıflarda istek başına örnek açmaktansa tek örnek üzerinden bağlantıyı kontrol etmek istediğimizde kullanırız. Bir başka örnek olarak bir web sitesine anlık giren ziyaretçi sayısının kaç olduğunu tutmak istediğimizde kullanabiliriz.

**Not :** Eğer işlemimiz her kullanıcı için özel veri manipülasyonu yapacak veya bazı veriler saklayacaksa bu kalıbı kullanmamalıyız. Örnek verecek olursak, kullanıcı adını singleton sınıfımızın içine yazıp, daha sonra onu uygulamamızın içinde kullanırsak, sisteme giriş yapmış ikinci kişi için ilk kullanıcının kullanıcı adını göndermiş oluruz.

### Ne zaman kullanılmaz?

Singleton design pattern ile bir nesne ürettiğimiz zaman, o bellekte her zaman sabit kalır. (Başka yöntemlerle sonlandırmadığınız sürece).  Dikkat etmemiz gereken biz bu singleton ile ürettiğimiz nesneyi herkes yoğun ölçüde kullanacak mı? Uygulama da o nesneyi sadece bir kullanıcı günde bir kere isteyip, sonra günlerce istemiyorsa bunu singleton olarak üretmemeliyiz.

