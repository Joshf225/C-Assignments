//Command code from Assignment 4
//=================================================================================
//Command Interface Class
namespace Assignment5;
public interface ICommand
{
  void Do();
  void Undo();
}

//=================================================================================
//Invoker Class

public class Invoker
{
  private Stack<ICommand> undo;
  private Stack<ICommand> redo;

  private List<ICommand> _commands = new List<ICommand>();
  public int UndoCount { get => undo.Count; }
  public int RedoCount { get => redo.Count; }
  public Invoker()
  {
    Reset();
    Console.WriteLine("Created a new Invoker(User)!"); Console.WriteLine();
  }
  public void Reset()
  {
    undo = new Stack<ICommand>();
    redo = new Stack<ICommand>();
  }
  // public void process()
  // {
  //   foreach(ICommand command in _commands)
  //   {
  //     try{
  //       command.Do();
  //     }
  //     catch(Exception e)
  //     {

  //     }
  //   }
  // }

  // public void AddCommands(ICommand command)
  // {
  //   _commands.Add(command);
  // }

  public void Action(ICommand command)
  {
    // first update the undo - redo stacks
    undo.Push(command);  // save the command to the undo command
    redo.Clear();        // once a new command is issued, the redo stack clears

    // next determine  action from the Command object type
    // this is going to be AddShapeCommand or DeleteShapeCommand
    Type t = command.GetType();
    if (t.Equals(typeof(GenerateShape)))
    {
      Console.WriteLine("Command Received: Add new Shape!" + Environment.NewLine);
      command.Do();
    }

    if (t.Equals(typeof(DeleteShape)))
    {
      Console.WriteLine("Command Received: Delete last Shape!" + Environment.NewLine);
      command.Do();
    }
    if(t.Equals(typeof(Save)))
    {
      Console.WriteLine("Command Recieved: SAVING CANVAS!" + Environment.NewLine);
      command.Do();
    }
  }

  // Undo
  public void Undo()
  {
    Console.WriteLine("Undoing operation!"); Console.WriteLine();
    if (undo.Count > 0)
    {
      ICommand c = undo.Pop(); c.Undo(); redo.Push(c);
    }
  }

  // Redo
  public void Redo()
  {
    Console.WriteLine("Redoing operation!"); Console.WriteLine();
    if (redo.Count > 0)
    {
      ICommand c = redo.Pop(); c.Do(); undo.Push(c);
    }
  }

}
//=================================================================================
//GenerateShape Class

class GenerateShape : ICommand
{
  public Canvas canvas;
  public string shape;
  public string _shape { get; set; }
  public GenerateShape(string s, Canvas c)
  {
    shape = s;
    canvas = c;
  }


  // Adds a shape to the canvas as "Do" action
  public void Do()
  {
      canvas.Add(shape);
  }

  // Removes a shape from the canvas as "Undo" action
  public void Undo()
  {
    shape = canvas.Remove();
  }
}

//=================================================================================
//DeleteShape Class
class DeleteShape : ICommand
{
  string shape;
  Canvas canvas;

  public DeleteShape(Canvas c)
  {
    canvas = c;
  }

  public void Do()
  {
    shape = canvas.Remove();
  }
  public void Undo()
  {
    canvas.Add(shape);
  }
}
//=================================================================================
//Canvas Class

public class Canvas
{
  public Stack<string> canvas = new Stack<string>();
  public string shape { get; set; }

  public void Add(string str)
  {
    canvas.Push(str);
    Console.WriteLine("Added shape to canvas");
  }

  public string Remove()
  {
    string s = canvas.Pop();
    Console.WriteLine("Removed shape from canvas");
    return s;
  }

  public Canvas()
  {
    Console.WriteLine("\nCreated new Canvas");
  }

  public override string ToString()
  {
    int val = canvas.Count;
    string st = "";
    String str = "<!-- " + "Canvas (" + val + " elements):" + " -->"+Environment.NewLine;
    // foreach (Shape s in canvas)
    // {
    //   str += s + Environment.NewLine;
    // }
    // return str;
    Stack<string> reversedStack = new Stack<string>();
    foreach (string s in canvas)
    {
      reversedStack.Push(s);
    }
    foreach (string n in reversedStack)
    {
      str += n + Environment.NewLine;
    }
    return str;
  }
}
//=================================================================================
//Save Command Class

class Save : ICommand
{
  public Canvas canvas;
  public Save(Canvas c)
  {
    canvas = c;
  }

  public void Do()
  {
    // Canvas canvas = new Canvas();
    Console.WriteLine("Saving canvas to shape.svg");
    string temp = "<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">";
    temp+= canvas.ToString();
    temp += "</svg>";
    File.WriteAllText("shape.svg", temp);
    Console.WriteLine("Saved");
  }

  public void Undo()
  {
    File.Delete("shape.svg");
  }
}