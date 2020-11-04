using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionAPI.Model;

namespace ElectionAPI.Services.Election
{
    public interface IElectionService : IRepository<Elections>
    {
    }
}
