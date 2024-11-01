
// Interface for flying behavior
public interface IVoo
{
    void Voar();
}

// Interface for sound behavior
public interface ISom
{
    void FazerSom();
}

// Concrete implementation of flying behavior for ducks that can fly
public class VooComum : IVoo
{
    public void Voar()
    {
        Console.WriteLine("Estou voando!");
    }
}

// Concrete implementation of flying behavior for ducks that cannot fly
public class VooNaoVoar : IVoo
{
    public void Voar()
    {
        Console.WriteLine("Não posso voar.");
    }
}

// Concrete implementation of sound behavior for ducks that quack
public class SomGrasnar : ISom
{
    public void FazerSom()
    {
        Console.WriteLine("Quack!");
    }
}

// Concrete implementation of sound behavior for silent ducks
public class SomMudo : ISom
{
    public void FazerSom()
    {
        Console.WriteLine("<< Silêncio >>");
    }
}

// Abstract Duck class
public abstract class Duck
{
    protected IVoo vooComportamento;
    protected ISom somComportamento;

    public void RealizarVoo()
    {
        vooComportamento.Voar();
    }

    public void RealizarSom()
    {
        somComportamento.FazerSom();
    }

    public abstract void Display();

    // Allow behavior modification at runtime
    public void SetVooComportamento(IVoo v)
    {
        vooComportamento = v;
    }

    public void SetSomComportamento(ISom s)
    {
        somComportamento = s;
    }
}

// WildDuck class
public class PatoSelvagem : Duck
{
    public PatoSelvagem()
    {
        vooComportamento = new VooComum();
        somComportamento = new SomGrasnar();
    }

    public override void Display()
    {
        Console.WriteLine("Eu sou um Pato Selvagem!");
    }
}

// RubberDuck class
public class PatoDeBorracha : Duck
{
    public PatoDeBorracha()
    {
        vooComportamento = new VooNaoVoar();
        somComportamento = new SomMudo();
    }

    public override void Display()
    {
        Console.WriteLine("Eu sou um Pato de Borracha!");
    }
}

// Main class to test the Duck simulator
public class SimuladorDePatos
{
    public static void Main(string[] args)
    {
        Duck patoSelvagem = new PatoSelvagem();
        patoSelvagem.Display();
        patoSelvagem.RealizarVoo();
        patoSelvagem.RealizarSom();

        Duck patoDeBorracha = new PatoDeBorracha();
        patoDeBorracha.Display();
        patoDeBorracha.RealizarVoo();
        patoDeBorracha.RealizarSom();
    }
}
