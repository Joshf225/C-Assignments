namespace Assignment4;

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