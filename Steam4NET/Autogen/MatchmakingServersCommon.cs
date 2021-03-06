// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EMatchMakingServerResponse : int
	{
		eServerResponded = 0,
		eServerFailedToRespond = 1,
		eNoServersListedOnMasterServer = 2,
	};
	
	public enum EMatchMakingType : int
	{
		eInternetServer = 0,
		eLANServer = 1,
		eFriendsServer = 2,
		eFavoritesServer = 3,
		eHistoryServer = 4,
		eSpectatorServer = 5,
		eInvalidServer = 6,
	};
	
	public interface ISteamMatchmakingServerListResponse001
	{
		[VTableSlot(0)]
		void ServerResponded(Int32 iServer);
		[VTableSlot(1)]
		void ServerFailedToRespond(Int32 iServer);
		[VTableSlot(2)]
		void RefreshComplete(EMatchMakingServerResponse response);
	};
	public interface ISteamMatchmakingServerListResponse002
	{
		[VTableSlot(0)]
		void ServerResponded(Byte[] hRequest, Int32 iServer);
		[VTableSlot(1)]
		void ServerFailedToRespond(Byte[] hRequest, Int32 iServer);
		[VTableSlot(2)]
		void RefreshComplete(Byte[] hRequest, EMatchMakingServerResponse response);
	};
	public interface ISteamMatchmakingPingResponse
	{
		[VTableSlot(0)]
		void ServerResponded(gameserveritem_t server);
		[VTableSlot(1)]
		void ServerFailedToRespond();
	};
	public interface ISteamMatchmakingPlayersResponse
	{
		[VTableSlot(0)]
		void AddPlayerToList(string pchName, Int32 nScore, float flTimePlayed);
		[VTableSlot(1)]
		void PlayersFailedToRespond();
		[VTableSlot(2)]
		void PlayersRefreshComplete();
	};
	public interface ISteamMatchmakingRulesResponse
	{
		[VTableSlot(0)]
		void RulesResponded(string pchRule, string pchValue);
		[VTableSlot(1)]
		void RulesFailedToRespond();
		[VTableSlot(2)]
		void RulesRefreshComplete();
	};
}
