using LibraryMindbox.Interface;

namespace LibraryMindbox.Figures
{
    public class TriangleFigure : Figure, IAreaCalculate
    {
        private float _side1, _side2, _side3;
        public TriangleFigure(float side1, float side2, float side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public float CalculateArea()
        {
            if (CheckCorrectFigure())
            {
                float p = (_side1 + _side2 + _side3) / 2;
                return (float)(Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3)));
            }
            else
            {
                return _defaultUncorretValue;
            }
        }

        public override bool CheckCorrectFigure()
        {
            return ((_side1 + _side2 > _side3) &&
                     (_side2 + _side3 > _side1) &&
                     (_side1 + _side3 > _side2));
        }

        /// <summary>
        /// Возвращает TRUE, если треугольник правильный
        /// </summary>
        public bool IsRightTriangle()
        {
            return ((_side1 * _side1 == _side2 * _side2 + _side3 * _side3) ||
                (_side2 * _side2 == _side1 * _side1 + _side3 * _side3) ||
                (_side3 * _side3 == _side1 * _side1 + _side2 * _side2));
        }
    }
}
