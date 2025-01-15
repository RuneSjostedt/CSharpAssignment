using Business.Factories;
using Business.Helpers;
using Business.Models;
using Business.Services;
using System.Diagnostics;

namespace MainApp.Services;

public class UserService
{
    private List<User> _users = [];
    private readonly FileService _fileService = new FileService();
    public bool Create(UserRegistrationForm form)
    {
        try
        {
            User userEntity = UserFactory.Create(form);
            userEntity.Id = UniqueIdGenerator.GenerateUniqueId();

            _users.Add(userEntity);

            _fileService.SaveListToFile(_users);



            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public IEnumerable<User> GetAll() 
    {
        _users = _fileService.LoadListFromFile();
       return _users.Select(UserFactory.Create);
    }
}