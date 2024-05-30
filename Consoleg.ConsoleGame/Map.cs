internal class Map
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Map(int width, int height)
    {
        //Validate
        Width = width;
        Height = height;

        var cells = new Cell[Width, Height];
    }
}