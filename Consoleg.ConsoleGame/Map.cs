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

        cells = new Cell[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell();
            }
        }
    }
}