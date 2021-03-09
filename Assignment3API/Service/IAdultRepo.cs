using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3API.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment3API.Service
{
    public interface IAdultRepo
    {
        Task<IList<Adult>> getAllAdults();
        Task<Adult> AddAdult(Adult adult);
        Task RemoveAdult(int adultID);
        
        
        
    }
}