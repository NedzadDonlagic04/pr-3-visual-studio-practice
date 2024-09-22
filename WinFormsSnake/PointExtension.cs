namespace Extensions
{
    public static class PointExtension
    {
        public static Point Sum(this Point lhs, Point rhs) => new() { X = lhs.X + rhs.X, Y = lhs.Y + rhs.Y };
    }
}
