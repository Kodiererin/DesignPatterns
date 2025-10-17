using System;

/**
 * 
 * Builder Design Pattern.
 * 
 * What is Builder Design Pattern?
 * The builder design pattern is a creational pattern that provides a step-by-step approach to constructing complex objects.
 * It separates the construction process from the objects representation, enabling the same process to create different variations of an object.
 * This pattern is especially useful when an object requires multiple steps or configurations during creation.
 * 
 * 
 * Real life software applications:
 * 1. SQL query builders, like those found in ORM's such as laravelEloquent or SQLAlchemy in Python, which utilized the builder pattern to construct SQL queries dynamically.
 * 2. When creating user interface components like dialog boxes, forms or custom widgets, the builder pattern can be used to assemble elements and apply styles in a structured way.
 * 
 * 
 * 
 * Components of the builder Design pattern.
 * 1. Product
 * 2. Builder.
 * 3. ConcreteBuilder
 * 4. Director.
 * 5. Client
 * 
 * 
 * Steps to implement the Builder Design pattern.
 * 1. Create the Product Class
 * 2. Create the Builder class
 * 3. Add a Build Method
 * 4. Use the Director (Optional)
 * 5. Client uses the Builder.
 **/


namespace DesignPatterns.CreationalDesignPattern
{

    // 1. Product
    public class Computer
    {
        private String cpu_;
        private String ram_;
        private String storage_;

        public void setCPU(String cpu)
        {
            cpu_ = cpu;
        }

        public void setRAM(String ram)
        {
            ram_ = ram;
        }

        public void setStorage(String storage)
        {
            storage_ = storage;
        }

        public void displayInfo()
        {
            Console.WriteLine("Computer Configuration:");
            Console.WriteLine("CPU: " + cpu_);
            Console.WriteLine("RAM: " + ram_);
            Console.WriteLine("Storage: " + storage_);
        }
    }

    // 2. Builder.
    public interface Builder
    {
        void buildCPU();
        void buildRAM();
        void buildStorage();
        Computer getResult();
    }

    // 3. Concrete Builder (Gaming Computer Builder)
    public class GamingComputerBuilder : Builder
    {
        private Computer computer_ = new Computer();

        public void buildCPU()
        {
            computer_.setCPU("Gaming CPU");
        }

        public void buildRAM()
        {
            computer_.setRAM("16GB DDR4 RAM");
        }

        public void buildStorage()
        {
            computer_.setStorage("1TB SSD");
        }

        public Computer getResult()
        {
            return computer_;
        }
    }

    // 4. Director
    class ComputerDirector
    {
        public void construct(Builder builder)
        {
            builder.buildCPU();
            builder.buildRAM();
            builder.buildStorage();
        }
    }

    internal class _4_BuilderDesignPattern
    {
        static void Main(string[] args)
        {
            GamingComputerBuilder gamingBuilder = new GamingComputerBuilder();
            ComputerDirector computerDirector = new ComputerDirector();

            computerDirector.construct(gamingBuilder);

            Computer gamingComputer = gamingBuilder.getResult();
            gamingComputer.displayInfo();
        }
    }
}