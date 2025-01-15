﻿namespace Business.Models;

public class User
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phonenumber { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Postalcode { get; set; } = null!;

    public string County { get; set; } = null!;
}