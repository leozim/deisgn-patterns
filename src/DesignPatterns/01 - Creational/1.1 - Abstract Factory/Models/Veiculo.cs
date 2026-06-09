namespace DesignPatterns._01___Creational._1._1___Abstract_Factory;

public abstract class Veiculo
{
    protected Veiculo(string modelo, Porte porte)
    {
        Modelo = modelo;
        Porte = porte;
    }

    public string Modelo { get; set; }
    public Porte Porte { get; set; }
    
}

public class VeiculoPequeno : Veiculo
{
    public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte)
    {
    }
}

// Produto Concreto
public class VeiculoMedio : Veiculo
{
    public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
    {
    }
}

// Produto Concreto
public class VeiculoGrande : Veiculo
{
    public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
    {
    }
}

public class VeiculoCreator
{
    public static Veiculo Create(string modelo, Porte porte)
    {
        switch (porte)
        {
            case Porte.Pequeno:
                return new VeiculoPequeno(modelo, porte);
            case Porte.Medio:
                return new VeiculoMedio(modelo, porte);
            case Porte.Grande:
                return new VeiculoGrande(modelo, porte);
            default:
                throw new ApplicationException("Porte de veiculo desconhecido.");
        }
    }
}