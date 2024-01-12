using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    public class UserSession
    {
        public int CurrentUserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
   

    public UserSession(int CurrentUserId, string UserName, string UserLastName)
    {
        this.CurrentUserId = CurrentUserId;
        this.UserName = UserName;
        this.UserLastName = UserLastName;
    
    }
    public UserSession()
    {
        this.CurrentUserId = 0;
        this.UserName = null;
        this.UserLastName = null;

    }

    }
}
