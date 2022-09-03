using System;
using System.Text;

namespace Library;

public class AppointmentSchedule
{
    Boolean isValid = false;
    public UserData userData {get; set;}
    public ServiceData serviceData {get; set;}
    public AppointmentSchedule(UserData userData, ServiceData serviceData)
    {
        this.userData = userData;
        this.serviceData = serviceData;
        Console.WriteLine("Schedule appointment registered correctly.");
    }

}
//La unica razon de esta clase es de crear una instancia de consulta a partir de las instancias de usuario e instancias de servicio.





