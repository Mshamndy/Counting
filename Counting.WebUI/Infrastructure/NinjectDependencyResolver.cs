using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Counting.Domain.Entities;
using Counting.Domain.Abstract;
using Counting.Domain.Concrete;

namespace Counting.WebUI.Infrastructure
{
    public class NinjectDependencyResolver: IDependencyResolver
    {

        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // put bindings here
            kernel.Bind<ICamera>().To<EFCameraRepository>();
            kernel.Bind<ILocation>().To<EFLocationRepository>();
            kernel.Bind<IProtocol>().To<EFProtocolRepository>();







        }
    }
}
