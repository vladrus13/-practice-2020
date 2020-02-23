using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJail
{
    public interface IDataBase
    {
        // if login doesn't exist then it will be created
        Person GetPerson(String login, String password);

        // action = 1/2 ==> not to say/ to say
        void SendAction(long id, String login, int action);

        // returns game by id
        bool IsOpponentFound(long id);

        // returns id of game, maybe without opponent
        long FindGame(String login);
    }
}
