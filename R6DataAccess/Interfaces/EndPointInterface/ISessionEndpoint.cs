using R6DataAccess.Models;
using R6Sharp.Response;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public interface ISessionEndpoint
    {
       
     
       Task<string> GetDataAsync(IRequest request);

        Task<string> GetDataNoTicketRequiredAsync(IRequest request);


    }
}