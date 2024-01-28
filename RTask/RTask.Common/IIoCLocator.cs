using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Common
{
    public interface IIoCLocator
    {
        T GetInstance<T>() where T : class;

        void Register<T>() where T : class;
    }
}
