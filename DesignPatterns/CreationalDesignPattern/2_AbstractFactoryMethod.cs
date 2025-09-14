using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/**
 *  Abstract Factory Method Design Pattern
 *  Most commonly used design pattern
 *  It belogs to the creational design pattern
 *  What : The Abstract factory design pattern procides a way to encapuslate a group of factories with a common theme without specifying 
 *  their concrete classes.
 *  
 *  Why : The Abstract factory design pattern is used when the system needs to be independent of how its objects are created, composed, and represented.
 *  
 *  In Simle terms : The abstract factory design pattern provides an interface for creating families of related or dependent products but leaves the actual object creation to the concrete factory classes.
 *  
 * 
 * */
namespace DesignPatterns.CreationalDesignPattern
{

    public interface IBike
    {
        void GetDetails();
    }

    public interface ICar
    {
        void GetDetails();
    }


    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("This is a regular bike.");
        }
    }

    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("This is a sports bike.");
        }
    }

    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("This is a regular car.");
        }
    }

    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("This is a sports car.");
        }
    }

    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }


    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
    public class AbstractFactoryMethod
    {
        public static void Execute()
        {
            IVehicleFactory regularFactory = new RegularVehicleFactory();
            IBike regularBike = regularFactory.CreateBike();
            ICar regularCar = regularFactory.CreateCar();

            regularBike.GetDetails();
            regularCar.GetDetails();
        }   
    }

}
