//use stack here

namespace ProjectSolution
{
    internal class TipJar
    {
        Stack<double> tips;
        public TipJar()
        {
            tips = new Stack<double>();
        }

        // Adds the tip to the stack
        public void Add(double tip)
        {
            tips.Push(tip);
        }

        //method that sums the stack, empties it
        public double Sum ()
        {
            double sum = 0;
            for (int i = 0; i < tips.Count; i++)
            {
                sum += tips.Pop();
            }
            tips.Clear();
            return sum;
        }
    }
}
