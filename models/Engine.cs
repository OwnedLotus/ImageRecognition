using System.Numerics;


namespace ImageRecognition.models;


// The dataset comes from the github project
// https://github.com/zalandoresearch/fashion-mnist.git
class Engine
{
    private List<Vector<byte>> dataset;
    private List<Classification> dataClassification;
    private enum Classification
    {
        TShirt,
        Trouser,
        Pullover,
        Dress,
        Coat,
        Sandal,
        Shirt,
        Sneaker,
        Bag,
        AnkleBoot
    }

    public Engine()
    {
        dataset = new();
        dataClassification = new();
    }

    public void AddDataSetSingle(Vector<byte> data)
    {
        dataset.Add(data);
    }

    public void AddDataSetMultiple(IEnumerable<Vector<byte>> dataValues)
    {
        foreach (var data in dataValues)
        {
            dataset.Add(data);
        }
    }
}

