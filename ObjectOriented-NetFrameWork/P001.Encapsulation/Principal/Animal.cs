using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    class Animal
    {
        private string privateVariable;
        public string publicVariable;
        protected string protectedVariable;
        internal string internalString;

        private void TrainAnimalPrivate()
        { }

        public void TrainAnimalPublic()
        { }

        protected void TrainAnimalProtected()
        { }

        internal void TrainAnimalInternal()
        { }
    }
}
