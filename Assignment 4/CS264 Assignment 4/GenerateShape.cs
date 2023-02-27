namespace Assignment4;

class GenerateShape : ICommand
{
  public Canvas canvas;
  public Shape shape;
  public string _shape { get; set; }
  public GenerateShape(Shape s, Canvas c)
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