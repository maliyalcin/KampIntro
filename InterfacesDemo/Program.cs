using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Worker(), 
                new Manager(), 
                new Robot(), 
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            Console.WriteLine("---------------------------");

            IEat[] eats = new IEat[]
            {
                new Manager(), 
                new Worker(), 
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.WriteLine("---------------------------");

            ISalary[] salaries = new ISalary[]
            {
                new Manager(), 
                new Worker(), 
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("The Manager is working Now!");
        }

        public void Eat()
        {
            Console.WriteLine("The Manager is eating Now!");
        }

        public void GetSalary()
        {
            Console.WriteLine("The Manager is received his salary!");
        }
    }

    class Worker:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("The Worker is working Now!");
        }

        public void Eat()
        {
            Console.WriteLine("The worker is eating Now!");
        }

        public void GetSalary()
        {
            Console.WriteLine("The worker is received his salary!");
        }
    }

    class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("The Robot is working Now!");

        }
    }
}
