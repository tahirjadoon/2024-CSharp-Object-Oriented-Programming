using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    /// <summary>
    /// Cat is not inheriting from Animal. Here will create an object and use it
    /// </summary>
    class Cat
    {
        Animal animal = new Animal();
        void FeedCat()
        {
            //protected is not available in thise case like dog because Cat is not derived from Animal

            //only following 2 are available. TrainAnimalPrivate and TrainAnimalProtected are not available
            animal.TrainAnimalPublic();
            animal.TrainAnimalInternal();

            //only following 2 are available. privateVariable and protectedVariable are not available
            animal.publicVariable = "";
            animal.internalString = "";
        }
    }
}
