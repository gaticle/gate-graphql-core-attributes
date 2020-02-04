using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace Gate.GraphQL.Core.Attributes
{

    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property, Inherited = true)]
    public class GraphQLEnumAttribute : Attribute
    {
    }
}