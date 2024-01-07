using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    /// <summary>
    /// Inherit from Animal. So dog is derived from Animal. Animal is called base class
    /// </summary>
    class Dog : Animal
    {
        Dog dog = new Dog();

        void FeedDog()
        {
            //animal is the base class so check which methods are available or not 

            //only following 3 are available. TrainAnimalPrivate is not available
            dog.TrainAnimalPublic();
            dog.TrainAnimalProtected();
            dog.TrainAnimalInternal();

            //only following 3 are available. privateVariable is not available
            dog.publicVariable = "";
            dog.protectedVariable = "";
            dog.internalString = "";
        }
    }
}
