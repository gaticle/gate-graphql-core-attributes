using System;

namespace Gate.GraphQL.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    public class GraphQLMutationAttribute : Attribute
    {
        public bool CanCreate { get; set; } = false;
        public bool CanUpdate { get; set; } = false;
        public bool CanDelete { get; set; } = false;
        public GraphQLMutationAttribute()
        {

        }
        public GraphQLMutationAttribute(bool canCreate = false, bool canUpdate = false, bool canDelete = false)
        {
            CanCreate = canCreate;
            CanUpdate = canUpdate;
            CanDelete = canDelete;
        }
    }
}