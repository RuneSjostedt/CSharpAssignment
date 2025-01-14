using Business.Factories;
using Business.Helpers;
using Business.Models;

namespace MainApp.Services;

public class UserService
{
    public void Create(UserRegistrationForm form)
    {
        UserEntity userEntity = UserFactory.Create(form);
        
        userEntity.Id = UniqueIdGenerator.GenerateUniqueId();
        

    }
}