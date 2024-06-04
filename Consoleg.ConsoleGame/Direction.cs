internal class Direction
{
    public static Position North => new Position(y: -1, x: 0);
    public static Position South => new Position(y: 1, x: 0);

    public static Position West => new Position(x: 0, y: -1);

    public static Position East => new Position(x: 0, y: 1);

}