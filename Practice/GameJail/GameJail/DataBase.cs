
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GameJail
{
    public class DataBase : IDataBase
    {
        MySqlConnection sqlConnection = null;

        public DataBase() {
            try
            {
                String host = "db4free.net";
                String port = "3306";
                String database = "jail_game";
                String username = "alexvsalex";
                String password = "Alex2000";

                String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;

                sqlConnection = new MySqlConnection(connString);
                sqlConnection.Open();
            }
            catch (MySqlException msexc) {
                throw new DataBaseException("cannot connect to server", msexc);
            }
        }

        public long FindGame(String login)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("add_game", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("l2", MySqlDbType.VarChar).Value = login;
                
                MySqlParameter resultParam = new MySqlParameter("@Result", MySqlDbType.Int64);

                resultParam.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters.Add(resultParam);
                
                cmd.ExecuteNonQuery();

                Int64 empNo;
                if (resultParam.Value != DBNull.Value)
                {
                    empNo = (Int64)resultParam.Value;
                    return empNo;
                }
                else {
                    throw new DataBaseException("Database's problem");
                }
            }
            catch (MySqlException msexc) {
                throw new DataBaseException("Cannot find game", msexc);
            }
        }

        public Boolean IsOpponentFound(Int64 id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("is_both_in_game", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("game_id", MySqlDbType.Int64).Value = id;
                
                MySqlParameter resultParam = new MySqlParameter("@Result", MySqlDbType.Bit);

                resultParam.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters.Add(resultParam);
                
                cmd.ExecuteNonQuery();

                Boolean empNo;
                if (resultParam.Value != DBNull.Value)
                {
                    empNo = (Boolean) resultParam.Value;
                    return empNo;
                }
                else
                {
                    throw new DataBaseException("Database's problem");
                }
            }
            catch (MySqlException msexc)
            {
                throw new DataBaseException("Cannot find game", msexc);
            }
        }

        public Person GetPerson(string login, string password)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("get_user", sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("l", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("p", MySqlDbType.VarChar).Value = password;

                cmd.Parameters.Add(new MySqlParameter("games_played", MySqlDbType.Int64));
                cmd.Parameters.Add(new MySqlParameter("in_jail", MySqlDbType.Int64));

                cmd.Parameters["games_played"].Direction = ParameterDirection.Output;
                cmd.Parameters["in_jail"].Direction = ParameterDirection.Output;
               
                cmd.ExecuteNonQuery();
                
                Int64 games_played = (Int64) cmd.Parameters["games_played"].Value;
                Int64 in_jail = (Int64) cmd.Parameters["in_jail"].Value;
                if (games_played == -1) {
                    throw new DataBaseException("wrong password");
                }

                Person person = new Person(login, password, games_played, in_jail, this);
                // Здесь нужно собрать Person из тех двух полей, логин и пароль корректный, аккаунт существует

                return person;
            }
            catch (MySqlException e)
            {
                throw new DataBaseException("cannot load profile", e);
            }
        }

        public void SendAction(long id, string login, int action)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("do_action", sqlConnection);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("act", MySqlDbType.Int32).Value = action;
                cmd.Parameters.Add("log", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("game_id", MySqlDbType.Int64).Value = id;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException msexc)
            {
                throw new DataBaseException("cannot send your action", msexc);
            }
        }

        ~DataBase() {
            sqlConnection.Close();
        }
    }

    public class DataBaseException : Exception {
        public DataBaseException(String message) : base(message)
        {

        }

        public DataBaseException(String message, Exception cause) : base(message, cause){
            
        }
    }
}


/*
 
DELIMITER //

DROP FUNCTION if EXISTS add_game //

CREATE FUNCTION add_game(l2 varchar(256))
RETURNS BIGINT

BEGIN

DECLARE result BIGINT;

IF (EXISTS (SELECT * FROM `games` WHERE `login2`='')) THEN
UPDATE `games` SET `login2`=l2 WHERE `login2`='' ; 
ELSE INSERT INTO `games`(`login1`, `login2`) VALUES(l2, '') ;  
END IF ; 

SELECT MAX(`id`) INTO result FROM `games`;
RETURN result;

END; //

DELIMITER ;
     


     */


/*
 DELIMITER //

DROP PROCEDURE if EXISTS get_user //

CREATE PROCEDURE get_user(l varchar(256), p varchar(256), OUT games_played BIGINT, OUT in_jail BIGINT)

BEGIN
DECLARE cnt BIGINT;

IF (EXISTS (SELECT * FROM `users` WHERE `login`=l AND `password`=p)) THEN
SET games_played = 0;
SET in_jail = 0;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login1`=l AND `choose1`=1 AND `choose2`=1;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 1 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login1`=l AND `choose1`=1 AND `choose2`=2;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 10 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login1`=l AND `choose1`=2 AND `choose2`=1;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 0 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login1`=l AND `choose1`=2 AND `choose2`=2;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 2 * cnt;

SELECT COUNT(*) INTO cnt FROM `games` WHERE `login2`=l AND `choose1`=1 AND `choose2`=1;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 1 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login2`=l AND `choose1`=2 AND `choose2`=1;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 10 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login2`=l AND `choose1`=1 AND `choose2`=2;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 0 * cnt;
SELECT COUNT(*) INTO cnt FROM `games` WHERE `login2`=l AND `choose1`=2 AND `choose2`=2;
SET games_played = games_played + cnt;
SET in_jail = in_jail + 2 * cnt;

ELSEIF (EXISTS (SELECT * FROM `users` WHERE `login`=l)) THEN
SET games_played = -1;
SET in_jail = -1;

ELSE 
INSERT INTO `users`(`login`, `password`) VALUES(l, p);
SET games_played = 0;
SET in_jail = 0;

END IF ; 

END; //

DELIMITER ;
 */
