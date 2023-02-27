namespace Assignment3;
public class Originator
{
  public ShapesClass shapesClass;
  public Memento createMemento()
  {
    return new Memento(shapesClass);
  }

  public string getDetails(){
    return shapesClass.getDetails();
  }


}