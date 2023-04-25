namespace FileOperations
{
    internal class Program
    {
        const string PATH = @"C:\Users\asger\OneDrive\Masaüstü\Files\BDU\BB204\C#\FileOperations\FileOperations";
        static void Main(string[] args)
        {
            string folderName = Console.ReadLine();
            Directory.CreateDirectory(Path.Combine(PATH, folderName));

            int choice = 0;
            switch (choice)
            {
                case 1:

                    break;
            }

        }

        static void CreateFile(string fileName)
        {
            if (CheckFileIsExists(fileName))
                File.Create(Path.Combine(PATH, fileName));
        }

        static bool CheckFileIsExists(string fileName)
        {
            if (!File.Exists(Path.Combine(PATH, fileName))) return false;
            return true;
        }
    }
}