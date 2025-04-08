namespace Lab10;

public class Rectangle : AbstractGraphic2D
{
    public decimal Left;
    public decimal Top;
    public decimal Width;
    public decimal Height;

    public override decimal LowerBoundX => Left;
    public override decimal UpperBoundX => Left + Width; //the right side
    public override decimal LowerBoundY => Top;
    public override decimal UpperBoundY => Top + Height; // the bottom side

    public Rectangle(decimal left, decimal top, decimal width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        
        //for corrners of the shape
        if(Left == x && Top == y)
        {
            return true;
        }
        if(UpperBoundX == x && Top == y)
        {
            return true;
        }
        if(Left == x && UpperBoundY == y)
        {
            return true;
        }
        if(UpperBoundX == x && UpperBoundY == y)
        {
            return true;
        }

        //for middle of shape
        if((LowerBoundX + UpperBoundX) / 2 == x && (LowerBoundY + UpperBoundY) / 2 == y)
        {
            return true;
        }
        return false;
    }
}
