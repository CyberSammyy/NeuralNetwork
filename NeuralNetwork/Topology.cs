using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public List<int> HiddenLayers { get; }

        public Topology(int inputCount, int outputCOunt, params int[] hiddenLayersCount)
        {
            InputCount = inputCount;
            OutputCount = outputCOunt;
            HiddenLayers = new List<int>();

            HiddenLayers.AddRange(hiddenLayersCount);
        }
    }
}
