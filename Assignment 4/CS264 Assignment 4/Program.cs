namespace Assignment4;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine(); Console.WriteLine("==== DEMO START ====");
    Canvas canvas = new Canvas();

    Invoker invoker = new Invoker();
    Console.WriteLine("TEST: ADDING (ADD FOUR SHAPES)"); Console.WriteLine();
    // invoker.Action(new GenerateShape(new Start(), canvas));
    invoker.Action(new GenerateShape(new Circle(), canvas));
    invoker.Action(new GenerateShape(new Ellipse(), canvas));
    invoker.Action(new GenerateShape(new Rectangle(), canvas));
    invoker.Action(new GenerateShape(new Line(), canvas));
    invoker.Action(new GenerateShape(new Polyline(), canvas));
    invoker.Action(new GenerateShape(new Polygon(), canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: DELETE THREE SHAPES"); Console.WriteLine();
    invoker.Action(new DeleteShape(canvas));
    invoker.Action(new DeleteShape(canvas));
    invoker.Action(new DeleteShape(canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: UNDOING (UNDO)2 DELETED SHAPES"); Console.WriteLine();
    // Undo 2 commands
    invoker.Undo(); invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: UNDOING (UNDO)UNDO ONE MORE"); Console.WriteLine();
    // Undo 1 command
    invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: ADDING (ADD TWO CIRCLES)"); Console.WriteLine();
    invoker.Action(new GenerateShape(new Circle(), canvas));
    invoker.Action(new GenerateShape(new Circle(), canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("UNDOING: TWICE"); Console.WriteLine();
    invoker.Undo(); invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("REDOING: ONCE"); Console.WriteLine();
    invoker.Redo();
    Console.WriteLine(canvas);
    Console.WriteLine("==== DEMO END ===="); Console.WriteLine();
    Console.WriteLine("SAVING TO FILE");
    invoker.Action(new Save(canvas));
    Console.ReadKey();
  }
}
