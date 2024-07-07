namespace ImageRecognition.models;

class ImageSet
{
    private Image[] images;
    private string[] names;

    public ImageSet(string path)
    {
        names = Directory.GetFiles(path);
        images = new Image[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
            images[i] = new Image(names[i]);
        }
    }

    public void DisplayAllData()
    {
        foreach (var image in images)
        {
            image.TestDisplayData();
        }
    }
}
