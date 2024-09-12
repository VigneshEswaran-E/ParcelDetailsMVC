using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public interface IParceldetailsRepository
    {
        public void InsertDetails(Parceldetails loc);
        public List<Parceldetails> GetAllParcel();
        public Parceldetails GetParcelByName(long id);
        public void UpdateParcelDetails(Parceldetails loc);
        public void DeleteParcelDetails(long loc);

    }
}
