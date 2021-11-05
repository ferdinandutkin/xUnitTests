namespace Tests;

public class TestData
{
    public string Input { get; set; }
    public string Expected { get; set; }
    public TestData(string input, string expected) => (Input, Expected) = (input, expected);
        
}