﻿using System;
using Ninject;
using Ninject.Planning.Bindings;
using NUnit.Framework;
using Siege.ServiceLocation;

namespace Siege.Container.UnitTests
{
    [TestFixture]
    public class NinjectAdapterTests : SiegeContainerTests
    {
        readonly IKernel kernel = new StandardKernel();

        protected override IContextualServiceLocator GetAdapter()
        {
            return new NinjectAdapter.NinjectAdapter(kernel);
        }

        protected override void RegisterWithoutSiege()
        {
            Type type = typeof(UnregisteredClass);
            BindingBuilder<IUnregisteredInterface> builder = new BindingBuilder<IUnregisteredInterface>(new Binding(typeof(IUnregisteredInterface)));

            builder.To(type).InTransientScope();
            kernel.AddBinding(builder.Binding);
        }
    }
}