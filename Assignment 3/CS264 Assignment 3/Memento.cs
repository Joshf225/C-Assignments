namespace Assignment3;

public class Memento
{
  public ShapesClass shapesClass { get; set; }
  public ShapesClass canvas { get; set; }

  public Memento(ShapesClass shapesClass)
  {
    this.shapesClass = shapesClass;
  }

  public string getDetails()
  {
    return shapesClass.getDetails();
  }
}