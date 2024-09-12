using Dapper;
using DataAccessLayer.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ParceldetailsRepository : IParceldetailsRepository
    {
        Parceldetailsdbcontext dbContext = null;
        public ParceldetailsRepository(Parceldetailsdbcontext context)
        {
            dbContext = context;
        }

        public void InsertDetails(Parceldetails loc)
        {

            try
            {
                dbContext.Add(loc);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<Parceldetails> GetAllParcel()
        {
            try
            {
                return dbContext.parceldetails.ToList();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Parceldetails GetParcelByName(long id)
        {
            try
            {
                return dbContext.parceldetails.FirstOrDefault(X => X.ParcelID == id);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void UpdateParcelDetails(Parceldetails loc)
        {
            try
            {
                dbContext.Update(loc);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DeleteParcelDetails(long loc)
        {
            try
            {
                var count = dbContext.parceldetails.Find(loc);
                dbContext.Remove(count);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }
        }




    }
}
