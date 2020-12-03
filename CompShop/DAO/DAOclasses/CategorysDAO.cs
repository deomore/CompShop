using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompShop.DAO;
using CompShop.Models;

namespace CompShop.DAO.DAOclasses
{
    public class CategorysDAO
    {
        private CSEntities3 db = new CSEntities3();
        public void AddNew(Categorys categorys)
        {
            db.Categorys.Add(categorys);
            db.SaveChanges();
        }

        public void Delete(Categorys categorys)
        {
            categorys = db.Categorys.FirstOrDefault();
            if (categorys != null)
            {
                db.Categorys.Remove(categorys);
                db.SaveChanges();
            }
        }
    }
}