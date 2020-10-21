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

        // Private items cannot be seen outside of the class. 
        private string _lastName;

        // Fully-Implemented Property (You specify the behaviour for the  "getter" (Accessor) and "setter" (mutator).
        public string LastName {
            get 
            {
                // For the getter, typically you will want to return the value from the backing variable
                // You may format it first, but thats not required
                return _lastName;
            }
            set
            {
                // Typically for the setter you want to assign the backing variable to the keyword 'value' which represents what is being assigned to the property.
                // You may perform validation here as well. 
                _lastName = value;
            }
        }

    }
}
