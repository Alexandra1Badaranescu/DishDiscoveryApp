using System.Collections.Generic;
using System.Linq;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;

namespace DishDiscovery.Services
{
    public class MenuItemService : IMenuItemService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MenuItemService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _repositoryWrapper.MenuItemRepository.FindAll();
        }

        public MenuItem GetMenuItemById(int menuItemId)
        {
            return _repositoryWrapper.MenuItemRepository.GetById(menuItemId);
        }

        public void CreateMenuItem(MenuItem menuItem)
        {
            _repositoryWrapper.MenuItemRepository.Create(menuItem);
            _repositoryWrapper.Save();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            _repositoryWrapper.MenuItemRepository.Update(menuItem);
            _repositoryWrapper.Save();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            _repositoryWrapper.MenuItemRepository.Delete(menuItem);
            _repositoryWrapper.Save();
        }
    }

}
