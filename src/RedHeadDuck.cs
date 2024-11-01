class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a RedHead Duck");
    }

    public void Fly()
    {
        Console.WriteLine("RedHead Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
}