﻿using System;
namespace client
{
    public class ServerMessageEvent
    {
        public ServerMessageData Data;

        public ServerMessageEvent(object source, ServerMessageData data)
        {
            this.Data = data;
        }
    }
}
