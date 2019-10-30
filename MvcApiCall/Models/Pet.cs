using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MvcApiCall.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name {get;set;}
        public string Species {get; set;}
        public string Breed {get; set;}
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string FavoriteThings { get; set; }
        public string LeastFavoriteThings { get; set; }
        public string Owner { get; set; }
        public string PhotoPath { get; set; }

        public static List<Pet> GetPets()
        {
            var apiCallTask = ApiHelper.ApiCall("pets");
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            Console.WriteLine(jsonResponse);
            List<Pet> petList = JsonConvert.DeserializeObject<List<Pet>>(jsonResponse.ToString()); 

            return petList;
        }
    }
}