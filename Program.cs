using ImageRecognition.models;

var temp = new Image("data/text.txt");

temp.TestDisplayData();

var input = new float[] { 1.2f, 5.1f, 2.1f };
var weight = new float[] { 3.1f, 2.1f, 8.7f };
var bias = 3;

var output = input[0] * weight[0] + input[1] * weight[1]
        + input[2] * weight[2] + bias;

Console.WriteLine(output);
