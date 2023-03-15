using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Resources
{
    public class Endpoints
    {
        private const string BaseUrl = "https://petstore.swagger.io/v2";

        public static string PostPet() => $"{BaseUrl}/pet";

        public static string GetPetById(long petId) => $"{BaseUrl}/pet/{petId}";

        public static string DeletePetById(long petId) => $"{BaseUrl}/pet/{petId}";
    }
}
