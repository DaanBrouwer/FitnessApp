using API.Entities;
using System;

public class AppUser
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public byte [] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public IList<Workouts> Workouts { get; set; }

    public History History { get; set; }
}
