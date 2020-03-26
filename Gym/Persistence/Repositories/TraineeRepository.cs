using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;
using Gym.Core.Repositories;
using Gym.Models;
using Gym.Persistence.Identity;

namespace Gym.Persistence.Repositories
{
    public class TraineeRepository : Repository<Trainee, int>, ITraineeRepository
    {
        private readonly ApplicationDbContext _context;
        public TraineeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        private int GenerateWeightHeightFourmla(int height,int weight)
        {
            return (height - 100) - weight;
        }
    }
}