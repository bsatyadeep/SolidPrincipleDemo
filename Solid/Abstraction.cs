namespace Solid
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

    public abstract class Animal
    {
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public bool Loyal { get; set; }

        public virtual bool IsMansBestFriend()
        {
            return Loyal;
        }
    }
    public class Dog : Animal
    {
        public override bool IsMansBestFriend()
        {
            return true;
        }
    }
    public class Cat : Animal
    {

    }
    class Abstraction
    {
    }
}