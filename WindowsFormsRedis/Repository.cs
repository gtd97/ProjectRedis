using Newtonsoft.Json;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRedis
{
    public class Repository
    {
        /*
        public List<AlumnoModel> GetAll()
        {
            List<AlumnoModel> lista = new List<AlumnoModel>();
            Dictionary<string, string> dicKeyValue = new Dictionary<string, string>();

            using (RedisClient redisClient = new RedisClient("localhost:6379"))
            {
                var keys = redisClient.GetAllKeys();

                foreach(var key in keys)
                {
                    var t = redisClient.Get<string>(key);
                }
                    
            }

            return lista;
        }
        */

        public bool GetAlumnoById(int id)
        {
            AlumnoModel alumno;

            using (RedisClient redisClient = new RedisClient("localhost:6379"))
            {
                var x = redisClient.Get<string>(id.ToString());
                alumno = new AlumnoModel();
                return true;
            }
            
            return false;
        }



        public bool Put(AlumnoModel alumno)
        {
            using (RedisClient redisClient = new RedisClient("localhost:6379"))
            {
                if (redisClient.Get<string>(alumno.Id.ToString()) != null)
                {
                    redisClient.Set(alumno.Id.ToString(), alumno);
                    return true;
                }
            }
            return false;
        }


        
        public bool Post(AlumnoModel alumno)
        {
            using (RedisClient redisClient = new RedisClient("localhost:6379"))
            {
                if (redisClient.Get<string>(alumno.Id.ToString()) == null)
                {
                    redisClient.Set(alumno.Id.ToString(), alumno);
                    return true;
                }
            }

            return false;
        }

        
        public bool Delete(int id)
        {
            using (RedisClient redisClient = new RedisClient("localhost:6379"))
            {
                if (redisClient.Get<string>(id.ToString()) != null)
                {
                    var result = redisClient.Remove(id.ToString());
                    return true;
                }
            }

            return false;
        }

    }
}
