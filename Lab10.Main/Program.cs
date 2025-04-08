using Lab10;

string Greetings = @"
Welcome to the drawing program this program will allow you to either draw or modify an existing drawing;
";
Console.WriteLine(Greetings);

List<IGrahic2DFactory> availableShapeTypes = new List<IGrahic2DFactory>();
List<IGraphic2D> builtShapes = new List<IGraphic2D>();

AbstractGraphic2D.Display(builtShapes);
Console.WriteLine("Press any enter to continue.");
string? input = Console.ReadLine();

switch (input)
{
    case "display graphic":
    Console.Clear();
    // use AbstractGraphic2D.Display(List<IGraphic2D)
    break;
    case "add graphic":
    // loop over the factories in availableShapeTypes
    break;
    case "remove graphic":
    // display number of graphic objects in the current drawing
    break;
    case "exit":
    break;
}