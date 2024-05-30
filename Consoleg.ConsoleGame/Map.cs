internal class Map
{
    public int Width { get; set; }
    public int Height { get; set; }

    private Cell[,] cells;

    public Map(int width, int height)
    {
        //Validate
        Width = width;
        Height = height;

        cells = new Cell[width, height];
    }
}