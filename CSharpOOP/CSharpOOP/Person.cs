using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Person
    {
        // Public items can be seen anyways
        // Auto-Implemented Property (Automatically generates a default "getter" (Accessor) and "setter" (mutator).
        // AccessModifier DataType PropertyName {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int UserAge { get; set; }


        // Private items cannot be seen outside of the class. 
        private int _age;

        // Fully-Implemented Property (You specify the behaviour for the  "getter" (Accessor) and "setter" (mutator).
        public int Age {
            get 
            {
                // For the getter, typically you will want to return the value from the backing variable
                // You may format it first, but thats not required
                return _age;
            }
            set
            {
                // Typically for the setter you want to assign the backing variable to the keyword 'value' which represents what is being assigned to the property.
                // You may perform validation here as well. 
                if (value < 0)
                {
                    throw new Exception("The supplied value must be greater than or equal to 0");

                }
                else 
                {
                    _age = value;

                }

            }
        }

    }
}
