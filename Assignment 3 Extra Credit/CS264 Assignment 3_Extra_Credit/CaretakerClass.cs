namespace Assignment3;

public class Caretaker
{
  public List<Memento> canvas = new List<Memento>();
  public Stack<string> history = new Stack<string>();
  public Stack<string> redolist = new Stack<string>();

  public void addMemento(Memento m)
  {
    canvas.Add(m);
  }

  public Memento getMemento(int i)
  {
    return canvas[i];
  }

  public void undoMemento(Stack<string> canvas)
  {
    history.Push(canvas.Pop());
    Console.WriteLine("Undo");
  }
  public void redoMemento(Stack<string> canvas)
  {
    canvas.Push(history.Pop());
    Console.WriteLine("Redo");
  }
}