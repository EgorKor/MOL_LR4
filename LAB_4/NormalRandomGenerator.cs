using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class NormalRandomGenerator
    {
        private NormalisedRandomGenerator normalisedRandom;
        public NormalRandomGenerator()
        {
            normalisedRandom = new NormalisedRandomGenerator();
        }

        public int[] generateSequence(int count, int d, int m)
        {
            if (count < 1)
                throw new Exception($"Count can not be less than 1, count = {count}");
            int[] sequence = new int[count];
            double[] normalisedSequence = normalisedRandom.generateNormalisedSequence(count);
            for(int i = 0; i < count; i++)
            {
                sequence[i] = (int)(d * normalisedSequence[i] + m);
            }
            return sequence;
        }
    }
}
