using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Service.Interface
{
    public interface IPlayerService
    {
        T SearchPlayer<T>(string name);
        T GetPlayerProfile<T>(string id);
    }
}
