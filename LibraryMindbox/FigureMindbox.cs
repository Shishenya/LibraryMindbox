using LibraryMindbox.Figures;
using LibraryMindbox.Interface;

namespace LibraryMindbox
{
    public class FigureMindbox
    {

        private IAreaCalculate _figure;

        /// <summary>
        /// Для фигур,которые реализуют интерфейс подсчета площади
        /// </summary>
        public FigureMindbox(IAreaCalculate figure)
        {
            _figure = figure;
        }

        public float AreaCalculate()
        {
            return _figure.CalculateArea();
        }

    }
}