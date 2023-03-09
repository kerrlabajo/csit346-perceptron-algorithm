using LogicGates;
using System;

namespace ConsonantOrVowelPerceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the training data.
            int[][] trainingData = new int[][] {
                new int[] { 0, 1, 0, 0, 0 }, // A
                new int[] { 0, 1, 0, 0, 1 }, // E
                new int[] { 0, 0, 0, 1, 0 }, // I
                new int[] { 0, 0, 0, 1, 1 }, // O
                new int[] { 0, 0, 1, 0, 0 }, // U
                new int[] { 1, 0, 0, 0, 0 }, // B
                new int[] { 1, 0, 0, 0, 1 }, // C
                new int[] { 1, 0, 0, 1, 0 }, // D
                new int[] { 1, 0, 0, 1, 1 }, // F
                new int[] { 1, 0, 1, 0, 0 }, // G
                new int[] { 1, 0, 1, 0, 1 }, // H
                new int[] { 1, 0, 1, 1, 0 }, // J
                new int[] { 1, 0, 1, 1, 1 }, // K
                new int[] { 1, 0, 0, 1, 0 }, // L
                new int[] { 1, 0, 0, 1, 1 }, // M
                new int[] { 1, 0, 1, 0, 0 }, // N
                new int[] { 1, 0, 1, 0, 1 }, // P
                new int[] { 1, 0, 1, 1, 0 }, // Q
                new int[] { 1, 0, 1, 1, 1 }, // R
                new int[] { 1, 0, 0, 1, 0 }, // S
                new int[] { 1, 0, 0, 1, 1 }, // T
                new int[] { 1, 0, 1, 0, 0 }, // V
                new int[] { 1, 0, 1, 0, 1 }, // W
                new int[] { 1, 0, 1, 1, 0 }, // X
                new int[] { 1, 0, 1, 1, 1 }, // Y
                new int[] { 1, 0, 0, 1, 0 }, // Z
            };

            // Set up the labels for the training data.
            int[] trainingLabels = new int[] {
                0, // A
                0, // E
                0, // I
                0, // O
                0, // U
                1, // B
                1, // C
                1, // D
                1, // F
                1, // G
                1, // H
                1, // J
                1, // K
                1, // L
                1, // M
                1, // N
                1, // P
                1, // Q
                1, // R
                1, // S
                1, // T
                1, // V
                1, // W
                1, // X
                1, // Y
                1, // Z
            };
            // Get input for epochs from the user.
            Console.Write("Enter epoch limit: ");
            string epochs = Console.ReadLine();

            // Create the perceptron and train it with 5 features accdg from the trainingData.
            Perceptron perceptron = new Perceptron(5);
            perceptron.Train(trainingData, trainingLabels, int.Parse(epochs));

            // Get input from the user.
            Console.Write("Enter a letter: ");
            string input = Console.ReadLine();

            // Convert the letter to a feature vector for it to scan.
            int[] features = LetterToFeatures(input);

            // Use the perceptron to predict whether the letter is a consonant or a vowel.
            int prediction = perceptron.Activation(features);

            // Print the result.
            if (prediction == 0)
            {
                Console.WriteLine("\n" + input + " is a vowel.");
            }
            else
            {
                Console.WriteLine("\n" + input + " is a consonant.");
            }
        }

        static int[] LetterToFeatures(string letter)
        {
            // Convert the letter to lowercase for case-switching simplicity.
            letter = letter.ToLower();

            // Create a feature vector for the letter then scans for its corresponding value.
            int[] features = new int[5];
            switch (letter)
            {
                case "a":
                    features = new int[] { 0, 1, 0, 0, 0 };
                    break;
                case "e":
                    features = new int[] { 0, 1, 0, 0, 1 };
                    break;
                case "i":
                    features = new int[] { 0, 0, 0, 1, 0 };
                    break;
                case "o":
                    features = new int[] { 0, 0, 0, 1, 1 };
                    break;
                case "u":
                    features = new int[] { 0, 0, 1, 0, 0 };
                    break;
                case "b":
                    features = new int[] { 1, 0, 0, 0, 0 };
                    break;
                case "c":
                    features = new int[] { 1, 0, 0, 0, 1 };
                    break;
                case "d":
                    features = new int[] { 1, 0, 0, 1, 0 };
                    break;
                case "f":
                    features = new int[] { 1, 0, 0, 1, 1 };
                    break;
                case "g":
                    features = new int[] { 1, 0, 1, 0, 0 };
                    break;
                case "h":
                    features = new int[] { 1, 0, 1, 0, 1 };
                    break;
                case "j":
                    features = new int[] { 1, 0, 1, 1, 0 };
                    break;
                case "k":
                    features = new int[] { 1, 0, 1, 1, 1 };
                    break;
                case "l":
                    features = new int[] { 1, 0, 1, 0, 0 };
                    break;
                case "m":
                    features = new int[] { 1, 0, 0, 0, 1 };
                    break;
                case "n":
                    features = new int[] { 1, 0, 0, 1, 0 };
                    break;
                case "p":
                    features = new int[] { 1, 0, 0, 1, 1 };
                    break;
                case "q":
                    features = new int[] { 1, 0, 1, 0, 0 };
                    break;
                case "r":
                    features = new int[] { 1, 0, 1, 0, 1 };
                    break;
                case "s":
                    features = new int[] { 1, 0, 1, 1, 0 };
                    break;
                case "t":
                    features = new int[] { 1, 0, 1, 1, 1 };
                    break;
                case "v":
                    features = new int[] { 1, 1, 0, 0, 0 };
                    break;
                case "w":
                    features = new int[] { 1, 1, 0, 0, 1 };
                    break;
                case "x":
                    features = new int[] { 1, 1, 0, 1, 0 };
                    break;
                case "y":
                    features = new int[] { 1, 1, 0, 1, 1 };
                    break;
                case "z":
                    features = new int[] { 1, 1, 1, 0, 0 };
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            return features;
        }
    }
}




