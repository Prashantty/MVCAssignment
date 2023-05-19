using MVCDemoAssignment.Context;
using MVCDemoAssignment.Interfaces;
using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Repo
{
    public class InventoryRepo : IInventoryInterface
    {

        MarketDbContext _db;
        public InventoryRepo(MarketDbContext db)
        {
            _db = db;
        }
        public Inventory Create(Inventory inventory)
        {
            _db.Inventory.Add(inventory);
            _db.SaveChanges();
            return inventory;

        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Edit(int id, Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public List<Inventory> GetInvantory()
        {
           return  _db.Inventory.ToList();
        }

        public Inventory GetInventoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
