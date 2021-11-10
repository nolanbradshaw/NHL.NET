﻿using NHL.NET.Endpoints.Conference;
using NHL.NET.Endpoints.Division;
using NHL.NET.Endpoints.Franchise;
using NHL.NET.Endpoints.Standings;
using NHL.NET.Endpoints.Team;
using NHL.NET.Http;

namespace NHL.NET
{
    public class NHLClient
    {
        public ITeamEndpoint Team { get; }
        public IFranchiseEndpoint Franchise { get; }
        public IDivisionEndpoint Division { get; }
        public IStandingsEndpoints Standings { get; set; }
        public IConferenceEndpoints Conferences { get; set; }

        public NHLClient()
        {
            var requester = new Requester();

            Franchise = new FranchiseEndpoint(requester);
            Team = new TeamEndpoint(requester);
            Division = new DivisionEndpoint(requester);
            Standings = new StandingsEndpoints(requester);
            Conferences = new ConferenceEndpoints(requester);
        }
    }
}
