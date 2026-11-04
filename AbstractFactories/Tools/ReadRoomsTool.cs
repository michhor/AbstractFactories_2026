namespace AbstractFactories.Tools;

public static class ReadRoomsTool
{
    public static string[] ReadRooms(string path)
    {
        var arrayResult = File.ReadAllLines(path);
        return arrayResult;
    }
}