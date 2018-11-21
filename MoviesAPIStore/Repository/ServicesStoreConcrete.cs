using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesAPIStore.Models;
using MoviesAPIStore.MoviesContext;

namespace MoviesAPIStore.Repository
{
    public class ServicesStoreConcrete : IServicesStore
    {
        private DatabaseContext _context;

        public ServicesStoreConcrete(DatabaseContext context)
        {
            _context = context;
        }

        public List<ServicesTB> GetServiceList()
        {
            try
            {
                var ServiceList = (from services in _context.ServicesTB
                                   select services).ToList();

                ServiceList.Insert(0, new ServicesTB { ServiceName = "---Choose Service---", ServiceID = -1 });
                return ServiceList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ServicesTB> GetServiceListforDashboard()
        {
            try
            {
                var ServiceList = (from services in _context.ServicesTB
                                   select services).ToList();

                return ServiceList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
