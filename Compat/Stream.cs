using System.IO;

public static class StreamExtension
{
    public static void CopyTo(this Stream source, Stream destination, int bufferSize = 81920)
    {
        byte[] array = new byte[bufferSize];
        int count;
        while ((count = source.Read(array, 0, array.Length)) != 0)
        {
            destination.Write(array, 0, count);
        }
    }
}