using System.Text.Json;

namespace Encinecarlos.CountryPedia.Application.Utils
{
    public static class JsonUtils
    {
        public static T DeserializeAnonymousType<T>(string jsonString, T anonymousObject) => JsonSerializer.Deserialize<T>(jsonString)!;
    }
}