using DesignPatterns._01___Creational._1._1___Abstract_Factory.Client;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Executer;

public class ExecutionAbstractFactory
{
    public static void Executar()
    {
        var veiculosSocorro = new List<Veiculo>
        {
            VeiculoCreator.Create("Celta", Porte.Pequeno),
            VeiculoCreator.Create("Jetta", Porte.Medio),
            VeiculoCreator.Create("BMW X6", Porte.Grande)
        };
        
        veiculosSocorro.ForEach(v => AutoSocorro
            .CriarAutoSocorro(v)
            .RealizarAtendimento());
    }
}