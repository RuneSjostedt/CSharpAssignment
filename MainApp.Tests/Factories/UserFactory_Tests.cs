using Business.Factories;
using Business.Models;

namespace MainApp.Tests.Factories;

public class UserFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnUserRegistrationForm()
    {

        var result = UserFactory.Create();
        
        
        Assert.NotNull(result);
        Assert.IsType<UserRegistrationForm>(result);
        
    }

    [Fact]

    public void Create_ShouldReturnUser_WhenUserRegistrationFormIsProvided()
    {
        
        var userRegistrationForm = new UserRegistrationForm()

        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@domain.com"
        };

        
        var result = UserFactory.Create(userRegistrationForm);

       
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Equal(userRegistrationForm.FirstName, result.FirstName);
        Assert.Equal(userRegistrationForm.LastName, result.LastName);
        Assert.Equal(userRegistrationForm.Email, result.Email);
        Assert.Equal(userRegistrationForm.Phonenumber, result.Phonenumber);
        Assert.Equal(userRegistrationForm.Adress, result.Adress);
        Assert.Equal(userRegistrationForm.Postalcode, result.Postalcode);
        Assert.Equal(userRegistrationForm.County, result.County);
       


    }


}
