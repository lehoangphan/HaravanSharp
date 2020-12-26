using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HaravanData.Repositories
{
    public abstract class BaseHaravanRepository
    {
       protected virtual string JWToken { get; set; }
       protected virtual string BaseApiUrl { get; set; }
    }
}
