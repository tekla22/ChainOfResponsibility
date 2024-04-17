using ChainOfResponsibility;

internal class Program
{
    static void Main(string[] args)
    {
        var h1 = new ChainOfResponsibility.Handlers.Handler1();
        var h2 = new ChainOfResponsibility.Handlers.Handler2();
        var h3 = new ChainOfResponsibility.Handlers.Handler3();

        h1.SetSuccesor(h2);
        h2.SetSuccesor(h3);

        h1.HandleRequest(new Request { Name = "Request 1", Value = 2 });
        h1.HandleRequest(new Request { Name = "Request 2", Value = 2500 });
        h1.HandleRequest(new Request { Name = "Request 3", Value = 14 });
    }
}