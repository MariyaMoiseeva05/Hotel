using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBDataOperations
    {
        private HotelContext db;
        public DBDataOperations()
        {
            db = new HotelContext();
            db.Clients.Load();
        }

        public void DeleteClient(int id)
        {
            Client p = db.Clients.Find(id);
            if (p != null)
            {
                db.Clients.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public ClientModel GetClient(int Id)
        {
            return new ClientModel(db.Clients.Find(Id));
        }

        public object GetAllClients()
        {
            return db.Clients.ToList().Select(i => new ClientModel(i)).ToList();

        }
    }
}