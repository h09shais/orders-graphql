using GraphQL.Types;
using System.Collections.Generic;
using System.Text;

namespace Samples.Schemas.Orders
{
    public class OrderInputType : InputObjectGraphType
    {
        public OrderInputType()
        {
            Name = "OrderInput";
            Field<NonNullGraphType<StringGraphType>>("name", "Name for the order");
            Field<NonNullGraphType<StringGraphType>>("description", "Order description");
            Field<NonNullGraphType<IntGraphType>>("customerId", "ID of the customer who owns this order");
            Field<NonNullGraphType<DateGraphType>>("created", "Date the order was created");
        }

    }
}
