using SeleniumFF_Nano.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFF_Nano.Services.UtilsByMe
{
    public static class ReadTextToModel
    {
        public static List<AccountModel> ReadTextAccountToModels(string strAcc)
        {
            List<AccountModel> tempAccs = new List<AccountModel>();
            var temp = strAcc.Replace("\n", "").Split('\r');
            foreach (var item in temp)
            {
                if (string.IsNullOrEmpty(item)) break;
                var temp1 = item.Split('-');
                AccountModel acc = new AccountModel();
                acc.Username = temp1[0];
                acc.Password = temp1[1].Trim();
                tempAccs.Add(acc);
            }
            return tempAccs;
        }
        public static List<ProxyModel> ReadTextProxyToModels(string strAcc)
        {
            List<ProxyModel> tempAccs = new List<ProxyModel>();
            var temp = strAcc.Replace("\n", "").Split('\r');
            foreach (var item in temp)
            {
                if (string.IsNullOrEmpty(item)) break;
                var temp1 = item.Split(':');
                ProxyModel pr = new ProxyModel
                {
                    Ip = temp1[0],
                    Username = temp1[2],
                    Password = temp1[3],
                    Port = temp1[1]
                };
                tempAccs.Add(pr);
            }
            return tempAccs;
        }
    }
}
