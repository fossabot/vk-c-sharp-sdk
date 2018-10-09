using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/board

    internal class Board : Module<Board>, IBoard
    {
        public Board(IRequestExecutionWrapper wrapper)
            : base(wrapper)
        { }
    }
}