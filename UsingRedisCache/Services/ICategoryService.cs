using UsingRedisCache.Models;

namespace UsingRedisCache.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAllCategory();
    }
}
