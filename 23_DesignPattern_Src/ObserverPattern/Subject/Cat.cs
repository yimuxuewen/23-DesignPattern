using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Cat
    {
        private List<IObserver> _observersList = new List<IObserver>();

        public void AddObserver(IObserver observer )
        {
            _observersList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observersList.Contains(observer))
            {
                _observersList.Remove(observer);
            }
        }

        public void Mewing()
        {
            Console.WriteLine("喵咪喵了一声！");
            if (_observersList.Count>0)
            {
                for (int i = _observersList.Count-1; i >-1; i--)
                {
                    _observersList[i].Action();
                }
            }
        }

        public event Action MiaoEvent;
        public void MewingEvent()
        {
            Console.WriteLine("喵咪喵了一声！");
            if (MiaoEvent!=null)
            {
                MiaoEvent.Invoke();
            }
        }
    }

}
