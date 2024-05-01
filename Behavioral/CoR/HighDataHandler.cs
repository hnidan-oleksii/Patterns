namespace Behavioral.CoR
{
    internal class HighDataHandler : Handler
    {
        private const double Threshold = 100;

        public override void HandleRequest(double[] data)
        {
            bool hasHighData = data.Any(d => d > Threshold);
            if (hasHighData)
            {
                Console.WriteLine("Data contains values exceeding the threshold.");
            }
            else
            {
                successor?.HandleRequest(data);
            }
        }
    }

}
