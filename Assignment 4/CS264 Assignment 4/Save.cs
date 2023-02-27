namespace Assignment4;

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
    Console.WriteLine("Saving canvas to shapes.svg");
    string temp = "<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">";
    temp+= canvas.ToString();
    temp += "</svg>";
    File.WriteAllText("shapes.svg", temp);
    Console.WriteLine("Saved");
  }

  public void Undo()
  {
    File.Delete("shapes.svg");
  }
}