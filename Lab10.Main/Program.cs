using System.Security.Principal;
using Lab10;

string Greetings = @"
Welcome to the drawing program this program will allow you to either draw or modify an existing drawing;
";
Console.WriteLine(Greetings);

List<IGrahic2DFactory> availableShapeTypes = new List<IGrahic2DFactory>() {new CirlceFactory(), new RectangleFactory()};
List<IGraphic2D> builtShapes = new List<IGraphic2D>();

AbstractGraphic2D.Display(builtShapes);
string? input = "";
while (input != "exit")
{
    Console.WriteLine("What would you like to do (display drawing) (add graphic) (remove graphic) (exit)?");
    input = Console.ReadLine();
    switch (input)
    {
        case "display drawing":
        Console.Clear();
        // use AbstractGraphic2D.Display(List<IGraphic2D)
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Press enter to continue");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");
        AbstractGraphic2D.Display(builtShapes);
        if(Console.ReadKey(true).Key == ConsoleKey.Enter);
        Console.Clear();
        break;
        case "add graphic":
        // loop over the factories in availableShapeTypes
        for (int i = 0; i < availableShapeTypes.Count; i++)
        {
            Console.WriteLine($"{i} {availableShapeTypes[i].Name}");
        }
        Console.WriteLine("You can pick one of the numbers by typing in the name or the number in front of it.");
        string? chosenShape = Console.ReadLine();
        switch(chosenShape)
        {
            case "0":
            case "Circle":
            builtShapes.Add(new CirlceFactory().Create());
            break;
            case "1":
            case "Rectangle":
            builtShapes.Add(new RectangleFactory().Create());
            break;
        }
        break;
        case "remove graphic":
        // display number of graphic objects in the current drawing
        for(int i = 0; i < builtShapes.Count; i++)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("You can remove any of the items by typing in their number");
        try
        {
            int getIndex = Convert.ToInt32(Console.ReadLine());
            builtShapes.RemoveAt(getIndex);
        }catch(FormatException e)
        {
            Console.WriteLine(e.Message);
            break;
        }catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
            break;
        }
        break;
        case "exit":
        break;
    }
}
