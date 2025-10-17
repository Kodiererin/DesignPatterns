using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Prototype Design Pattern : 
 * 
 * 1. The Prototype design pattern is a creational design pattern which is required when object creation is a time consuming 
 * and costly operation. So we create objects with the existing object itself by copying the existing ones.
 * 
 * 
 *      Used when Object creation is a very heavy process.
 *      
 * 
 * Real life Software Examples : 
 * Document and Content management systems can use the prototypes pattern to manage document templates.
 * Users can clone an existing template and then make specific modifications.
 * 
 * Game engines use to frequently clone complex characters or terrain objects.
 * 
 * 
 * This prototype approach allows efficient duplication without repeating costly initialization.
 * 
 **/
namespace DesignPatterns.CreationalDesignPattern
{
    // Prototype Interface.

    public interface Shape
    {
        Shape clone();
        void draw();    
    }

    // Concrete Prototype.
    public class Circle : Shape
    {
        private String color;

        public Circle(String color)
        {
            this.color = color;
        }

        public Shape clone()
        {
            return new Circle(this.color);
        }

        public void draw()
        {
           Console.WriteLine("Drawing a " + color + " circle.");
        }
    }


    // This is like a user of shapes.
    // It uses a prototype (a shape) to create new shapes.

    public class ShapeClient
    {
        private Shape shapePrototype;

        // When you create a client, you give it a prototype (a shape).
        public ShapeClient(Shape shapePrototype)
        {
            this.shapePrototype = shapePrototype;
        }

        // This method creates a new shape using the prototype.
        public Shape createShape()
        {
            return shapePrototype.clone();
        }
    }
    internal class _5_PrototypeDesignPattern
    {
        
    }
}
