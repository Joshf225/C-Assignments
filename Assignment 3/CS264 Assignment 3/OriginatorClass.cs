namespace Assignment3;
public class Originator
{
  public ShapesClass shapesClass;
  public Memento createMemento()
  {
    return new Memento(shapesClass);
  }

  public void setMemento(Memento memento)
  {
    shapesClass = memento.shapesClass;
  }

  public string getDetails(){
    return shapesClass.getDetails();
  }


}