namespace Assignment4;

class DeleteShape : ICommand
{
  Shape shape;
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