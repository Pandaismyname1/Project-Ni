using Ni.Core.Requests;
using Ni.Core.Responses;

namespace Ni.Core.Services
{
    public interface IUserService
    {
        GenericResponse AddUser(AddUserRequest request);
    }
}