﻿using System.Collections.Generic;


namespace CommonProtocol
{
    public class ResMatchStatus : CBaseProtocol
    {
        public ResponseType ResponseType;

        public string IpAddress;

        public string PlayerSessionId;

        public int Port;

        public string TeamName;

        public string Gamesessionid;

        public List<int> roundList;

    }
}
