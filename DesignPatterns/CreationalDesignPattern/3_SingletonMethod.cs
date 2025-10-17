using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPattern
{
    /**
     * The Singleton design pattern ensures a class has only one instance and provides a global access point to it.
     * Its ideal for scenarios requiring centralized control, like managing database connections or configuration settings.
     * 
     * eg : Setting up DB connections, Implementing Logger etc.
     * 
     * If you think you want to extent the class later, the singleton pattern is a good choice.
     * It allows for subclassing, so client can work with the extended version without changing the original Singleton.
     * 
     * 
     * 
     * Realworld Usages : 
     * 1. Logging Systems.
     * 2. Configuration mahagers.
     * 3. Database Connections
     * 4. Cache Manager, Print Spoolers and Runtime environments.
     * */


    /**
     * Key components of Singleton Method Design Pattern:
     * 1. Static Member : The static member ensures that memory is allocated only once, preserving the single instance of Singleton Class.
     * 2. Private Construtor : The singleton pattern or Pattern singleton incorporates a private constructor, which serves as a barricade against external attemots to create instance of the singleton class. This ensures that the class has control overs its instantiation process.
     * 3. Static factory Method : A crucial aspect of the Singleton is the presence of a Static factory method.
     **/


    // No Thread safety Singleton
    public sealed class Singleton1
    {
        private Singleton1(){}
        public static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get { 
                if(Instance== null)
                {
                    instance  = new Singleton1();
                }
                return instance;
            }
        }
    }

    // 2. Thready safety Singleton
    public sealed class Singleton2
    {
        private Singleton2() { }

        private static readonly object _lock = new object();
        private static Singleton2 instance = null;

        public static Singleton2 Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }
    }

    public class _3_SingletonMethod
    {
    }
}
