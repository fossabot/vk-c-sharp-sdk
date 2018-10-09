﻿using System;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Home.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/account

    internal class Account : Module<Account>, IAccount
    {
        public Account(IRequestExecutionWrapper wrapper)
            : base(wrapper)
        { }

        public void Ban()
        {
            Console.WriteLine(nameof(Ban));
        }
    }
}