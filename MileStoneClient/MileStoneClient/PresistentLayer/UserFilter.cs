﻿using System;
using System.Collections.Generic;
using MileStoneClient.BusinessLayer;

namespace MileStoneClient.PresistentLayer
{
    class UserFilter : IQueryAction
    {
        private bool connectionFail;
        private List<Message> msgs;
       /* private string nickname;
        private string g_id;*/
        private List<SqlParam> param;

        public UserFilter(string nickname, string g_id)
        {
            connectionFail = false;
            //query to filter by user nickname
            string query = "SELECT TOP (200) [Group_Id],[Nickname],[SendTime],[Body] " +
                    "FROM [MS3].[dbo].[Users],[MS3].[dbo].[Messages] " +
                    "WHERE [MS3].[dbo].[Users].Nickname = = @user_Nickname" +
                    " AND [MS3].[dbo].[Users].[Group_Id] = @user_G_id" +
                    " AND [MS3].[dbo].[Messages].User_Id = [MS3].[dbo].[Users].Id";
            SqlParam user_Nickname = new SqlParam("@user_Nickname", nickname);
            SqlParam user_G_id = new SqlParam("@user_G_id", g_id);
            param.Add(user_Nickname);
            param.Add(user_G_id);

           /* this.nickname = nickname;
            this.g_id = g_id;*/
            try
            {
                ExecuteQuery(query);
            }catch(Exception e)
            {
                connectionFail = true;
            }
            Param.Clear();
        }

        public override void ExecuteQuery(string query)
        {
            msgs = Instance.FilterQuery(query, param);
           /* nickname = "";
            g_id = "";*/
        }

        public List<Message> Msgs
        {
            get { return msgs; }
        }

        public bool ConnectionFail
        {
            get { return connectionFail; }
            set { connectionFail = value; }
        }

        public List<SqlParam> Param
        {
            get { return param; }
            set { param = value; }
        }
    }
}
