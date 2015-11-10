using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;

namespace mbWcfSample
{    
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        IEnumerable<User> GetAllActiveUsers();
    }
}
