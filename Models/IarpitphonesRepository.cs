using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2084_2.Models
{
    // repository for mockalbum data for unit testing

    public interface IarpitphonesRepository
    {
        IQueryable<arpitphone> arpitphones { get; }
        arpitphone Save(arpitphone arpitphones);

        void Delete(arpitphone arpitphones);
    }
}
