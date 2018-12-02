using Duel.NeuralNetworkFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel
{
    class NeuralNetwork
    {
        //Neural Network basis adapted from https://social.technet.microsoft.com/wiki/contents/articles/36428.basis-of-neural-networks-in-c.aspx
        StreamReader sr;
        public List<Layer> Layers { get; set; }
        public double LearningRate { get; set; }
        String fn;
        public int LayerCount
        {
            get
            {
                return Layers.Count;
            }
        }

        public NeuralNetwork(double learningRate, int[] layers)
        {
            if (layers.Length < 2) return;

            this.LearningRate = learningRate;
            this.Layers = new List<Layer>();

            for (int l = 0; l < layers.Length; l++)
            {
                Layer layer = new Layer(layers[l]);
                this.Layers.Add(layer);

                for (int n = 0; n < layers[l]; n++)
                    layer.Neurons.Add(new Neuron());

                layer.Neurons.ForEach((nn) =>
                {
                    if (l == 0)
                        nn.Bias = 0;
                    else
                        for (int d = 0; d < layers[l - 1]; d++)
                            nn.Dendrites.Add(new Dendrite());
                });
            }

        }        
        public NeuralNetwork(double learningRate, int[] layers, int rand)
        {
            if (layers.Length < 2) return;

            this.LearningRate = learningRate;
            this.Layers = new List<Layer>();
            //Random rnd = new Random(Environment.TickCount);
            for (int l = 0; l < layers.Length; l++)
            {
                Layer layer = new Layer(layers[l]);
                this.Layers.Add(layer);

                for (int n = 0; n < layers[l]; n++)
                    layer.Neurons.Add(new Neuron());

                layer.Neurons.ForEach((nn) =>
                {
                    if (l == 0)
                        nn.Bias = 0;
                    else
                        for (int d = 0; d < layers[l - 1]; d++)
                            nn.Dendrites.Add(new Dendrite());
                });
            }

        }
        public NeuralNetwork(String filename)
        {
            //Constructors 
            fn = filename;
            sr = new StreamReader(filename);
            int count = 0;
            int layersCount;
            int neuronCount;
            double biasTemp;
            double deltaTemp;
            double valueTemp;
            double dendVal;
            List<Dendrite> dend;
            int dendTemp;
            this.Layers = new List<Layer>();
            Layer layer;
            sr = new StreamReader(filename);
            //Getting count
            while ((sr.ReadLine()) != null)
            {
                count++;
            }
            sr = new StreamReader(filename); //reset StreamReader
            //Set Learning Rate
            this.LearningRate = Convert.ToDouble(sr.ReadLine()); //Line 1
            layersCount = Convert.ToInt32(sr.ReadLine()); //Line 2
            //Loop through new layers
            for (int i = 0; i < layersCount; i++)
            {
                neuronCount = Convert.ToInt32(sr.ReadLine());
                layer = new Layer(neuronCount);
                //Loop through Neurons of each Layer
                for (int j = 0; j < neuronCount; j++)
                {
                    biasTemp = Convert.ToDouble(sr.ReadLine());
                    deltaTemp = Convert.ToDouble(sr.ReadLine());
                    valueTemp = Convert.ToDouble(sr.ReadLine());
                    dendTemp = Convert.ToInt32(sr.ReadLine());
                    dend = new List<Dendrite>();
                    //Loop through Dendrites of Each Neuron
                    for (int k = 0; k < dendTemp; k++)
                    {
                        dendVal = Convert.ToDouble(sr.ReadLine());
                        dend.Add(new Dendrite(dendVal));
                    }
                    //Add Neuron
                    layer.Neurons.Add(new Neuron(biasTemp, deltaTemp, valueTemp, dend));
                }
                //Add Layer
                this.Layers.Add(layer);
            }
            sr.Close();

        }

        private double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        public double[] Run(List<double> input)
        {
            using (StreamWriter sw = new StreamWriter("fn"))
            {
                sw.Write(printValue());
            }
            if (input.Count != this.Layers[0].NeuronCount) return null;

            for (int l = 0; l < Layers.Count; l++)
            {
                Layer layer = Layers[l];

                for (int n = 0; n < layer.Neurons.Count; n++)
                {
                    Neuron neuron = layer.Neurons[n];

                    if (l == 0)
                        neuron.Value = input[n];
                    else
                    {
                        neuron.Value = 0;
                        for (int np = 0; np < this.Layers[l - 1].Neurons.Count; np++)
                            neuron.Value = neuron.Value + this.Layers[l - 1].Neurons[np].Value * neuron.Dendrites[np].Weight;

                        neuron.Value = Sigmoid(neuron.Value + neuron.Bias);
                    }
                }
            }

            Layer last = this.Layers[this.Layers.Count - 1];
            int numOutput = last.Neurons.Count;
            double[] output = new double[numOutput];
            for (int i = 0; i < last.Neurons.Count; i++)
                output[i] = last.Neurons[i].Value;

            return output;
        }
        public char Action(List<double> input)
        {
            double[] output = this.Run(input);
            double maxVal = output.Max();
            int maxIndex = output.ToList().IndexOf(maxVal);
            //Console.WriteLine(maxIndex);

            switch (maxIndex)
            {
                case 0:
                    return 'h';

                case 1:
                    return 'b';

                case 2:
                    return 'a';
                default:
                    return 'X';

            }
            //return 'b';
        }
        public bool Train(List<double> input, List<double> output)
        {
            if ((input.Count != this.Layers[0].Neurons.Count) || (output.Count != this.Layers[this.Layers.Count - 1].Neurons.Count)) return false;

            Run(input);

            for (int i = 0; i < this.Layers[this.Layers.Count - 1].Neurons.Count; i++)
            {
                Neuron neuron = this.Layers[this.Layers.Count - 1].Neurons[i];

                neuron.Delta = neuron.Value * (1 - neuron.Value) * (output[i] - neuron.Value);

                for (int j = this.Layers.Count - 2; j > 2; j--)
                {
                    for (int k = 0; k < this.Layers[j].Neurons.Count; k++)
                    {
                        Neuron n = this.Layers[j].Neurons[k];

                        n.Delta = n.Value *
                                  (1 - n.Value) *
                                  this.Layers[j + 1].Neurons[i].Dendrites[k].Weight *
                                  this.Layers[j + 1].Neurons[i].Delta;
                    }
                }
            }

            for (int i = this.Layers.Count - 1; i > 1; i--)
            {
                for (int j = 0; j < this.Layers[i].Neurons.Count; j++)
                {
                    Neuron n = this.Layers[i].Neurons[j];
                    n.Bias = n.Bias + (this.LearningRate * n.Delta);

                    for (int k = 0; k < n.Dendrites.Count; k++)
                        n.Dendrites[k].Weight = n.Dendrites[k].Weight + (this.LearningRate * this.Layers[i - 1].Neurons[k].Value * n.Delta);
                }
            }

            return true;
        }
        public string printValue()
        {
            string str = "";
            for (int i = 0; i < this.Layers.Count; i++)
            {
                str += "- Layer -" + "\n";
                str += "-- Neurons: " + this.Layers[i].Neurons.Count + " --" + "\n";

                for (int j = 0; j < this.Layers[i].NeuronCount; j++)
                {
                    str += "--- Neuron ---" + "\n";
                    str += "---- Bias: " + this.Layers[i].Neurons[j].Bias + "\n";
                    str += "---- Delta: " + this.Layers[i].Neurons[j].Delta + "\n";
                    str += "---- Value: " + this.Layers[i].Neurons[j].Value + "\n";
                    str += "---- Dendrites: " + this.Layers[i].Neurons[j].DendriteCount + "\n";

                    for (int k = 0; k < this.Layers[i].Neurons[j].DendriteCount; k++)
                    {
                        str += "----- Dendrite" + "\n";
                        str += "----- Weight: " + this.Layers[i].Neurons[j].Dendrites[k].Weight + "\n";
                    }

                }
            }



            return str;
        }
        public void saveNetwork()
        {
            if(fn == "")
            {
                fn = "NetworkTest1.txt";
            }
            using (StreamWriter sw = new StreamWriter(fn+"1"))
            {
                sw.WriteLine(this.LearningRate);
                sw.WriteLine(this.Layers.Count);
                for (int i = 0; i < this.Layers.Count; i++)
                {
                    //Loop through Layers
                    sw.WriteLine(this.Layers[i].Neurons.Count);
                    for (int j = 0; j < this.Layers[i].Neurons.Count; j++)
                    {
                        //Loop through Neurons
                        sw.WriteLine(this.Layers[i].Neurons[j].Bias);
                        sw.WriteLine(this.Layers[i].Neurons[j].Delta);
                        sw.WriteLine(this.Layers[i].Neurons[j].Value);
                        sw.WriteLine(this.Layers[i].Neurons[j].DendriteCount);//Dendrite count

                        for (int k = 0; k < this.Layers[i].Neurons[j].DendriteCount; k++)
                        {
                            //Loop through Dendrites
                            sw.WriteLine(this.Layers[i].Neurons[j].Dendrites[k].Weight);
                        }
                    }
                }
                sw.Close();
            }
        }
    }
}
