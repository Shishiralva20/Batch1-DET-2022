namespace Batch1_DET_2022
{
    public class Circle
    {
        double r;
        public void SetRadius(double r)
        {
            this.r = r;
        }
        public double GetRadius()
        {
            return r;
        }
        public double GetArea()
        {
            return Math.PI * r * r;
        }
        public double GetCircum()
        {
            return 2 * Math.PI * r;
        }
        public double GetDiameter()
        {
            return 2 * r;
        }
    }
}