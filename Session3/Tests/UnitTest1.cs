using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Session3.DataModels;
using Session3.Helpers;
using Session3.Resources;
using Session3.Tests;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Session3.Tests
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {

        private readonly List<PetModel> cleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize() 
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task DemoGetPet()
        {
           
            //Arrange
            var demoGetRequest = new RestRequest(Endpoints.GetPetById(PetDetails.Id));


            //Act
            var response = await RestClient.ExecuteGetAsync<PetModel>(demoGetRequest);
            cleanUpList.Add(response.Data);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code is not equal");
            Assert.AreEqual(PetDetails.Name, response.Data.Name, "Name is not equal");
            Assert.AreEqual(PetDetails.Category.Name, response.Data.Category.Name, "Category name is not equal");
            Assert.AreEqual(PetDetails.PhotoUrls[0], response.Data.PhotoUrls[0], "PhotoUrls is not equal");
            Assert.AreEqual(PetDetails.Tags[0].Name, response.Data.Tags[0].Name, "Tag name is not equal");
            Assert.AreEqual(PetDetails.Status, response.Data.Status, "Status is not equal");


        }

        [TestCleanup]
        public async Task CleanUp()
        {
            foreach (var data in cleanUpList)
            {
                var deleteRequest = new RestRequest(Endpoints.DeletePetById(data.Id));
                var deleteResponse = await RestClient.DeleteAsync(deleteRequest);

            }

        }
    }
}