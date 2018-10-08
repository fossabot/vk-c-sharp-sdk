using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/board

    internal class Board : Module<Board>, IBoard
    {
        public Board(IMapperModule mapper)
            : base(mapper)
        { }
    }
}