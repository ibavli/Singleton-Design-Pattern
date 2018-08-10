# Singleton-Design-Pattern
Singleton Design Pattern


Singleton design pattern, bir sınıfın tek bir örneğini oluşturmak için kullanılır. Bunun amacı, oluşturulan nesneye global bir erişim noktası sağlamaktır. Oluşturduğumuz tek örnek, gelen tüm isteklere kendi üzerinden cevap verir. Sistem çalıştığı sürece, ikinci bir örnek oluşturmaz.

Singleton design pattern, deminde bahsettiğimiz gibi tek bir nesne oluşturmak istediğimiz zaman kullanırız. Config, Connection, Utility, Helper gibi her istemci için yeni bir örnek oluşturulan yerlerde ve yardımcı fonksiyonlarda bu kalıbı kullanmalıyız.

Dikkat edilmesi gereken bir nokta, eğer bu fonksiyonlar her kullanıcı için özel veri manipülasyonu yapacak veya bazı veriler saklayacaksa bu kalıbı kullanmamalıyız.

