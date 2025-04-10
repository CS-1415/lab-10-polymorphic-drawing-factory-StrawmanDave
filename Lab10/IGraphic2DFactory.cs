namespace Lab10;

public interface IGrahic2DFactory
{
    string Name {get; protected set;} 

    IGraphic2D Create();

}