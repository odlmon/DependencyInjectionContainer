using System;

namespace DependencyInjectionContainer
{
    public class ImplementationInfo
    {
        public Lifetime Lifetime { get; }
        public Type ImplementationType { get; }
        public ImplementationName Name { get; }
        
        public ImplementationInfo(Type type, Lifetime lifetime, ImplementationName name)
        {
            Lifetime = lifetime;
            ImplementationType = type;
            Name = name;
        }
    }
}