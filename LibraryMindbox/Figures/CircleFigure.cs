using LibraryMindbox.Interface;

namespace LibraryMindbox.Figures
{
    public class CircleFigure : Figure, IAreaCalculate
    {

        private float _radius;
        public CircleFigure(float radius)
        {
            _radius = radius;
        }

        public float CalculateArea()
        {
            if (CheckCorrectFigure())
            {
                return (float)(Math.PI * Math.Pow(_radius, 2));
            }
            else
            {
                return _defaultUncorretValue;
            }
        }

        public override bool CheckCorrectFigure()
        {
            if (_radius <= 0) return false;
            return true;
        }
    }
}
