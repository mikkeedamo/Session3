using RestSharp;
using Session3.DataModels;
using Session3.Resources;
using Session3.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Helpers
{
    public  class PetHelper
    {
        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.demoPet();
            var postRequest = new RestRequest(Endpoints.PostPet()).AddJsonBody(newPetData);

            //Send Post Request to add new pet

            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = postResponse.Data;
            return createdPetData;
        }

    }
}
