using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
  public  class ServiceVehicle :Service<Vehicle>, IServiceVehicle
    {
        static IDatabaseFactory dbf = new DatabaseFactory();
        static IUnitOfWork uof = new UnitOfWork(dbf);
        public ServiceVehicle() : base(uof)
        {
        }
    }
}
