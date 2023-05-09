using DishDiscovery.Models;
using System.Collections.Generic;

namespace DishDiscovery.Services.Interfaces
{
    public interface IMenuItemService
    {
        IEnumerable<MenuItem> GetAllMenuItem();
        MenuItem GetMenuItemById(int id);
        void CreateMenuItem(MenuItem menuItem);
        void UpdateMenuItem(MenuItem menuItem);
        void DeleteMenuItem(MenuItem menuItem);
    }
}
