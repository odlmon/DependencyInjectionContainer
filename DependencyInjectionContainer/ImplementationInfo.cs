using System;

namespace DependencyInjectionContainer
{
    public class ImplementationInfo
    {
        public Lifetime Lifetime { get; }
        public Type ImplementationType { get; }
        public ImplementationVariant Variant { get; }
        
        public ImplementationInfo(Type type, Lifetime lifetime, ImplementationVariant variant)
        {
            Lifetime = lifetime;
            ImplementationType = type;
            Variant = variant;
        }
    }
}