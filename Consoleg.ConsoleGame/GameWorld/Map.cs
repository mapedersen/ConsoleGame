﻿
using Consoleg.ConsoleGame;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

internal class Map : IMap
{
    private Cell[,] _cells;
    public int Width { get; set; }
    public int Height { get; set; }
    public List<Creature> Creatures { get; } = new List<Creature>();

    public Map(int width, int height)
    {
        //Validate
        Width = width;
        Height = height;

        _cells = new Cell[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                _cells[y, x] = new Cell(new Position(y, x));
            }
        }
    }
    //[return: MaybeNull]
    public Cell? GetCell(int y, int x)
    {
        return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : _cells[y, x];
    }

    public Cell? GetCell(Position newPosition)
    {
        return GetCell(newPosition.Y, newPosition.X);
    }
}