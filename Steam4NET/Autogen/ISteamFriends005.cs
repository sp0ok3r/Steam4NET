// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamFriends005")]
	public interface ISteamFriends005
	{
		[VTableSlot(0)]
		string GetPersonaName();
		[VTableSlot(1)]
		void SetPersonaName(string pchPersonaName);
		[VTableSlot(2)]
		EPersonaState GetPersonaState();
		[VTableSlot(3)]
		Int32 GetFriendCount(EFriendFlags eFriendFlags);
		[VTableSlot(4)]
		CSteamID GetFriendByIndex(Int32 iFriend, Int32 iFriendFlags);
		[VTableSlot(5)]
		EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend);
		[VTableSlot(6)]
		EPersonaState GetFriendPersonaState(CSteamID steamIDFriend);
		[VTableSlot(7)]
		string GetFriendPersonaName(CSteamID steamIDFriend);
		[VTableSlot(8)]
		Int32 GetFriendAvatar(CSteamID steamIDFriend, Int32 eAvatarSize);
		[VTableSlot(9)]
		bool GetFriendGamePlayed(CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo);
		[VTableSlot(10)]
		string GetFriendPersonaNameHistory(CSteamID steamIDFriend, Int32 iPersonaName);
		[VTableSlot(11)]
		bool HasFriend(CSteamID steamIDFriend, EFriendFlags eFriendFlags);
		[VTableSlot(12)]
		Int32 GetClanCount();
		[VTableSlot(13)]
		CSteamID GetClanByIndex(Int32 iClan);
		[VTableSlot(14)]
		string GetClanName(CSteamID steamIDClan);
		[VTableSlot(15)]
		Int32 GetFriendCountFromSource(CSteamID steamIDSource);
		[VTableSlot(16)]
		CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, Int32 iFriend);
		[VTableSlot(17)]
		bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);
		[VTableSlot(18)]
		void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);
		[VTableSlot(19)]
		void ActivateGameOverlay(string pchDialog);
		[VTableSlot(20)]
		void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID);
		[VTableSlot(21)]
		void ActivateGameOverlayToWebPage(string pchURL);
		[VTableSlot(22)]
		void ActivateGameOverlayToStore(UInt32 nAppID);
		[VTableSlot(23)]
		void SetPlayedWith(CSteamID steamIDUserPlayedWith);
	};
}
