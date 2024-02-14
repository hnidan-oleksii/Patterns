using AbstractFactory.Factories;
using AbstractFactory;
using FactoryMethod.Factory;
using Builder.Builder;
using Singleton;
using Prototype;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseSingleton();
            UsePrototype();
            UseBuilder();
            UseFactoryMethod();
            UseAbstractFactory();
        }


        static void UseSingleton()
        {
            Console.WriteLine("Singleton example:" + Environment.NewLine);

            var modelManager = ModelManager.getInstance();
            modelManager.Predict();

            Console.WriteLine();

            var anotherModelManager = ModelManager.getInstance()    ;
            anotherModelManager.Predict();

            Console.WriteLine($"Are both instances the same? {modelManager == anotherModelManager}");

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        static void UsePrototype()
        {
            Console.WriteLine("Prototype example:" + Environment.NewLine);

            ModelConfig baseConfig = new ModelConfig("Linear Regression", 0.01, 100);
            baseConfig.DisplayConfig();

            Console.WriteLine();

            ModelConfig modifiedConfig = baseConfig.Clone();
            modifiedConfig.LearningRate = 0.02;
            modifiedConfig.DisplayConfig();

            Console.WriteLine($"Are both configurations the same instance? {ReferenceEquals(baseConfig, modifiedConfig)}");

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        static void UseBuilder()
        {
            Console.WriteLine("Builder example:" + Environment.NewLine);

            var builder = new PipelineBuilder();
            var pipeline = builder
                .SetModel("Linear Regression")
                .SetScaler("Standard Scaler")
                .Build();

            pipeline.UsePipeline();

            Console.WriteLine();

            var pipeline2 = builder
                .SetModel("Decision Tree")
                .SetScaler("Min-Max Scaler")
                .Build();

            pipeline2.UsePipeline();

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        static void UseFactoryMethod()
        {
            Console.WriteLine("Factory method example:" + Environment.NewLine);

            IModelProcessorFactory factory = new LinearRegressionFactory();
            var modelProcessor = factory.CreateModelProcessor();
            var scaler = factory.CreateScaler();

            scaler.ScaleData();
            modelProcessor.TrainModel();
            modelProcessor.UseModel();

            Console.WriteLine();

            IModelProcessorFactory factory2 = new DecisionTreeFactory();
            var modelProcessor2 = factory2.CreateModelProcessor();
            var scaler2 = factory2.CreateScaler();

            scaler2.ScaleData();
            modelProcessor2.TrainModel();
            modelProcessor2.UseModel();

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        static void UseAbstractFactory()
        {
            Console.WriteLine("Abstract factory example:" + Environment.NewLine);

            IAbsModelFactory factory = new AbsLinearRegressionFactory();
            Pipeline pipeline = new Pipeline(factory);
            pipeline.RunPipeline();

            Console.WriteLine();

            IAbsModelFactory factory2 = new AbsDecisionTreeFactory();
            Pipeline pipeline2 = new Pipeline(factory2);
            pipeline2.RunPipeline();

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
    }
}
