using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using TestGenerator;

internal static class TestDataDeserializerHelpers
{
    public static string TestDataFilePath { get; private set; }

    public static Test Deserialize()
    {
        if (File.Exists(TestDataFilePath))
        {
            try
            {
                using (FileStream fs = new FileStream(TestDataFilePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    var testData = (Test)formatter.Deserialize(fs);
                    return testData;
                }
            }
            catch (SerializationException)
            {
            }
        }
        return null;
    }
}