using Session3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Tests.TestData
{
    public class GeneratePet
    {
        public static PetModel demoPet()
        {
            return new PetModel {
                Category = new CategoryModel { Name = "Labrador" },
                Name = "Choco",
                PhotoUrls = new string[] { "photo " },
                Tags = new TagModel[] { new TagModel { Name = "Tags" } },
                Status = "available"
            };

        }
    }
}
