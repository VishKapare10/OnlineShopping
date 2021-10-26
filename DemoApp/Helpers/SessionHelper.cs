using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DemoApp.Helpers
{
    public static class SessionHelper{

        // Serilaizing data into session

        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        //Deserializing data from session
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    } 
}