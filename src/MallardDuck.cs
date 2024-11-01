class MallardDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Mallard Duck");
    }

    public void Fly()
    {
        Console.WriteLine("Mallard Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
}