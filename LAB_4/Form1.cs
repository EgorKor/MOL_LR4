using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_4
{
    public partial class Form1 : Form
    {

        private NormalisedRandomGenerator normalisedRandom;
        private NormalRandomGenerator normalRandomGenerator;

        public Form1()
        {
            InitializeComponent();
            normalisedRandom = new NormalisedRandomGenerator();
            normalRandomGenerator = new NormalRandomGenerator();
            int[] seq = normalRandomGenerator.generateSequence(1000,16,50);
            List<int> seqList = new List<int>();
            for(int i = 0; i < seq.Length; i++)
            {
                seqList.Add(seq[i]);
            }
            seqList.Sort();
            seq[0] += 1;

        }


    }
}
