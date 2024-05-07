using FileReader.Core;
using FileReader.Core.Interface;

namespace FileReader;

public static class Program
{
    public static void Main()
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}

