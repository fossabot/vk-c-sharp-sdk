using System;

namespace Vk.CSharp.Sdk.App.Components
{
    public static class Handler
    {
        public static void Handle(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}