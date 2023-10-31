using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.IO;

namespace BullsAndCows
{
    [Serializable]
    public class Statistics
    {
        /// <summary>список-контейнер для сериализации статистики</summary>
        public List<GameInfoContainer> Container = new List<GameInfoContainer>();

        public Statistics() { }

        /// <summary>параметры JSON сериализации</summary>
        [JsonIgnore]
        private JsonSerializerOptions options = new JsonSerializerOptions()
        {
            IncludeFields = true, //включает в себя все поля
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //для сохранения не escape-последовательностей, а привычных RU букв
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

        /// <summary>
        /// Cериализация свойства Container класса Statistics
        /// </summary>
        /// <param name="fileName">путь к файлу .json</param>
        public void SerializeJson(string fileName)
        {
            using (FileStream fileStream = File.Create(fileName))
            {
                JsonSerializer.Serialize(
                    utf8Json: fileStream, value: Container, options: options);
            }
        }

        /// <summary>
        /// Десериализация свойства Container класса Statistics
        /// </summary>
        /// <param name="fileName">путь к файлу .json</param>
        public void DeserializeJson(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(fileName))
            {
                //в случае если в файле имеются данные, то выполняется десериализация
                if (fileStream.Length != 0)
                {
                    List<GameInfoContainer> cont = JsonSerializer.Deserialize<List<GameInfoContainer>>(
                        fileStream, options);
                    Container = cont;
                }
            }
        }
    }

    /// <summary>
    /// включает в себя поля, необходимые для сериализации
    /// </summary>
    [Serializable]
    public class GameInfoContainer
    {
        /// <summary>количество попыток</summary>
        public int attempts;

        /// <summary>комбинация, которую нужно было отгадать</summary>
        public int combination;

        /// <summary>имя пользователя</summary>
        [JsonIgnore]
        public string userName = null;

        public GameInfoContainer() { }

        public GameInfoContainer(int attempts, int combination)
        {
            this.attempts = attempts;
            this.combination = combination;
        }

        public override string ToString()
        {
            return $"{attempts}\t{combination}";
        }
    }
}
