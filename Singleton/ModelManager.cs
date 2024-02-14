namespace Singleton
{
    public class ModelManager
    {
        private static ModelManager _instance;

        private ModelManager()
        {
            Console.WriteLine("Model Loaded.");
        }
        
        public static ModelManager getInstance()
        {
            if (_instance == null)
                _instance = new ModelManager();

            return _instance;
        }

        public void Predict()
        {
            Console.WriteLine("Making a prediction with the ML model...");
        }
    }
}
