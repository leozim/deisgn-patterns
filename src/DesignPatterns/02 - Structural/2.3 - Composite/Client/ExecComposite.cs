using DesignPatterns._02___Structural._2._3___Composite.Component;
using DesignPatterns._02___Structural._2._3___Composite.CompositeChild;

namespace DesignPatterns._02___Structural._2._3___Composite.Client;

public class ExecComposite
{
    public static void Exec()
    {
        var validacaoCadastro = new Message("O cadastro não foi realizado!");

        var usuarioFormErro = new Message("O usuário informou um nome inválido");

        var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres");
        var nomeVazioForm = new InputFormMessage("O nome não pode possuir numeros");

        usuarioFormErro.AddChild(tamanhoNomeForm);
        usuarioFormErro.AddChild(nomeVazioForm);

        validacaoCadastro.AddChild(usuarioFormErro);

        var domainUsuarioErro = new Message("Problemas ao processar o cadastro de usuario");

        var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
        var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

        domainUsuarioErro.AddChild(cpfUsuarioDomain);
        domainUsuarioErro.AddChild(emailUsuarioDomain);

        validacaoCadastro.AddChild(domainUsuarioErro);

        var msgNivel1 = new Message("Nivel 1");
        var msgNivel2 = new Message("Nivel 2");
        var msgNivel3 = new Message("Nivel 3");
        var msgNivel4 = new Message("Nivel 4");
        var msgNivel5 = new Message("Nivel 5");

        msgNivel4.AddChild(msgNivel5);
        msgNivel3.AddChild(msgNivel4);
        msgNivel2.AddChild(msgNivel3);
        msgNivel1.AddChild(msgNivel2);

        validacaoCadastro.AddChild(msgNivel1);

        validacaoCadastro.ShowMessages(2);
    }
}