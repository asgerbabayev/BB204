﻿namespace EfCoreExample.Models;

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
}
