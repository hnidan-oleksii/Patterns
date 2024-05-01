namespace Behavioral.CoR
{
    internal abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(double[] data);
    }
}
