using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Session3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Tests
{
    public class BaseTest
    {

        public RestClient RestClient { get; set; }

        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public async Task Initialize()
        {
            RestClient = new RestClient();
        }
    }
}
