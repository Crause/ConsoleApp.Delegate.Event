using System;

namespace ConsoleApp.Delegate.Event
{
  
  class Program
  {
    //public delegate int ValueDelegate(int i);
    //public delegate void MyDelegate();


    //public event MyDelegate Event;
    //public event Action EventAction;


    static void Main(string[] args)
    {
      #region delegate
      //MyDelegate myDelegate = Method1;
      //myDelegate += Method4;
      //myDelegate();

      //MyDelegate myDelegate1 = new MyDelegate(Method4);
      //myDelegate1 += Method4;
      //myDelegate1 -= Method4;
      //myDelegate1.Invoke();

      //MyDelegate myDelegate2 = myDelegate + myDelegate1;
      //myDelegate2.Invoke();


      //var valueDelegate = new ValueDelegate(ValueMethod);
      //valueDelegate += ValueMethod;
      //valueDelegate += ValueMethod;
      //valueDelegate += ValueMethod;
      //valueDelegate += ValueMethod;
      //valueDelegate(new Random().Next(10,50));



      //// public delegate void Action();
      //Action action = Method1;
      //action();
      //// public delegate void Action<T,TT,TTT...>(T value1, TT value2, ...);
      //Action<int> action1 = Method3;
      //action1(5);
      //// public delegate bool Predicate(int value);
      //Predicate<int> predicate;
      //// public delegate int Func(int value);
      //Func<int, int> func;
      //func = ValueMethod;
      //if (func != null)
      //  func(10);
      #endregion

      Person person = new Person();
      person.Name = "Vasya";
      person.GoToSleep += Person_GoToSleep;
      person.DoWork += Person_DoWork;
      person.TakeTime(DateTime.Parse("22.02.2021 20:07:01"));
      person.TakeTime(DateTime.Parse("22.02.2021 4:07:01"));

      //Console.ReadLine();
    }

    private static void Person_DoWork(object sender, EventArgs e)
    {
      if(sender is Person)
      {
        Console.WriteLine($"{((Person)sender).Name} works.");
      }
      
      Console.ReadLine();
    }

    private static void Person_GoToSleep()
    {
      Console.WriteLine("Going to sleep.");
      Console.ReadLine();
    }

    //public static int ValueMethod(int i)
    //{
    //  Console.WriteLine($"ValueMethod = {i}");
    //  return i;
    //}
    //public static void Method1()
    //{
    //  Console.WriteLine("Method1");
    //}
    //public static int Method2()
    //{
    //  Console.WriteLine("Method2");
    //  return 0;
    //}
    //public static void Method3(int i)
    //{
    //  Console.WriteLine("Method3");
    //}
    //public static void Method4()
    //{
    //  Console.WriteLine("Method4");
    //}
  }
}
