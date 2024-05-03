using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class UniformRandomGenerator
    {
        private int A = 25173;
        private int B = 13849;
        private int C = 65536;
        private int last = 25173;

        public int getNextInRange(int D)
        {
            return (int)(getNext() * D);
        }

        public double getNext()
        {
            last = (A * last + B) % C;
            return (double)last / C;
        }

        public double[] getSequence(int sequenceLength)
        {
            if (sequenceLength < 1)
                throw new Exception($"SequenceLength can not be less than 1, SequenceLength = {sequenceLength}");
            double[] sequence = new double[sequenceLength];
            for (int i = 0; i < sequenceLength; i++)
                sequence[i] = getNext();
            return sequence;
        }
    }
}
