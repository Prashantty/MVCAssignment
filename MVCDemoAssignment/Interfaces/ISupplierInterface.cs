using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Interfaces
{
    public interface ISupplierInterface
    {

        List<Supplier> GetSupplier();
        Supplier Create(Supplier supplier);
        Supplier GetSupplierById(int id);
        int Delete(int id);
        int Edit(int id, Supplier supplier);


    }
}
