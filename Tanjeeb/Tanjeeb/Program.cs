using System;
using System.Collections.Generic;
using System.Threading;

namespace Tanjeeb
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();
        public void Attatch(IObserver observer)
        {
            Console.WriteLine("Subject: Attach an Observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject:Detach an Observer.");
            
        }

        public void Notify()
        {
            Console.WriteLine("subject:Notifying observers");
            foreach(var observer in _observers)
            {
                observer.Update(this);

            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I am doing something.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);
            Console.WriteLine("Subject:My state has just changed to: " + this.State);
            this.Notify();
        }

    }


    public interface ISubject
    {
        void Attatch(IObserver observer);
        void Detach(IObserver observer);
        void Notify();

    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }

   
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();

            var observerA = new ConcreteObserverA();
            subject.Attatch(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attatch(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            subject.Detach(observerB);
        }
    }
}
