using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    // Define interfaces for different abilities

    // a interface for flying ability
    public interface IFlyable
    {
        void Fly();
    }

    // a interface for swimming ability
    public interface ISwimmable
    {
        void Swim();
    }

    // a interface for singing ability
    public interface ISingable
    {
        void Sing();
    }

    /// <summary>
    /// Represents a generic bird with a name.
    /// </summary>

    // Base class Bird
    public class Bird
    {

        public string? name;
        public Bird(string name)
        {
            this.name = name;
        }
    }

     /// <summary>
     /// Represents a duck that can fly and swim, inheriting common bird characteristics.
     /// </summary>
     /// <remarks>The Duck class implements both IFlyable and ISwimmable interfaces, allowing instances to
     /// perform flying and swimming actions. Use this class when modeling birds that exhibit both behaviors.</remarks>

    // Derived class Duck implementing IFlyable and ISwimmable
    public class Duck : Bird, IFlyable, ISwimmable
    {
        public Duck(string name) : base("Duck")
        {
            this.name = name;
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is flying.");
        }
        public void Swim()
        {
            Console.WriteLine($"{name} is swimming.");
        }
    }

    /// <summary>
    /// Represents a parrot that can fly and sing. Inherits from the Bird class and implements the IFlyable and
    /// ISingable interfaces.
    /// </summary>
    /// <remarks>Use the Parrot class to model birds that are capable of both flight and singing behaviors.
    /// This class provides implementations for flying and singing actions specific to parrots.</remarks>
    
    // Derived class Parrot implementing IFlyable and ISingable
    public class Parrot : Bird, IFlyable, ISingable
    {
        public Parrot(string name) : base("Parrot")
        {
            this.name = name;
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is flying.");
        }
        public void Sing()
        {
            Console.WriteLine($"{name} is singing.");
        }
    }
}
