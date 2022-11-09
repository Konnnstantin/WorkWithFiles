{
    string dirName = @"C:\Users\rekla\OneDrive\Desktop";
    string dirClear = @"C:\Users\rekla\OneDrive\Desktop\Test";
    var directoryClear = new DirectoryInfo(dirClear);
    var directory = new DirectoryInfo(dirName);
    Console.WriteLine($" Исходный размер папки: {DirectSize(directory)} байт");
    Console.WriteLine($" Очищено: {DirectSize(directoryClear)} байт");
    DirClear(directoryClear);
    Console.WriteLine($" Исходный размер папки: {DirectSize(directory)} байт");
}

static long DirectSize(DirectoryInfo direct)
{
    long size = 0;
    if (direct.Exists)
    {
        try
        {
            FileInfo[] files = direct.GetFiles();
            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            DirectoryInfo[] dirs = direct.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                size += DirectSize(d);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка пути {e.Message}");

        }
    }
    return size;
}
static void DirClear(DirectoryInfo clear)
{
    if (clear.Exists)
    {
        clear.Delete(true);
    }
    else
    {
        Console.WriteLine(" Каталог удален");
    }
}