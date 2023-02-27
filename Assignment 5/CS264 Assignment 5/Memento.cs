namespace Assignment5;

//Command code from Assignment 4
//=================================================================================

// Caretaker Class
public class Caretaker
{
  public List<Memento> canvas = new List<Memento>();
  public Stack<Shape> history = new Stack<Shape>();
  public Stack<Shape> redolist = new Stack<Shape>();

  public void addMemento(Memento m)
  {
    canvas.Add(m);
  }

  public Memento getMemento(int i)
  {
    return canvas[i];
  }

  public void undoMemento(Stack<Shape> canvas)
  {
    history.Push(canvas.Pop());
    Console.WriteLine("Undo");
  }
  public void redoMemento(Stack<Shape> canvas)
  {
    canvas.Push(history.Pop());
    Console.WriteLine("Redo");
  }
}

//=================================================================================
//Memento class
public class Memento
{
  public ShapesClass shapesClass { get; set; }
  public ShapesClass canvas { get; set; }

  public Memento(ShapesClass shapesClass)
  {
    this.shapesClass = shapesClass;
  }

  public Shape getDetails()
  {
    return shapesClass.getDetails();
  }
}

//=====================================================================================
//Originator Class

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

  public Shape getDetails()
  {
    return shapesClass.getDetails();
  }


}

//=================================================================================
//Shapes Class

public class ShapesClass
{
  public Shape temp_shape { get; set; }

  public ShapesClass(Shape temp_shape)
  {
    this.temp_shape = temp_shape;
  }

  public Shape getDetails()
  {
    return temp_shape;
  }
}