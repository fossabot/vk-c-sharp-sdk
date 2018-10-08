﻿using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/apps

    internal class Apps : Module<Apps>, IApps
    {
        public Apps(IMapperModule mapper)
            : base(mapper)
        { }
    }
}