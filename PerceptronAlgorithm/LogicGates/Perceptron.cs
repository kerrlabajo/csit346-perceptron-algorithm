using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGates
{
    public class Perceptron
    {
        private int[] weights;
        private int bias;
        public Perceptron(int numInputs)
        {
            weights = new int[numInputs];
            var rnd = new Random();
            for (int i = 0; i < numInputs; i++)
            {
                weights[i] = (int)rnd.NextDouble() * 2 - 1;
            }
            bias = 0;
        }

        public int Activation(int[] inputs)
        {
            int weightedSum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                weightedSum += inputs[i] * weights[i];
            }
            weightedSum += bias;
            if (weightedSum >= 0)
            {
                Console.WriteLine("\nWeighted Sum: " + weightedSum);
                Console.WriteLine("Bias: " + bias);
                return 1;
            }
            else
            {
                Console.WriteLine("\nWeighted Sum: " + weightedSum);
                Console.WriteLine("Bias: " + bias);
                return 0;
            }
        }

        public void Train(int[][] inputs, int[] labels, int epochs)
        {
            int learningRate = 1;

            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < inputs.Length; j++)
                {
                    int prediction = Activation(inputs[j]);
                    int error = labels[j] - prediction;
                    for (int k = 0; k < weights.Length; k++)
                    {
                        weights[k] += error * inputs[j][k] * learningRate;
                    }
                    bias += error * learningRate;
                }
            }
        }

        //TODO: I must revise the code to use double instead of integers next time.

    }
}
