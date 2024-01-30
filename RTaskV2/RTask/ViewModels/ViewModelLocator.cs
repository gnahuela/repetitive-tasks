using RTask.Common.IoC;
using RTask.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.ViewModels
{
    public static class ViewModelLocator
    {
        private static IIoCLocator Locator = Bootstrap.GetIoCLocator();

        static ViewModelLocator()
        {
            Locator.Register<AboutViewModel>();
        }

        public static AboutViewModel AboutViewModel => Locator.GetInstance<AboutViewModel>();
    }
}
