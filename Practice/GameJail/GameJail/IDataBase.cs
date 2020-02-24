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

        // by game id
        bool IsOpponentFound(long id);

        // returns id of game, maybe without opponent
        long FindGame(String login);

        // replace zeroes(no answer) to ones(silence)
        void CloseGame(long id);

        // returns tuple <<player1's login, player1'answer>, <player2's login, player2'answer>> by game_id
        Tuple<Tuple<String, int>, Tuple<String, int>> GetResult(long id);
    }
}
