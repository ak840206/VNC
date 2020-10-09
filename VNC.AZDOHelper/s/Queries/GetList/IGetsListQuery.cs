using System.Collections.Generic;

namespace VNC.AZDOHelper..Queries.GetList
{
    public interface IGetsListQuery
    {
        List<Model> Execute();
        //List<Customer> Execute();
    }
}
