namespace Application
{
    public interface IDishRepository
    {
        string GetDishName(string menuType, int dishInt);
        Dish GetDish(Order order, string dishName);
    }
}