// Åsa Forss     2012-05-18  DALLibrary

 using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
public class DataAccess
{
    public DataAccess()
    {
    }
    /// <summary>
    ///  Method for Serialisation taken mostly from .NET Fortsättningskurs documentation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public T binaryFileDeSerialize<T>(string filePath)
    {
        FileStream fileStream = null;
        T obj;
        try
        {
            if (File.Exists(filePath) == false)
                throw new FileNotFoundException("The file" + " was not found.", filePath);
            fileStream = new FileStream(filePath, FileMode.Open);
            fileStream.Position = 0;
            BinaryFormatter bFormatter = new BinaryFormatter();
            obj = (T)bFormatter.Deserialize(fileStream);
        }
        catch
        {
            throw;
        }
        finally
        {
            if (fileStream != null)
                fileStream.Close();
        }
        return obj;
    }



    /// <summary>
    /// Method for Serialisation taken mostly from .NET Fortsättningskurs documentation
    /// lite tips från http://social.msdn.microsoft.com/Forums/en-US/netfxremoting/thread/45da4a13-ba81-42f3-bd92-ee2ec0159455
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public void binaryFileSerialize(Object obj, string filePath)
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        try
        {
            formatter.Serialize(fileStream, obj);
        }
        catch (Exception)
        {
            throw;

        }
        finally
        {
            if (fileStream != null)
                fileStream.Close();
        }

    }
}