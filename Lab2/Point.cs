namespace Lab2
{
    public class Point
    {
        private readonly int _x;
        private readonly int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool IsInSecondQuadrant()
            => _y > 0 && _x < 0;

        public override string ToString()
            => $"[{_x};{_y}]";
    }
}