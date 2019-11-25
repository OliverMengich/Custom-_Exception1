using System;

namespace CustomException1
{
    class Program
    {
         public void AcceptAge()
        {
            int age;
              System.Console.WriteLine("Enter your age");
              age = Convert.ToInt32(Console.ReadLine());
              if(age <20 || age >40)
              {
                  AgeNotAllowedException exp = new AgeNotAllowedException("Age between 20 And 40 is allowed");
                  throw exp;
              }
              else
              {
                  Console.WriteLine("Welcome");
              }
        }
        public void OnTeens()
        {
            bool yes = true;
            System.Console.WriteLine("Are You a teen");
            yes = Convert.ToBoolean(Console.ReadLine());
            TeensNotAllowed teens = new TeensNotAllowed("Teens Are Not Allowed in This Premises");
            // throw teens;
            var result = (yes)? throw teens : " You are Welcome ";
            System.Console.WriteLine(result);
            // if(yes == true)
            // {
            //     throw teens;
            // }
            // else
            // {
            //   System.Console.WriteLine("You Are Welcome Here");
            // }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // try
            // {
             p.AcceptAge();
            // }
            // catch (AgeNotAllowedException e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            //  try
            //  {
                  p.OnTeens();
            //  }
            //  catch(TeensNotAllowed e)
            //  {
            //        System.Console.WriteLine(e.Message);
            //  }
        }
    }
    class AgeNotAllowedException:ApplicationException
    {
       public AgeNotAllowedException(string s) : base(s)
       {
         
       }
    }
    class TeensNotAllowed:ApplicationException
    {
           public TeensNotAllowed(string s):base(s)
           {
              
           }
    }
}
    

