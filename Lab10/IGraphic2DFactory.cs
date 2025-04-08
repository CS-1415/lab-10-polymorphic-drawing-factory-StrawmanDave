namespace Lab10;

public interface IGrahic2DFactory
{
    string Name {get; set;} 

    IGraphic2D Create();

}