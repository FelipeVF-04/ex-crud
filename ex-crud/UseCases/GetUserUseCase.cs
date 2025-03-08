using ex_crud.IO;
using ex_crud.Models;

namespace ex_crud.UseCases
{
    public class GetUserUseCase
    {
        public GetUserOutput Execute(Guid id)
        {
            var user = UserStore.Users[id];
            return new GetUserOutput(user.Id, user.UserName, user.CreatedAt);
        }
    }

}