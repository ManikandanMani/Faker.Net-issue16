using System;
using Faker;


namespace ClassLib
{
    public class GetFakerStringInstance
    {
        public string GetFakerString()
        {
            return Faker.Lorem.GetFirstWord();
        }
    }


    public static class GetStaticFakerStringInstance 
    {
        public static string GetFakerString()
        {
            return Faker.Lorem.GetFirstWord();
        }
    }


}
