using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.NeuralNetworkFiles
{
    class Dendrite
    {
        public double Weight { get; set; }

        public Dendrite()
        {
            CryptoRandom n = new CryptoRandom();
            this.Weight = n.RandomValue;
        }
        public Dendrite(double weight)
        {
            this.Weight = weight;
        }
    }
}
