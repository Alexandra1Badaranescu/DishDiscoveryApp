using System.Collections.Generic;
using System.Linq;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.IServices;

namespace DishDiscovery.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _menuItemRepository.FindAll().ToList();
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _menuItemRepository.GetById(id);
        }

        public void CreateMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Create(menuItem);
            _menuItemRepository.Save();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Update(menuItem);
            _menuItemRepository.Save();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Delete(menuItem);
            _menuItemRepository.Save();
        }
    }
}
