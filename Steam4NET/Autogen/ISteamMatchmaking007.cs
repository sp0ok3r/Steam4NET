// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamMatchMaking007")]
	public interface ISteamMatchmaking007
	{
		[VTableSlot(0)]
		Int32 GetFavoriteGameCount();
		[VTableSlot(1)]
		bool GetFavoriteGame(Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer);
		[VTableSlot(2)]
		Int32 AddFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer);
		[VTableSlot(3)]
		bool RemoveFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags);
		[VTableSlot(4)]
		UInt64 RequestLobbyList();
		[VTableSlot(5)]
		void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType);
		[VTableSlot(6)]
		void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, Int32 nValueToMatch, ELobbyComparison eComparisonType);
		[VTableSlot(7)]
		void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, Int32 nValueToBeCloseTo);
		[VTableSlot(8)]
		void AddRequestLobbyListFilterSlotsAvailable(Int32 nSlotsAvailable);
		[VTableSlot(9)]
		CSteamID GetLobbyByIndex(Int32 iLobby);
		[VTableSlot(10)]
		UInt64 CreateLobby(ELobbyType eLobbyType, Int32 cMaxMembers);
		[VTableSlot(11)]
		UInt64 JoinLobby(CSteamID steamIDLobby);
		[VTableSlot(12)]
		void LeaveLobby(CSteamID steamIDLobby);
		[VTableSlot(13)]
		bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);
		[VTableSlot(14)]
		Int32 GetNumLobbyMembers(CSteamID steamIDLobby);
		[VTableSlot(15)]
		CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, Int32 iMember);
		[VTableSlot(16)]
		string GetLobbyData(CSteamID steamIDLobby, string pchKey);
		[VTableSlot(17)]
		bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(18)]
		Int32 GetLobbyDataCount(CSteamID steamIDLobby);
		[VTableSlot(19)]
		bool GetLobbyDataByIndex(CSteamID steamIDLobby, Int32 iLobbyData, StringBuilder pchKey, Int32 cchKeyBufferSize, StringBuilder pchValue, Int32 cchValueBufferSize);
		[VTableSlot(20)]
		bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey);
		[VTableSlot(21)]
		string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey);
		[VTableSlot(22)]
		void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(23)]
		bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody);
		[VTableSlot(24)]
		Int32 GetLobbyChatEntry(CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
		[VTableSlot(25)]
		bool RequestLobbyData(CSteamID steamIDLobby);
		[VTableSlot(26)]
		void SetLobbyGameServer(CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer);
		[VTableSlot(27)]
		bool GetLobbyGameServer(CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer);
		[VTableSlot(28)]
		bool SetLobbyMemberLimit(CSteamID steamIDLobby, Int32 cMaxMembers);
		[VTableSlot(29)]
		Int32 GetLobbyMemberLimit(CSteamID steamIDLobby);
		[VTableSlot(30)]
		bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);
		[VTableSlot(31)]
		bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable);
		[VTableSlot(32)]
		CSteamID GetLobbyOwner(CSteamID steamIDLobby);
		[VTableSlot(33)]
		bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);
	};
}
