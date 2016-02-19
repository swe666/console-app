namespace Application.Interfaces
{
    interface IDishHandler
    {
        IOrder ParseOrder(string input);
    }
}
