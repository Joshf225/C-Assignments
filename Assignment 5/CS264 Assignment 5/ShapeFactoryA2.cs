namespace Assignment5;
class ShapeFactoryA2
{
  //   public ShapeA2 FactoryMethod(string name, int cx, int cy, int r, string fill1, string stroke1, int wX, int wY, int width, int height, int ecx, int ecy, int rx, int ry, int lx1, int ly1, int lx2, int ly2, int lstroke, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int pg1, int pg2, int pg3, int pg4, int pg5, int pg6, int pg7, int pg8, int pathd1, int pathd2, int i)
  //   {
  //     List<ShapeA2> sh = new List<ShapeA2>();
  //     if (name == "circle")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.circle(name, cx, cy, r, fill1, stroke1, i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "rectangle")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.rectangle(name, wX,wY,width,height,fill1,stroke1,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "ellipse")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.ellipse(name, wX,wY,width,height,fill1,stroke1,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "line")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.line(name, wX,wY,width,height,lstroke,stroke1,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "polyline")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.polyline(name,p1,p2,p3,p4,p5,p6,p7,p8,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "polygon")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.polygon(name,p1,p2,p3,p4,p5,p6,p7,p8,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     else if (name == "path")
  //     {
  //       ShapeA2 shape = new ShapeA2();
  //       shape.path(name,pathd1,pathd2,i++);
  //       sh.Add(shape);
  //       foreach (ShapeA2 item in sh)
  //       {
  //         return item;
  //       }
  //     }
  //     return null;
  //   }
  public ShapeA2 CircleFactoryMethod(string name, int cx, int cy, int r, string fill, string stroke, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.circle(name, cx, cy, r, fill, stroke, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 RectangleFactoryMethod(string name, int wX, int wY, int width,int height, string fill, string stroke, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.rectangle(name, wX, wY, width,height, fill, stroke, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 EllipseFactoryMethod(string name, int ecx, int ecy, int rx,int ry, string fill, string stroke, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.ellipse(name, ecx, ecy, rx,ry, fill, stroke, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 LineFactoryMethod(string name, int x1, int y1, int x2,int y2,int lstroke, string stroke, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.line(name, x1, y1, x2, y2, lstroke, stroke, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 PolylineFactoryMethod(string name, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.polyline(name, p1, p2, p3, p4, p5, p6, p7, p8, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 PolygonFactoryMethod(string name, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.polygon(name, p1, p2, p3, p4, p5, p6, p7, p8, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 PathFactoryMethod(string name, int pathd1,int pathd2, int i)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.path(name,pathd1,pathd2, i++);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }
  public ShapeA2 StyleFactoryMethod(string stroke, string fill,string name)
  {
    List<ShapeA2> sh = new List<ShapeA2>();
    ShapeA2 shape = new ShapeA2();
    shape.style(stroke,fill,name);
    sh.Add(shape);
    foreach (ShapeA2 item in sh)
    {
      return item;
    }
    return null;
  }


}