using Project_POO.Model;
using Project_POO.Context;
using System;
namespace Project_POO.ViewModel
{
    //Map -> Conversion o alteracion de un objeto(elemento) a otro
    public static class VaccinationMapper
    {
        public static ConsultVM MapConsultVm(Consult c)
        {
            return new ConsultVM
            {
                Id = c.Id,
                ConsultationDay = c.ConsultationDay,
                ConsultationTime = c.ConsultationTime,
                IdCabin = c.IdCabin,
                IdCitizen = c.IdCitizen
            };
        }
        public static CitizenVM MapCitizenVm(Citizen t)
        {
            return new CitizenVM
            {
                Id = t.Id,
                Dui = t.Dui,
                FullName = t.FullName,
                Age = t.Age,
                IdInstitution = t.IdInstitution,
                Adress = t.Adress,
                Email = t.Email,
                Phone = Convert.ToString(t.Phone)
            };
        }
    }
}