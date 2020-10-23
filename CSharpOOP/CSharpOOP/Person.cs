using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    // An abstract class CANNOT be instantiated.
    // It's typically used when it doesn't make logical sense to instantiate the base class.
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string FullName { get; }

        public DateTime DateOfBirth { get; set; }

        private int _energyLevel;
        public int EnergyLevel
        {
            get
            {
                return _energyLevel;
            }
            // protected means only this class, or derived classes can see this property / method.
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Insufficient energy to perform that action.");
                }
                _energyLevel = value;
            }
        }
        private int _stressLevel;
        public int StressLevel
        {
            get
            {
                return _stressLevel;
            }
            protected set
            {
                if (value > 100)
                {
                    throw new Exception("Too much stress to perform that action.");
                }
                // Stress can't go below zero, but don't throw an exception. This is called clamping.
                if (value < 0)
                {
                    _stressLevel = 0;
                }
                else
                {
                    _stressLevel = value;
                }
            }
        }

        // What it means on methods, is that while it has no functionality here, all derived classes MUST have functionality.
        abstract public void Sleep();

        virtual public void Eat()
        {
            EnergyLevel += 10;
            StressLevel -= 5;
        }

        abstract public string WriteInfo();

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}