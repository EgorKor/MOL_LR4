using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class NormalisedRandomGenerator
    {

        private UniformRandomGenerator lemerGenerator;

        public NormalisedRandomGenerator()
        {
            lemerGenerator = new UniformRandomGenerator();
        }

        public double[] generateNormalisedSequence(int count, int sequenceCount)
        {
            if(count <= 1)
                throw new Exception($"Count can not be less than 2, count = {count}");
            if(sequenceCount < 6)
                throw new Exception($"SequenceCount can not be less than 6, SequenceCount = {sequenceCount}");
            double[] sequence = new double[count];
            for(int i = 0; i < sequenceCount; i++)
            {
                double[] uniformedSequence = lemerGenerator.getSequence(count);
                for(int j = 0; j < count; j++)
                {
                    sequence[j] += uniformedSequence[j];
                }
            }
            for(int i = 0; i < count; i++)
            {
                sequence[i] -= 3;
            }
            return sequence;
        }

        public double[] generateNormalisedSequence(int count)
        {
            return generateNormalisedSequence(count, 6);
        }



    }
}
