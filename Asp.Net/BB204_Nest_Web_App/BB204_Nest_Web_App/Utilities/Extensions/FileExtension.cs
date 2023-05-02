namespace BB204_Nest_Web_App.Utilities.Extensions;

public static class FileExtension
{
    public static bool CheckFileType(this IFormFile file, string fileType)
    {
        return file.ContentType.Contains(fileType + "/");
    }
    public static bool CheckFileSize(this IFormFile file, int size)
    {
        return file.Length / 1024 > size;
    }

    public static async Task<string> SaveFileAsync(this IFormFile file, string root, string mainPath)
    {
        string uniqeFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
        string path = Path.Combine(root, "assets", "imgs", mainPath, uniqeFileName);

        FileStream stream = new FileStream(path, FileMode.Create);

        await file.CopyToAsync(stream);
        return uniqeFileName;
    }

}
