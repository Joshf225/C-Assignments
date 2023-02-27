namespace Assignment3;

public class ShapesClass
{
  public string temp_shape { get; set; }

  public ShapesClass(string temp_shape)
  {
    this.temp_shape = temp_shape;
  }

  public string getDetails()
  {
    return temp_shape;
  }
}