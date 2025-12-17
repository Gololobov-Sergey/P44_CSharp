using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    interface IWorker
    {
        bool IsWorking { get; }

        void Work();

    }


    class Manager : IWorker
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public bool IsWorking { get => true; }

        public void Work()
        {
            Console.WriteLine("I workig manager");
        }
    }

    class Worker : IWorker
    {
        public string Name { get; set; }
        public bool IsWorking { get => false; }
        public void Work()
        {
            Console.WriteLine("I working worker");
        }
    }


    class Robot : IWorker
    {
        public string Name { get; set; }

        public bool IsWorking { get => true; }
        public void Work()
        {
            Console.WriteLine("I working robot");
        }
    }


    interface IA
    {
        void Show();
        //
    }

    interface IB
    {
        void Show();
        //
    }

    interface IC
    {
        void Show();
        //
    }


    class Test : IA, IB, IC
    {
        public void Show()
        {
            Console.WriteLine("Show C");
        }


        void IA.Show()
        {
            Console.WriteLine("Show A");
        }

        void IB.Show()
        {
            Console.WriteLine("Show B");
        }
    }
}
