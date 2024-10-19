using System.Numerics;

namespace ImageRecognition.models;

class Image
{
    private Guid id = Guid.NewGuid();
    private string imageHandle;
    private Vector<byte> imageData;


    public Image(string handle)
    {
        imageHandle = handle;
        byte[] data;

        try
        {
            using (FileStream fsIn = new FileStream(imageHandle,
                        FileMode.Open, FileAccess.Read))
            {
                var numBytesToRead = (int)fsIn.Length;
                data = new byte[numBytesToRead];

                var numBytesRed = 0;
                while (numBytesToRead > 0)
                {
                    var n = fsIn.Read(data, numBytesRed, numBytesToRead);

                    if (n == 0)
                        break;

                    numBytesRed += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = data.Length;
            }

            imageData = new Vector<byte>(data);
        }
        catch (FileNotFoundException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }

    public void TestDisplayData()
    {
        Console.WriteLine(imageData);
    }

    public void ExportData()
    {
        try
        {
            using (var fsOut = new FileStream(imageHandle, FileMode.CreateNew, FileAccess.Write))
            {

            }

        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.Message);
        }
    }
}
