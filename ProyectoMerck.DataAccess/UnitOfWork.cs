using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppMerckContext _context;

        public ClinicRepository ClinicRepository { get; }

        public LocationRepository LocationRepository { get; }

        public ConsultationRepository ConsultationRepository { get; }

        public ProvinceRepository ProvinceRepository { get; }

        public UnitOfWork(AppMerckContext context)
        {

            _context = context;

            ClinicRepository = new ClinicRepository(context);

            LocationRepository = new LocationRepository(context);

            ConsultationRepository = new ConsultationRepository(context);

            ProvinceRepository = new ProvinceRepository(context);



        }

        public async Task SaveChanges()
        {

            await _context.SaveChangesAsync();

        }


    }


}
