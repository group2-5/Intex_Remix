using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Models
{
    public class EFBurialRepository : IBurialRepository
    {
        private MummyDBContext _context;

        //constructor
        public EFBurialRepository(MummyDBContext context)
        {
            _context = context;
        }

        public IQueryable<Main> Burials => _context.Burials;
        public IQueryable<Bio> Bios => _context.Bios;
        public IQueryable<Carbon> Carbons => _context.Carbons;
        public IQueryable<Cranial> Cranials => _context.Cranials;
        public IQueryable<Oracle> Oracles => _context.Oracles;


        public Main GetRecordByID(string id)
        {
            return _context.Burials.Find(id);
        }

        public void InsertRecord(Main record)
        {
            _context.Burials.Add(record);
        }

        public void DeleteRecord(string burialID)
        {
            Main record = _context.Burials.Find(burialID);
            _context.Burials.Remove(record);
        }

        public void EditRecord(Main record)
        {
            _context.Entry(record).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}