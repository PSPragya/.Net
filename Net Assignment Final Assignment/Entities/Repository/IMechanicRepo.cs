using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface IMechanicRepo
    {
        List<Mechanicmodel> GetallMechanic();
        Mechanicmodel GetMechanicyId(int Id);
        string UpdateMechanic(Mechanicmodel model);
        string DeleteMechanic(int Id);
        string CreateMechanic(Mechanicmodel model);
    }
}
