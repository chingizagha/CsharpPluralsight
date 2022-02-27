using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - _passengers.Count; }

        private List<Passenger> _passengers = new List<Passenger>();
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }
        //public void ArriveAt(string place)
        //{
        //    Console.WriteLine($"\r\nBus arriving at {place}");
        //    if (_passengers.Count == 0)
        //        return;

        //    LinkedListNode<Passenger> currentNode = _passengers.First;
        //    do{
        //        LinkedListNode<Passenger> nextNode = currentNode.Next;
        //        if (currentNode.Value.Destination == place)
        //        {
        //            Console.WriteLine($"{currentNode.Value} is getting off");
        //            _passengers.Remove(currentNode);
        //        }
        //        currentNode = nextNode;
        //    } while (currentNode != null);
        //    Console.WriteLine($"{_passengers.Count} people left on the bus");
        //}

        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;

            int placeCount = 0;
            foreach (var item in _passengers)
            {
                if(item.Destination == place)
                    placeCount++;
            }

            do
            {
                foreach(var pass in _passengers.ToList())
                {
                    if (pass.Destination == place)
                    {
                        _passengers.Remove(pass);
                        Console.WriteLine($"{pass} is getting off");
                        placeCount--;
                    }
                }

            } while (placeCount > 0);
            Console.WriteLine($"{_passengers.Count} people left on the bus");
        }
    }
}
