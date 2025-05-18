// See https://aka.ms/new-console-template for more information
using Microsoft.Xna.Framework.Content.Pipeline;


public class TestLog : ContentBuildLogger
{
    public override void LogImportantMessage(string message, params object[] messageArgs)
    {
        Console.WriteLine("IMPORTANT " + message);
    }

    public override void LogMessage(string message, params object[] messageArgs)
    {
        Console.WriteLine("MESSAGE " + message);
    }

    public override void LogWarning(string helpLink, ContentIdentity contentIdentity, string message, params object[] messageArgs)
    {
        Console.WriteLine("WARNING " + message);
    }
}

public class TestImp : ContentImporterContext
{
    public override string IntermediateDirectory => "";

    public override ContentBuildLogger Logger => new TestLog();

    public override string OutputDirectory => "";

    public override void AddDependency(string filename)
    {

    }
}

public class Program
{
    public static void Main()
    {
        OpenAssetImporter importer = new OpenAssetImporter();
        var result = importer.Import(
            @"C:\Users\mitch\Documents\Repositories\Arcturus\Arcturus\Arcturus\Content\worm.fbx",
            new TestImp()
        );


    }
}
