using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Models
{
    //this class exists as a template for inheritance
    public interface IBurialRepository
    {
        //makes "Burials" a queryable instance from the Burial class
        IQueryable<Main> Burials { get; }
        IQueryable<Bio> Bios { get; }
        IQueryable<Carbon> Carbons { get; }
        IQueryable<Cranial> Cranials { get; }
        IQueryable<Oracle> Oracles { get; }


        Main GetRecordByID(string burialID);
        void InsertRecord(Main record);
        void DeleteRecord(string burialID);
        void EditRecord(Main record);
        void Save();
    }
}