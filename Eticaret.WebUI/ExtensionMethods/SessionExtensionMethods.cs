using Newtonsoft.Json;// JSON formatına dönüştürmek için Newtonsoft.Json kütüphanesini kullanıyoruz.
namespace Eticaret.WebUI.ExtensionMethods
{
    public static class SessionExtensionMethods // Session işlemleri için genişletme metotlarını içeren static bir sınıf oluşturuyoruz.
    {
        public static void SetJson(this ISession session, string key, object value)// 📌 Session'a JSON formatında veri ekleyen metod
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
            // `value` nesnesini JSON formatına çeviriyoruz.
            // Daha sonra `SetString` ile Session içine JSON string olarak kaydediyoruz.
        }
        public static T? GetJson<T>(this ISession session, string key) where T : class // 📌 Session'dan JSON formatında veriyi okuyan metod
        {
            var data = session.GetString(key);// Session'dan belirtilen anahtar (key) ile veriyi string olarak alıyoruz.


            return data == null ? default(T) : JsonConvert.DeserializeObject<T>(data);
            // Eğer veri yoksa `default(T)` döndürülüyor (null olabilir).
            // Eğer veri varsa JSON stringini orijinal nesneye çevirerek döndürüyoruz.
        }
    }
}
