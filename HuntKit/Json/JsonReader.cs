using Newtonsoft.Json;

namespace HuntKit.Json
{
    public class JsonReader
    {
        public static async Task<T> ReadJsonAsync<T>(string filePath)
        {
            var json = await File.ReadAllTextAsync(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                throw new JsonException("JSON content is empty.");
            }

            T result = await Task.Run(() => JsonConvert.DeserializeObject<T>(json)) ?? throw new JsonException("Deserialization returned null.");

            return result;
        }


    }
}

