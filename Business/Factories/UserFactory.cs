using Business.Models;

namespace Business.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity Create(UserRegistrationForm form)
    {
        return new UserEntity()
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
}
