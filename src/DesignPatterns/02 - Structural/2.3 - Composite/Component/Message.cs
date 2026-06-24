using System.Collections;
using DesignPatterns._02___Structural._2._3___Composite.Interfaces;

namespace DesignPatterns._02___Structural._2._3___Composite.Component;

public class Message : IMessage, IEnumerable<IMessage>
{
    private readonly List<IMessage> _list = new List<IMessage>();
    
    public string Nome { get; set; }

    public Message(string nome)
    {
        Nome = nome;
    }

    public void AddChild(IMessage child)
    {
        _list.Add(child);
    }

    public void RemoveChild(IMessage child)
    {
        _list.Remove(child);
    }

    public IMessage GetChild(int index)
    {
        return _list[index];
    }

    public IMessage GetChild(string name)
    {
        return _list.First(c => c.Nome == name);
    }

    public IEnumerable<IMessage> GetChilds()
    {
        return _list;
    }
    
    public void ShowMessages(int sub)
    {
        Console.WriteLine(new string ('-', sub) + Nome);

        foreach (var message in _list)
        {
            message.ShowMessages(sub + 2);
        }
    }

    public IEnumerator<IMessage> GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }
}