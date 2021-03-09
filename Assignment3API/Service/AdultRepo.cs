using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment3API.Model;
using Assignment3API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Assignment3API.Service
{
    public class AdultRepo: IAdultRepo

    {
        private Assignment4DBContext ctx;

        public AdultRepo(Assignment4DBContext ctx)
        {
            this.ctx = ctx;
        }


        public async Task<IList<Adult>> getAllAdults()
        {
            return await ctx.Adults.ToListAsync();
        }

    public async Task<Adult> AddAdult(Adult adult)
    {
        int max = ctx.Adults.DefaultIfEmpty().Max(r => r == null ? 0 : r.Id);
        adult.Id = ++max;
        EntityEntry<Adult> newlyAdded = await ctx.Adults.AddAsync(adult);
        
        await ctx.SaveChangesAsync();
        return newlyAdded.Entity;
        
    }

    public async Task RemoveAdult(int adultID)
    {
        var toRemove = await ctx.Adults.FirstOrDefaultAsync(t => t.Id == adultID);
        if (toRemove != null)
        {
            ctx.Adults.Remove(toRemove);
            await ctx.SaveChangesAsync();
        }
    }
    }
}