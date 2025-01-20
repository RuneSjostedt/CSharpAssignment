using Business.Models;

namespace Business.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static User Create(UserRegistrationForm form)
    {
        return new User()
        {
          
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
            Phonenumber = form.Phonenumber,
            Adress = form.Adress,
            Postalcode = form.Postalcode,
            County = form.County,
        };
    }
   

    public static User Create(User entity)
    {
        return new User()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phonenumber = entity.Phonenumber,
            Adress = entity.Adress,
            Postalcode = entity.Postalcode,
            County = entity.County,
        };
    }
}
