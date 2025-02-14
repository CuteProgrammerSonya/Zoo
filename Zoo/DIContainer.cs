using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class DIContainer
    {
        private readonly Dictionary<Type, Func<object>> Services = new Dictionary<Type, Func<object>>();

        // service registration
        public void Register<T>(Func<T> factory)
        {
            Services[typeof(T)] = () => factory();
        }

        // get service
        public T Resolve<T>()
        {
            return (T)Services[typeof(T)]();
        }
    }
}
