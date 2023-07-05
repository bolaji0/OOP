namespace oop;
class Program
{
    static void Main(string[] args)
    {
        //Assignment
        /*Private protected
         *protected internal
         *find the area of a circle and also implement inheritance
         *


         definition for oop in C#
         diff btw oop approach and procedural approach
         oop in C# benefit of oop in C#
         */



        /*
        Inheritance
        Encapsulation
        Abstraction
        Polymorphism
         */

        //Encapsulation
        //Create an instance of the class Rectangle
        //Rectangle rectangle = new Rectangle();
        //rectangle.Length = 4.0;
        //rectangle.Width = 2.5;
        //rectangle.Display();

        //inheritance

        //Single inheritance
        // Multi level Inheritance
        //hiriarchical inheritance
        //Multiple inheritance


        Chef chef = new Chef();
        //chef.cookRice();
        //chef.cookSpag();


        italianChef italian = new italianChef();
        //italian.cookSpag();

        advancedChef advanced = new advancedChef();
        //advanced.cookSpag();


        implementation implementations = new implementation();
        implementations.abstractProp();
        implementations.normalMethod();

        Console.ReadLine();



    }

    abstract class abstractClass
    {
        // Abstract does not have a code block
        public abstract void abstractProp();

        //normal method
        public void normalMethod()
        {
            Console.WriteLine("The normal method");
        }
    }

    class implementation : abstractClass
    {
        public override void abstractProp()
        {
            Console.WriteLine("This an absract");
        }

    }

   
    //Encapsulation
    class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double RectangelArea()
        {
            return Length * Width;
        }


        public void Display()
        {
            Console.WriteLine($"The Length is {Length}");
            Console.WriteLine($"The Width is {Width}");
            //encapsulate the method RectangleArea
            Console.WriteLine($"The area is {RectangelArea()}");
        }

    }

    class Cook
    {
        public void cookRice()
        {
            Console.WriteLine("I can cook Rice");
        }

        public void cookBeans()
        {
            Console.WriteLine("I can cook beans");
        }

        //public virtual void cookSpag()
        //{
        //    Console.WriteLine("I can make spag");
        //}


    }

    class Chef 
    {
        public void makePasta()
        {
            Console.WriteLine("I can make pasta");
        }

        public void barbeque()
        {
            Console.WriteLine("I can make barbeque");
        }

        //public override void cookSpag()
        //{
        //    Console.WriteLine("I make advanced spag");
        //}

    }

    class italianChef
    {
        public void AlfredoPasta()
        {
            Console.WriteLine("I can make alfredo pasta");
        }

        //public override void cookSpag()
        //{
        //    Console.WriteLine("I can make cheese pasta");
        //}

    }


    class advancedChef : Cook
    {
        public void AlfredoPasta()
        {
            Console.WriteLine("I can make alfredo pasta");
        }

        //public override void cookSpag()
        //{
        //    Console.WriteLine("I can make cheese pasta and Wagyu");
        //}

    }


    //Hier



}
