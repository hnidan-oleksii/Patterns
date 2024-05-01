namespace Behavioral.CoR
{
    internal class DataLengthHandler : Handler
    {
        public override void HandleRequest(double[] data)
        {
            if (data.Length < 0)
            {
                Console.WriteLine("Data is invalid.");
            }
            else if (successor != null)
            {
                successor.HandleRequest(data);
            }
        }
    }
}
