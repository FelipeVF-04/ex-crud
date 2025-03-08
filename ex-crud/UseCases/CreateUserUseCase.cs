using ex_crud.IO;
using ex_crud.Models;

namespace ex_crud.UseCases
{
    public class CreateUserUseCase
    {

        public CreateUserOutput Execute(CreateUserInput input)
        {
            var user = new User();
            user.Id = Guid.NewGuid();
            user.UserName = input.Email;
            user.CreatedAt = DateTime.Now;
            
            UserStore.Users.Add(user.Id, user);

            var output = new CreateUserOutput();
            output.Id = user.Id;
            output.UserName = input.Email;
            return output;
        }


    }

}