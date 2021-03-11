using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern_Demo
{
    abstract class BaseDepositor
    {
        private int _span = 0;

        public double Balance { get; set; }
        private int Span
        {
            get
            {
                _span++;
                if (_span == int.MaxValue)
                {
                    _span = 0;
                }
                return _span;
            }
        }
        private bool CheckUser(string Name)
        {
            return true;
        }

        private double Deposit()
        {
            return new Random(Span).Next(10000, 100000);
        }

        protected abstract void CalculationInterest();

        public void Query(string Name)
        {
            if (CheckUser(Name))
            {
                Balance = Deposit();
                CalculationInterest();
            }
        }


    }
}
