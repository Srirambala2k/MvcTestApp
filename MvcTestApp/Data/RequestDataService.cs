using MvcTestApp.Models;

namespace MvcTestApp.Data
{
    public class RequestDataService
    {
        SchoolContext schoolContext;
        public RequestDataService()
        {
            schoolContext = new SchoolContext();    
        }
        public List<Request> GetRequest()
        {
            var request = schoolContext.Requests.ToList();
            return request;
        }
    }
}
