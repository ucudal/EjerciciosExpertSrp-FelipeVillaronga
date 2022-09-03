using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData("Steven Jhonson", "986782342", "5555-555-555");
            ServiceData serviceData = new ServiceData("Armand", "Surgeon", DateTime.Now, "Wall Street");
            if (userData.IsValid1() && serviceData.IsValid2())
            {
                AppointmentSchedule appointmentSchedule1 = new AppointmentSchedule(userData, serviceData);
            }
            UserData userData2 = new UserData("Ralf Manson", "", "5555-555-555");
            ServiceData serviceData2 = new ServiceData("", "Queen Street", DateTime.Now, "");
            if (userData2.IsValid1() && serviceData2.IsValid2())
            {
                AppointmentSchedule appointmentSchedule2 = new AppointmentSchedule(userData2, serviceData2);
            }
        }
    }
}
