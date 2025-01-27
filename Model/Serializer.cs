using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Nodes;

namespace ToDoList.Model
{
    /// <summary>
    /// Класс отвечающий за запись данных в файл.
    /// </summary>
    internal class Serializer
    {
        /// <summary>
        /// Путь к системной папке AppData.
        /// </summary>
        private static string DataPath = /*"C:\\Games\\ToDoList"; */ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ToDoList.txt";

        /// <summary>
        /// Метод отвечающий за создание файла в системной папке.
        /// </summary>
        public static void CreateFile()
        {
            //File.Create(DataPath);
        }

        /// <summary>
        /// Метод отвечающий за загрузку данных из файла.
        /// </summary>
        /// <returns>Список объектов класса <see cref="Tasks"/>.</returns>
        public static List<Tasks> LoadData()
        {

            //var jsonObject = File.ReadAllText(DataPath);

            StreamReader sr = new StreamReader(DataPath);
            var jsonObject = sr.ReadLine();
            sr.Close();

            var Tasks = JsonConvert.DeserializeObject<List<Tasks>>(jsonObject);

            return Tasks;
        }

        /// <summary>
        /// Метод отвечающий за запись данных в файла.
        /// </summary>
        /// <param name="Tasks"> Список объектов класса <see cref="Tasks"/> для записи.</param>
        public static void WriteData(List<Tasks> Tasks)
        {
            var jsonObject = JsonConvert.SerializeObject(Tasks);

                //File.WriteAllText(DataPath, jsonObject);
                StreamWriter sw = new StreamWriter(DataPath);
                sw.WriteLine(jsonObject);
                sw.Close();

        }
    }
}
