using Newtonsoft.Json;
using R6Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace R6Service.Service
{
    public class PlayerService : IPlayerService
    {
        WebClient client = new WebClient();
        public T GetPlayerProfile<T>(string id)
        {
            try
            {
                var json = client.DownloadString("https://r6tab.com/api/player.php?p_id=" + id);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default(T);
            }
        }

        public T SearchPlayer<T>(string name)
        {
            try
            {
                var json = client.DownloadString("https://r6tab.com/api/search.php?platform=uplay&search=" + name);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default(T);
            }
        }
    }
}
