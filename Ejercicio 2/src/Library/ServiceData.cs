using System;
using System.Text;

namespace Library;

public class ServiceData
{
    public string doctorName { get; set; }
    public string specialty { get; set; }
    public DateTime date { get; set; }
    public string appoinmentPlace { get; set; }
    public Boolean isValid2= true;

    public ServiceData(string name, string specialty, DateTime date, string appoinmentPlace)
    {
        if ((string.IsNullOrEmpty(doctorName)) && (string.IsNullOrEmpty(specialty)))
        {
            isValid2= false;
            Console.WriteLine("Unable to schedule appointment, 'doctor name' is required\n");
        }
        else
        {
            this.doctorName = doctorName;
            this.specialty = specialty;
        }
        if (string.IsNullOrEmpty(appoinmentPlace))
        {
            isValid2= false;
            Console.WriteLine("Unable to schedule appointment, 'appoinment place' is required\n");
        }
        else
        {
            this.appoinmentPlace= appoinmentPlace;
        }
    }
    public Boolean IsValid2()
    {
        return isValid2;
    }
}
/*Nueva clase creada para la creacion de la consulta, la cual se encarga de conocer los datos del doctor 
y del lugar de la consulta.
Se agrega a modo de ejmplo el atributo "specialty" para demostrar aun mas la necesidad de crear una nueva clase.
Al igual que la clase UserData, esta colabora con la clase "Appointment Service", la cual de ser validadas 
las instancias de usuario y servicio crea una nueva instancia que seria la consulta.
*/