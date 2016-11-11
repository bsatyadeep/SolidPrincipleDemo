namespace SolidWrong
{
    public class Test
    {
        public Test()
        {
            var dog = new Dog { Eyes = 2, Legs = 4 };
            var cat = new Cat();

            dog.IsMansBestFriend();
        }
    }

    public class Dog
    {
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public bool Loyal { get; set; }

        public bool IsMansBestFriend()
        {
            return Loyal;
        }
    }
    public class Cat
    {
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public bool Loyal { get; set; }

        public bool IsMansBestFriend()
        {
            return Loyal;
        }
    }
    class Abstraction
    {
    }
}