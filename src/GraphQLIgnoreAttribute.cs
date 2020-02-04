using System;

namespace Gate.GraphQL.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GraphQLIgnoreAttribute : Attribute
    {
    }
}