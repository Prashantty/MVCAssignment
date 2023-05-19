using MVCDemoAssignment.Context;
using MVCDemoAssignment.Interfaces;
using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Repo
{
    public class SupplierRepo : ISupplierInterface
    {

        MarketDbContext _db;

        public SupplierRepo(MarketDbContext db)
        {
            _db = db;
        }
        public Supplier Create(Supplier supplier)
        {
            _db.Suppliers.Add(supplier);
            _db.SaveChanges();
            return supplier;

        }

        public int Delete(int id)
        {
            Supplier obj = GetSupplierById(id); 

            if(obj == null)
            {
                _db.Suppliers.Remove(obj);
                _db.SaveChanges();
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int Edit(int id, Supplier supplier)
        {

            Supplier obj = GetSupplierById(id);
            if (obj == null)
            {
                foreach(Supplier e in _db.Suppliers)
                {
                    if(e.SupplierID == id)
                    {
                        e.Address = supplier.Address;
                        e.Email = supplier.Email;
                        e.Contact = supplier.Contact;
                        e.CityInContect = supplier.CityInContect;   
                        e.SupplierName = supplier.SupplierName;
                    }
                }
                _db.SaveChanges();
                return 0;   
            }
            else
            {
                return 1;
            }

        }

        public Supplier GetSupplierById(int id)
        {
            return _db.Suppliers.FirstOrDefault(x => x.SupplierID == id);
        }

        public List<Supplier> GetSupplier()
        {
            return  _db.Suppliers.ToList();
        }

    }
}
