using Newtonsoft.Json;
using AlquileresAutos.Models;

namespace AlquileresAutos.Services
{
    public static class ManejoDeSesion
    {
        public static void JsonSet<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T JsonGet<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            var objeto = JsonConvert.DeserializeObject<T>(value);
            return objeto;
        }
    }
}
