﻿using Business.Factories;
using Business.Helpers;
using Business.Models;
using System.Diagnostics;

namespace MainApp.Services;

public class UserService
{
    private readonly List<UserEntity> _users = [];
    public bool Create(UserRegistrationForm form)
    {
        try
        {
            UserEntity userEntity = UserFactory.Create(form);
            userEntity.Id = UniqueIdGenerator.GenerateUniqueId();

            _users.Add(userEntity);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}