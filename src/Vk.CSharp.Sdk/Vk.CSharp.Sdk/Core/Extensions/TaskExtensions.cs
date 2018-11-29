using System.Threading.Tasks;

namespace Vk.CSharp.Sdk.Core.Extensions
{
    internal static class TaskExtensions
    {
        public static TResult GetResult<TResult>(this Task<TResult> task) =>
            task.ConfigureAwait(false).GetAwaiter().GetResult();
    }
}