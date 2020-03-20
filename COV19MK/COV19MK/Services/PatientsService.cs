using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COV19MK.Data.Entities;
using COV19MK.Repositories.Repository.Interfaces;
using COV19MK.Services.Service.Interfaces;

namespace COV19MK.Services
{
    public class PatientsService : IPatientsService
    {
        private readonly IPatientsRepository _patientsRepository;

        public PatientsService(IPatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public void Add(Patients patients)
        {
            _patientsRepository.Add(patients);
        }

        public void Delete(Patients patients)
        {
            _patientsRepository.Delete(patients);
        }

        public void Edit(Patients patients)
        {
            _patientsRepository.Edit(patients);
        }

        public IEnumerable<Patients> GetAllPatients()
        {
            var result = _patientsRepository.GetAllPatients();
            return result;
        }

        public Patients GetPatientsById(int id)
        {
            var result = _patientsRepository.GetPatientsById(id);
            return result;
        }
    }
}
