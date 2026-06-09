using DesignPatterns._01___Creational._1._1___Abstract_Factory.AbstractFactory;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Factory;

public class SocorroVeiculoMedioFactory : AutoSocorroFactory
{
    public override Guincho CriarGuincho()
    {
        return GuinchoCreator.Create(Porte.Medio);
    }

    public override Veiculo CriarVeiculo(string modelo, Porte porte)
    {
        return VeiculoCreator.Create(modelo, porte);
    }
}