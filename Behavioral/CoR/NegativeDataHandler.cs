namespace Behavioral.CoR
{
    internal class NegativeDataHandler : Handler
    {
        public override void HandleRequest(double[] data)
        {
            bool hasNegative = data.Any(d => d < 0);
            if (hasNegative)
            {
                Console.WriteLine("Data contains negative values.");
            }
            else
            {
                successor?.HandleRequest(data);
            }
        }
    }

}
