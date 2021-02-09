using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace FirstLab
{
    public static class Utils
    {
        public static double height = 0;
        public static LineSeries CalculateLineSeries(decimal x, decimal x1)
        {
            LineSeries ls = new LineSeries();
            double xCopy = (double)x;
            double yCopy = (double)x1;
            ls.Points.Add(new DataPoint(xCopy, height));
            ls.Points.Add(new DataPoint(xCopy, height));
            ls.Points.Add(new DataPoint(xCopy, height));
            
            ls.Points.Add(new DataPoint(yCopy, height));
            ls.Points.Add(new DataPoint(yCopy, height));
            ls.Points.Add(new DataPoint(yCopy, height));
            height += 0.1;
            
            return ls;
        }
    
        public static bool IsDigitsOnly(string str)
        {
            return str.All(c => c >= '0' && c <= '9');
        }
    }
}