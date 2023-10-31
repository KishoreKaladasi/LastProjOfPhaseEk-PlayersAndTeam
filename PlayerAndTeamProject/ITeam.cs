using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamProject
{
    public interface ITeam
    {
        void Add();
        void Remove();
        void GetPlayerById();
        void GetPlayerByName();
        void GetAllPlayers();
    }
}
