using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COV19MK.Data.Entities;

namespace COV19MK.Services.Service.Interfaces
{
    public interface IPatientsService
    {
        IEnumerable<Patients> GetAllPatients();

        void Add(Patients patients);

        void Edit(Patients patients);

        void Delete(Patients patients);

        Patients GetPatientsById(int id);
    }
}
