using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COV19MK.Data;
using COV19MK.Data.Entities;
using COV19MK.Repositories.Repository.Interfaces;

namespace COV19MK.Repositories
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly DataContext _context;

        public PatientsRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Patients patients)
        {
            _context.Patients.Add(patients);
            _context.SaveChanges();
        }

        public void Delete(Patients patients)
        {
            _context.Patients.Remove(patients);
            _context.SaveChanges();
        }

        public void Edit(Patients patients)
        {
            _context.Patients.Update(patients);
            _context.SaveChanges();
        }

        public IEnumerable<Patients> GetAllPatients()
        {
            var result = _context.Patients.AsEnumerable();
            return result;
        }

        public Patients GetPatientsById(int id)
        {
            var result = _context.Patients.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
