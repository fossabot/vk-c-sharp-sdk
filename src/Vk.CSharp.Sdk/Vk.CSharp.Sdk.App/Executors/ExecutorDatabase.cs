using System;
using Vk.CSharp.Sdk.App.Components;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Home.Models.Parameters.Database;

namespace Vk.CSharp.Sdk.App.Executors
{
    public static class ExecutorDatabase
    {
        public static void GetChairs()
        {
            var response = VkApiProvider.Get()
                .GetDatabase()
                .GetChairs(new ParametersGetChairs { FacultyId = 15 });

            Console.WriteLine(Serializer.Serialize(response.Items));
        }
    }
}