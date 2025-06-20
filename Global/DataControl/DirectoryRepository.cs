using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Global.DataControl
{
    public abstract class DirectoryRepository<T> where T : IObject
    {
        //protected virtual string FilePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //    "Vibe",
        //    "Data",
        //    $"{typeof(T).Name}Data.json");
        protected virtual string FilePath => Path.Combine($"{typeof(T).Name}Data.json");

        public virtual List<T> Objects { get; protected set; }

        public virtual void Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    Objects = new List<T>();
                    Console.WriteLine($"Файл {FilePath} не знайдено. Створено пусту колекцію.");
                    return;
                }

                string directory = File.ReadAllText(FilePath);
                Objects = JsonConvert.DeserializeObject<List<T>>(directory) ?? new();

                if (Objects.Count == 0)
                {
                    Console.WriteLine($"Файл {FilePath} порожній. Створено пусту колекцію.");
                }
                else
                {
                    Console.WriteLine($"Завантажено {Objects.Count} об'єктів з {FilePath}.");
                }

                if (Objects != null)
                    Console.WriteLine($"Завантажено {typeof(T).Name}: Count = {Objects.Count}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка при завантаженні файлу {FilePath}: {exception.Message}");
                Objects = new List<T>();
            }
        }

        public virtual void Save()
        {
            Console.WriteLine($"Збереження {typeof(T).Name}. Count = {Objects.Count}");

            try
            {
                EnsureDirectoryExists(FilePath);

                string? directory = JsonConvert.SerializeObject(Objects, Formatting.Indented);

                File.WriteAllText(FilePath, directory);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка при збереженні файлу {FilePath}: {exception.Message}");
            }
        }

        private void EnsureDirectoryExists(string filePath)
        {
            string? directory = Path.GetDirectoryName(filePath);

            try
            {
                if (directory != null && !System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                    Console.WriteLine($"Створено теку для збереження: {directory}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при створенні теки {Path.GetDirectoryName(filePath)}: {ex.Message}");
            }
        }
    }
}
