namespace Lab10;

public class Circle : AbstractGraphic2D
{
    public decimal CenterX;
    public decimal CenterY;
    public decimal Radius;
    
    public override decimal LowerBoundX => CenterX - 2;
    public override decimal UpperBoundX => CenterX + 2;
    public override decimal LowerBoundY => CenterY - 2;
    public override decimal UpperBoundY => CenterY + 2;

    public Circle(decimal x, decimal y, decimal radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        //For should not contain four corners
        // if(LowerBoundX == x && LowerBoundY == y)
        // {
        //     return false;
        // }
        // if(UpperBoundX == x && LowerBoundY == y)
        // {
        //     return false;
        // }
        // if(LowerBoundX == x && UpperBoundY == y)
        // {
        //     return false;
        // }
        // if(UpperBoundX == x && UpperBoundY == y)
        // {
        //     return false;
        // }

        //For all points of the compass
        if(LowerBoundX == x && CenterY == y)
        { 
            return true;
        }
        if(UpperBoundX == x && CenterY == y)
        {
            return true;
        }
        if(CenterX == x && LowerBoundY == y)
        {
            return true;
        }
        if(CenterX == x && UpperBoundY == y)
        {
            return true;
        }

        //For Center is included
        if(CenterX == x && CenterY == y)
        {
            return true;
        }
        return false;
    }
}