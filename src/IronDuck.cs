class RubberDuck : Duck, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Iron Duck");
    }


    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
}
