﻿using System;
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
        /// <summary>путь к файлу</summary>
        internal readonly string path;

        /// <summary>список-контейнер для сериализации статистики</summary>
        public List<GameInfoContainer> Container = new List<GameInfoContainer>();

        public Statistics(string path)
        {
            this.path = path;
        }

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
        public void SerializeJson()
        {
            using (FileStream fileStream = File.Create(path))
            {
                JsonSerializer.Serialize(
                    utf8Json: fileStream, value: Container, options: options);
            }
        }

        /// <summary>
        /// Десериализация свойства Container класса Statistics
        /// </summary>
        public void DeserializeJson()
        {
            using (FileStream fileStream = File.OpenRead(path))
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
    public class GameInfoContainer: IComparable<GameInfoContainer>
    {
        /// <summary>количество попыток</summary>
        public int attempts;

        /// <summary>комбинация, которую нужно было отгадать</summary>
        public string combination;

        /// <summary>время, потраченное на то, чтобы отгадать комбинацию</summary>
        public double timeSpan;

        /// <summary>имя пользователя</summary>
        [JsonIgnore]
        public string userName = null;

        /// <summary>время, в которое была закончена игра</summary>
        public DateTime dateTime;

        public GameInfoContainer() { }

        public GameInfoContainer(int attempts, string combination, double timeSpan, DateTime dateTime)
        {
            this.attempts = attempts;
            this.combination = combination;
            this.timeSpan = timeSpan;
            this.dateTime = dateTime;
        }

        public override string ToString()
        {
            return $"{attempts}\t{combination}\t{timeSpan}";
        }

        public int CompareTo(GameInfoContainer gic)
        {
            if (gic is null) throw new Exception("Не удалось сравнить значения");
            return attempts - gic.attempts;
        }
    }
}
