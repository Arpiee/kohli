using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// references

namespace Assignment2084_2.Models
{
    
    public class EFarpitphonesRepository : IarpitphonesRepository
    {
        // repository for CRUD with Albums in SQL Server db

        // db connection moved here from arpitphonesController 
        Model1 db = new Model1();
        public IQueryable<arpitphone> arpitphones { get { return db.arpitphones; } }

        public void Delete(arpitphone arpitphones)
        {
            db.arpitphones.Remove(arpitphones);
            db.SaveChanges();
        }

        public arpitphone Save(arpitphone arpitphones)
        {
            if (arpitphones.s_no == 0)
            {
                db.arpitphones.Add(arpitphones);
            }
            else
            {
                db.Entry(arpitphones).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return arpitphones; 
        }
    }
}