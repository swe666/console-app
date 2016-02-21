namespace Application.Interfaces
{
    interface IDishHandler
    {
        Order ParseOrder(string input);
    }
}
