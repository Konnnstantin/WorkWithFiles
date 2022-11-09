{
    string FilePath = @"C:\Users\rekla\OneDrive\Desktop\Test\Test1.txt";
    string FileDirectory = @"C:\Users\rekla\OneDrive\Desktop\Test\Test1";
    try
    {
        FileInfo fileInfo = new FileInfo(FilePath);
        if (fileInfo.Exists)
        {
            if (fileInfo.LastAccessTime.AddMinutes(30) < DateTime.Now)
            {
                fileInfo.Delete();
                Console.WriteLine("Файл удален");
            }
        }
        throw new Exception("файл не существует по данному пути");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(FileDirectory);
        if (directoryInfo.Exists)
        {
            if (directoryInfo.LastAccessTime.AddMinutes(30) < DateTime.Now)
            {
                directoryInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
        }
        throw new Exception("Каталог не существует по данному пути");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

