using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Interfaces
{
    public interface IInventoryInterface
    {


        List<Inventory> GetInvantory();
        Inventory Create(Inventory inventory);
        Inventory GetInventoryById(int id);
        int Delete(int id);
        int Edit(int id, Inventory inventory);
    }
}
