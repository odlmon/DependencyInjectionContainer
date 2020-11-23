using System;

namespace DependencyInjectionContainer
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class DependencyKeyAttribute : Attribute
    {
        public ImplementationVariant ImplementationVariant { get; }

        public DependencyKeyAttribute(ImplementationVariant variant)
        {
            ImplementationVariant = variant;
        }
    }
}