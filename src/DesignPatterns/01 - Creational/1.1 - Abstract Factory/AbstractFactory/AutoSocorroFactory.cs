namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.AbstractFactory;

public abstract class AutoSocorroFactory
{
    public abstract Guincho CriarGuincho();
    public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
}