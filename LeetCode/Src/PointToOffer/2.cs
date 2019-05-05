using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton1
{
    private static Singleton1 instance = null;
    public static Singleton1 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }

    private Singleton1() { }
}

public class Singleton2
{
    private static Singleton2 instance = new Singleton2();
    public static Singleton2 Instance
    {
        get
        {
            return instance;
        }
    }

    private Singleton2() { }
}

public class Singleton3
{
    private static Singleton3 instance = null;
    private static object lockFlag = new object();
    public static Singleton3 Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockFlag)
                {
                    if (instance == null)
                    {
                        instance = new Singleton3();
                    }
                } 
            }
            return instance;
        }
    }

    private Singleton3() { }
}

public class Singleton4
{
    public static class SingletonCreator
    {
        public static Singleton4 instance = new Singleton4();
    }
    public static Singleton4 Instance
    {
        get
        {
            return SingletonCreator.instance;
        }
    }

    private Singleton4() { }
}

public class Singleton5
{
    static Singleton5()
    {
        instance = new Singleton5();
    }
    private static Singleton5 instance;
    public static Singleton5 Instance
    {
        get
        {
            return instance;
        }
    }

    private Singleton5() { }
}