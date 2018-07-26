using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace WindowsFormsRedis
{

    public class RepositoryExchanges
    {
        static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        IDatabase db = redis.GetDatabase();

        public void GetAll()
        {
            AlumnoModel alumno = new AlumnoModel(2, "ergerg", "egr", "324");

            HashEntry[] alumnoHash = {
                new HashEntry("id", alumno.Id),
                new HashEntry("nombre", alumno.Nombre),
                new HashEntry("apellido", alumno.Apellido),
                new HashEntry("dni", alumno.Dni)
            };

            db.HashSet(String.Concat("Alumnos:", alumno.Id), alumnoHash);
        }


        public void Insert(AlumnoModel alumno)
        {
            HashEntry[] alumnoHash = {
                new HashEntry("id", alumno.Id),
                new HashEntry("nombre", alumno.Nombre),
                new HashEntry("apellido", alumno.Apellido),
                new HashEntry("dni", alumno.Dni)
            };

            db.HashSet(String.Concat("Alumnos:", alumno.Id), alumnoHash);
        }


    }
}
