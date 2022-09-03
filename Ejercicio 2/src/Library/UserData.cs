using System;
using System.Text;

namespace Library;

    public class UserData
    {
        public string name {get; set;}
        public string id {get; set;}
        public string phoneNumber {get; set;}
        public Boolean isValid1= true;
        public UserData (string name, string id, string phoneNumber)
        {
            if ((string.IsNullOrEmpty(name)) && (string.IsNullOrEmpty(id)) && (string.IsNullOrEmpty(phoneNumber)))
            {
                isValid1= false;
                Console.WriteLine("Unable to schedule appointment, user data is missing.\n");
            }
            else
            {
                this.name= name;
                this.id= id;
                this.phoneNumber= phoneNumber;
            }
        }
        public Boolean IsValid1()
    {
        return isValid1;
    }
    }
/*Se modifica esta clase para que se responsabilice unicamente por los datos del usuario. Asi eliminando de la clase -"AppointmentService-"
la razon de cambiar, ya sea por agregar o modificar los datos del doctor, o del lugar, etc.
Esta clase colaborará con la nueva clase "AppointmentSchedule" proporcionandole las instancias de usuarios creadas*/

