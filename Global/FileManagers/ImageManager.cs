using System.Drawing.Imaging;

namespace Course.Global.FileManagers;

public static class ImageManager
{
    private static string _path => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "Vibe",
        "Images"
    );

    public static string SaveImage(Image image, string objectId, string objectType)
    {
        if (image == null)
        {
            Console.WriteLine("Попередження: Спроба зберегти null зображення.");
            return "";
        }

        if (string.IsNullOrEmpty(objectId) || string.IsNullOrEmpty(objectType))
        {
            Console.WriteLine("Помилка: Неможливо зберегти зображення без ID або типу об'єкта.");
            throw new ArgumentException("ObjectID and ObjectType must be provided to save image.");
        }

        string fileName = $"{objectId[..8]}_{objectType}.png";
        string fullPath = Path.Combine(_path, fileName);

        try
        {
            EnsureImagesDirectoryExists();

            image.Save(fullPath, ImageFormat.Png);

            Console.WriteLine($"Зображення успішно збережено: {fullPath}");

            return fullPath;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Помилка при збереженні зображення {fullPath}: {exception.Message}");
            throw;
        }
    }

    public static void DeleteImage(string imagePath)
    {
        if (string.IsNullOrEmpty(imagePath))
        {
            Console.WriteLine("Попередження DeleteImage: Шлях до зображення для видалення не надано.");
            return;
        }

        try
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                Console.WriteLine($"Зображення успішно видалено: {imagePath}");
            }
            else
            {
                Console.WriteLine($"Попередження DeleteImage: Файл не знайдено за шляхом {imagePath}.");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Помилка при видаленні зображення за шляхом {imagePath}: {exception.Message}");
            throw;
        }
    }

    public static string GetImagePath(string objectId, string objectType)
    {
        if (string.IsNullOrEmpty(objectId) || string.IsNullOrEmpty(objectType))
        {
            Console.WriteLine("Помилка GetImagePath: ID або тип об'єкта не може бути null або порожнім.");
            throw new ArgumentException("ObjectID and ObjectType must be provided.");
        }

        string fileName = $"{objectId[..8]}_{objectType}.png";
        string fullPath = Path.Combine(_path, fileName);

        return fullPath;
    }

    //private static string SanitizeFileName(string input) // На майбутнє
    //{
    //    return "";
    //}

    private static void EnsureImagesDirectoryExists()
    {
        string directoryPath = _path;

        if (!System.IO.Directory.Exists(directoryPath))
        {
            try
            {
                System.IO.Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Створено теку для зображень: {directoryPath}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка при створенні теки {directoryPath}: {exception.Message}");
                throw;
            }
        }
    }
}

