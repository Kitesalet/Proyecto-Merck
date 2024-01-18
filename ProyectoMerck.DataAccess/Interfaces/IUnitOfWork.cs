using ProyectoMerck.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {

        public ProvinceRepository ProvinceRepository { get; }
        public ClinicRepository ClinicRepository { get; }
        public LocationRepository LocationRepository { get; }
        public ConsultationRepository ConsultationRepository { get; }
        public Task SaveChanges();

    }
}
