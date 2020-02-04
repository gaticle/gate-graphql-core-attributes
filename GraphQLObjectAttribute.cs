using System;

namespace Gate.GraphQL.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    public class GraphQLObjectAttribute : Attribute
    {
        public bool CanSingleRowQuery { get; set; } = false;
        public bool CanMultyRowsQuery { get; set; } = false;

        public GraphQLObjectAttribute()
        {

        }
        public GraphQLObjectAttribute(bool canSingleRowQuery = false, bool canMultyRowsQuery = true)
        {
            CanSingleRowQuery = canSingleRowQuery;
            CanMultyRowsQuery = canMultyRowsQuery;
        }
    }
}