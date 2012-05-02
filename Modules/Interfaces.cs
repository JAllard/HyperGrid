﻿using Aurora.Framework;
using OpenMetaverse;
using GridRegion = OpenSim.Services.Interfaces.GridRegion;

namespace Aurora.Addon.Hypergrid
{
    public interface IGatekeeperService
    {
        bool LinkRegion (string regionDescriptor, out UUID regionID, out ulong regionHandle, out string externalName, out string imageURL, out string reason);
        GridRegion GetHyperlinkRegion (UUID regionID);

        bool LoginAgent (AgentCircuitData aCircuit, GridRegion destination, out string reason);

    }

    public interface IInstantMessage
    {
        bool IncomingInstantMessage (GridInstantMessage im);
        bool OutgoingInstantMessage (GridInstantMessage im, string url, bool foreigner);
    }
    public interface IFriendsSimConnector
    {
        bool StatusNotify (UUID userID, UUID friendID, bool online);
    }

    public interface IInstantMessageSimConnector
    {
        bool SendInstantMessage (GridInstantMessage im);
    }
}
