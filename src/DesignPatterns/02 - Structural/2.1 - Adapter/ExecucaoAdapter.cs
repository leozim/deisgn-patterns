using DesignPatterns._02___Structural._2._1___Adapter.Adapter;
using DesignPatterns._02___Structural._2._1___Adapter.Client;
using DesignPatterns._02___Structural._2._1___Adapter.Services;
using DesignPatterns._02___Structural._2._1___Adapter.Target;

namespace DesignPatterns._02___Structural._2._1___Adapter;

public class ExecucaoAdapter
{
    public static void Executar()
    {
        var pagamentoLogPadrao = new ClientTransacaoService(new Logger());
        pagamentoLogPadrao.RealizarTransacao();

        var pagamentoLogCustom = new ClientTransacaoService(new LogAdpter(new AdapteeLogNetMasterService()));
        pagamentoLogCustom.RealizarTransacao();
    }
}