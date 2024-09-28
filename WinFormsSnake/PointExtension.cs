namespace Extensions
{
    internal static class PointExtension
    {
        internal static ref Point Sum(this ref Point lhs, Point rhs)
        {
            lhs.X += rhs.X;
            lhs.Y += rhs.Y;

            return ref lhs;
        }
    }
}
