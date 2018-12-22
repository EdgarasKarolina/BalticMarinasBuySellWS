using BalticMarinasBuySellWS.Models;
using System.Collections.Generic;

namespace BalticMarinasBuySellWS.Repositories.Interfaces
{
    interface ISoldItemRepository
    {
        List<SoldItem> GetAllSoldItems();
        List<SoldItem> GetAllSoldItemsByUserId(int id);
        SoldItem GetSoldItemById(int id);
        void CreateSoldItem(SoldItem soldItem);
        void DeleteSoldItemById(int id);
    }
}
