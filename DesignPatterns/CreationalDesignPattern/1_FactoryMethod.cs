using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/**
 * Factory Method Design Pattern in Java.
 * It is a creational design pattern that talks about the creation of an object in Java.
 * The factory design pattern says to design an interface (A java interface of an abstract class) for creating the object and let the subclass decide which class to instantiate.
 *
 *
 **/
namespace DesignPatterns.CreationalDesignPattern
{
    interface Product
    {
        public void showProduct();
    }

    class ConcreteProductA : Product
    {
        public void showProduct()
        {
            Console.WriteLine("This is Concrete Product A");
        }
    }

    class ConcreteProductB : Product
    {
        public void showProduct()
        {
            Console.WriteLine("This is Concrete Product B");
        }
    }
    internal class FactoryMethod
    {
        public static void Execute()
        {
            Product productA = new ConcreteProductA();
            productA.showProduct();
            Product productB = new ConcreteProductB();
            productB.showProduct();
        }
    }
}
