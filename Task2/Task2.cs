{
    string dirName = @"C:\Users\rekla\OneDrive\Desktop\Test";
    try
    {
        var directory = new DirectoryInfo(dirName);
        Console.WriteLine($" Размер {DirectSize(directory)} байт ");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не удалось рассчитать размер {ex.Message}");
    }
}
static long DirectSize(DirectoryInfo direct)
{
    long size = 0;
    if (direct.Exists)
    {
        FileInfo[] files = direct.GetFiles();
        foreach (FileInfo file in files)
        {
            size += file.Length;
        }
        DirectoryInfo[] directs = direct.GetDirectories();
        foreach (DirectoryInfo d in directs)
        {
            size += DirectSize(d);
        }
    }
    return size;
}

