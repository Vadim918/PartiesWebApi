using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PartiesWebApi.Models.Domain;

namespace PartiesWebApi.Models
{
    public class ParticipantsRepository
    {
        public readonly AppDbContext context;

        public ParticipantsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<GuestResponse> Read(string PartiesName)
        {
            return context.Parties.Where(x => x.PartiesName == PartiesName);
        }
        public int Save(GuestResponse entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
            return entity.Id;
        }
    }
}
