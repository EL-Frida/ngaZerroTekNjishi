﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public class Qeni : Kafsha, IVrapuesit, IDisposable
    {
        private readonly int x;

        public Qeni()
        {
            x = 10;
        }

        public string Name { get { return "Qeni"; } }

        public void Dispose()
        {
            Console.WriteLine("qeni u zhduk...");
        }

        public override void fol()
        {
            Console.WriteLine("lehe");
        }

        public override void leviz()
        {
            Console.WriteLine("Vrapon");
        }

        public void vrapo()
        {
            Console.WriteLine("vrapon shpejte");
        }

       
    }


}
