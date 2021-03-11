using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    abstract class BaseCommand
    {
        protected IReceiver _receiver = null;
        protected Document _document = null;

        public void SetDocument(Document document)
        {
            _document = document;
        }

        public void SetReceiver(IReceiver receiver)
        {
            _receiver = receiver;
        }
        public abstract void Excute();
    }
}
