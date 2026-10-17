  using System;

    namespace Mocha2023.Classes  {
public enum ProfanitySeverity
        {
None,

    Mild,

	Severe,

	SevereBypass
}
		}

  namespace Mocha2023.Classes.obj.DBClasses
        {
		public partial class PlayerDBClasses
 {
public enum GiftContext
  {
 None = -1,
        Default,
        First_Activity,
    Game_Drop,
	All_Daily_Challenges_Complete,
 All_Weekly_Challenge_Complete,
    Daily_Challenge_Complete,
	Weekly_Challenge_Complete,
    Unassigned_Equipment = 10,
 Unassigned_Avatar,
    Unassigned_Consumable,
Reacquisition = 20,
val3,
 NUX_TokensAndDressUp = 30,
 NUX_Experiment1,
	O0,
        NUX_Experiment3,
  NUX_Experiment4,
  val2,   GameRewards = 50,
		GameRewards_Tokens,
  LevelUp = 100,   Purchased_Gift_A = 500,
  Purchased_Gift_B,
	ff,
    Purchased_Gift_D,
		_1 = 1000,
        Contest,
        Promotion,
		SubscribersOnly,
		Deprecated = 1100,
 RecRoyale = 1200,
        DEPRECATED_Paintball_ClearCut = 2000,
		DEPRECATED_Paintball_Homestead,
		thing,
data,
DEPRECATED_Paintball_Dam,
    DEPRECATED_Paintball_DriveIn,
        Paintball_ClearCut = 2010,
  Paintball_Homestead,
		Paintball_Quarry,
 Paintball_River,
  Paintball_Dam,
		Paintball_DriveIn,
    DEPRECATED_Discgolf_Propulsion = 3000,
  DEPRECATED_Discgolf_Lake,     Discgolf_Propulsion = 3010,
        Discgolf_Lake,
    Discgolf_Mode_CoopCatch = 3500,
        Quest_Goblin_A = 4000,
        Quest_Goblin_B,
        _113q,
 _131x,
cc,
    Quest_Cauldron_A = 4010,
		Quest_Cauldron_B,
  Quest_Cauldron_C,
    Quest_Cauldron_S,
    Quest_Cauldron_Consumable,
    Quest_Pirate1_A = 4100,
    Quest_Pirate1_B,
  val3,
  Quest_Pirate1_S,
 _130q,
    _107q,
	_136q = 4200,
 Quest_Dracula1_B,
 Quest_Dracula1_C,
  Quest_Dracula1_S,
	Quest_Dracula1_X,
		x3,
  Quest_Dracula1_SS,
        Quest_SciFi_A = 4500,
    Quest_SciFi_B,
		Quest_SciFi_C,
    Quest_SciFi_S, 	val2,
        DEPRECATED_Charades = 5000,
  Charades,
DEPRECATED_Soccer = 6000,
    Soccer,
    DEPRECATED_Paddleball = 7000,
		Paddleball,
	DEPRECATED_Dodgeball = 8000,
 Dodgeball,
 DEPRECATED_Lasertag = 9000,
	Lasertag,   DEPRECATED_Bowling = 10000,
	Bowling,
    StuntRunner_TheMainEvent_A = 11000,
        StuntRunner_TheMainEvent_B,
StuntRunner_TheMainEvent_C,
	StuntRunner_TheMainEvent_D,
	StuntRunner_TheMainEvent_S,
		data2,
        StuntRunner_TheMainEvent_Consumable,
 StuntRunner_TheMainEvent_SS,
        Store_LaserTag = 100000,
        Store_RecCenter = 100010,
		Consumable = 110000,
    Token = 110100,
Punchcard_Challenge_Complete = 110200,
        All_Punchcard_Challenges_Complete,
    Commerce_Purchase = 200000
        }

 public enum Platforms
    {     All = -1,
  Steam, 		Oculus,
PlayStation,
		Xbox,
HeadlessBot,
IOS,
        GooglePlay
        }

  public enum PlayerRoles
    {
  Screenshare,
 Moderator,
    Developer,
        Influencer,
 RRPlus,
Keepsake,

	CommunityTeam,

        ContentCreator,
Helper,
	Admin
        }

  public enum ReportCategory
    {
		Moderator = -1,  tmp3,
    DEPRECATED_MicrophoneAbuse,
    Harassment,
 Cheating,
	DEPRECATED_ImmatureBehavior,
  AFK,
		Misc,
        Underage,
    VoteKick = 10,
        MisleadingPurchases,   CoC_Underage = 100,
 CoC_Sexual,
        CoC_Discrimination,
        CoC_Trolling,
	cc,
        obj = 1000
        }

    public enum CheerCategory
        {
    General,
	Helpful = 10,
  Sportmanship = 20,
		GreatHost = 30,
	_123q = 40,

	RecRoomDeveloper = 9000,
RecRoomCommunityTeam = 9001
    }

        public enum CheerStatus
    {
 l1,
    Accepted,
Dismissed
  }

public enum RelationshipType
    {
None,
OutgoingFriendRequest,
    IncomingFriendRequest,
    Friend
	}

        public enum MatchmakingErrorCode
        {
UnknownError = -1,   Success,
	NoSuchGame,
        PlayerNotOnline,
InsufficientSpace,
        EventNotStarted,
EventAlreadyFinished,
 BlockedFromRoom = 7,
        JuniorNotAllowed = 11,
        _129q,
 AlreadyInBestInstance,
        InsufficientRelationship,
    UpdateRequired = 16,
	AlreadyInTargetInstance,
UGCNotAllowed = 19,
  NoSuchRoom,
    RoomIsNotActive = 22,
  RoomBlockedByCreator,
RoomIsPrivate = 25,
    RoomInstanceIsPrivate,
	DeviceClassNotSupported = 30,
    DeviceClassNotSupportedByRoomOwner,
		qq,
        EventIsPrivate = 35,
        RoomInviteExpired = 40,
    NoAvailableRegion = 45,
NotorietyTooPoor = 50,
		BannedFromRoom = 55,
 NoSuchRoomPlaylist = 60,
RoomPlaylistIsNotActive,
        RoomPlaylistIsPrivate,
	NoSuchClub = 70,
        ClubHasNoClubhouse,         ClubIsNotActive = 73,
  NotAMemberOfClub,
    BannedFromClub,
		InstanceJoinNotPermitted,
        LevelTooLow
}

	public enum DeviceClasses
{
		Unknown,
  _111q,
    Screen,
        Mobile,
VRLow,
  Quest2
}

		public enum CurrencyType
        {
        Invalid,
  LaserTagTickets,
        RecCenterTokens, 		LostSkullsGold = 100,
 DraculaSilver,
 RecRoyale_Season1 = 200,
        RoomCurrency = 300
}

    public enum BalanceType
        {
    NonPurchasedNotUsableInP2P = -2,
  NonPurchasedDefault, 	SteamPurchased,
        OculusPurchased,   PlayStationPurchased,
        MicrosoftPurchased,
		IOSPurchased = 5,
    GooglePlayPurchased,
	PlayStationNonPurchasedP2P = 100,         NonPlayStationNonPurchasedP2P,
 NonPurchasedEarnedByP2P = 1000
        }

	public enum StatusVisibility
		{
  Online,
Away,
Offline,
        Unknown = 100
  }

	public enum RoomInstanceType
        {
    _106q,
    Private,
    Dormroom,
        Event,
        Meetup,
		Clubhouse
        }
	}

        public partial class RoomDBClasses
    {
  public enum Role : byte
        {
        None = 0,
		_129q = 1,

    Host = 10,
 Moderator = 20,
CoOwner = 30,
    TemporaryCoOwner = 31,

  ___ = 255
        }

    [Flags]
        public enum WarningMaskType
        {
None = 0,
		Scary = 1,
    Mature = 2,
        FlashingLights = 4,
 o1 = 8,
    Violence = 16,
Custom = 32,
        Reports = 64
  }

  public enum RoomAccessibility
 { Private = 0,
    Public = 1,
Unlisted = 2,
        Dev_only = 3,
    Dev_Unlisted = 4
}

public enum RoomState
        {
    Active = 0,

	PendingJunior = 11,

Moderation_PendingReview = 100,
		Moderation_Closed = 101,

		MarkedForDelete = 1000
 }

  public enum _121q
{
General = 0,
  Auto = 1,     AGOnly = 2,
    Banned = 3         }

public enum PromoExternalContentType
		{
        YouTube = 0
        }

    public enum JoinMode
		{
	PublicMatchmaking = 0,
    PublicNewInstance = 1,
        _114x = 2
}
    }

	public static partial class ClubDBClasses
        {
    public enum ClubState
        {
		Active = 0,
		PendingJunior = 11,
        ModerationPendingReview = 100,
        ModerationClosed = 101,
MarkedForDelete = 1000
  }

	public enum ClubVisibility
    {
        Private = 0,
        Public = 1
    }

  public enum ClubJoinability
  {
        Open = 0,
    __ = 1,
	_102q = 2
	}

	public enum ClubType
    {
        Generic = 0,
        Creator = 1  }

  public enum res
{
    _129q = -1,
	None = 0,
  PendingRequested = 1,
 PendingInvited = 2,
    PendingDenied = 3,
	Member = 10,
		Moderator = 20,
 CoOwner = 30,
	___ = 100
        }
    }
  }

        namespace Mocha2023.Classes.obj
		{
        public partial class PlayerDB
  {
        public enum val3
{
  Success,
        InvalidRequest,
SenderNotFound,
 RecipientNotFound,
DailyLimitReached,
  RecipientQueueFull,
PersistenceFailed
 }
}

    public static partial class NotificationDB
    {
	public enum MessageType
	{
        _103q = 0,
        GameInviteDeclined = 1,     GameJoinFailed = 2,
        PartyActivitySwitch = 3,
    FriendInvite = 4,
 _110x = 5,
  GameInviteV2 = 6,
		PartyActivitySwitchV2 = 7,
RequestGameInvite = 10,
RequestGameInviteDeclined = 11,
FriendStatusOnline = 20,
TextMessage = 30,
FriendRequestAccepted = 40,
    PlayerCheer = 50,
        PlayerCheerAnonymous = 51,
		RoomCoOwnerAdded = 60,
    RoomCoOwnerRemoved = 61,
 RoomCoOwnerInvited = 62,
        CreatorPublishedNewRoom = 70,
  PlayerAttendingEvent = 80,
 PlayerEventInvitation = 81,
DeprecatedGroupInvitation = 90,
		DeprecatedPlayerJoinedGroup = 91,
 CoachMessage = 100,
        NewRoomComments = 110,
PartyUpRequest = 120,
        _122q = 130,
    ClubMemberInvited = 200,
    ClubModeratorInvited = 201,
    ClubCoownerInvited = 202,
  _133x = 100000,         VirtualClubAnnouncementInventionPublished = 100001,
    VirtualClubAnnouncementGeneric = 100002,
  _127q = 100003,
	VirtualClubAnnouncementClub = 100004, VirtualClubAnnouncementPlayer = 100005,
    VirtualClubAnnouncementCode = 100006,
 VirtualClubAnnouncementPhoto = 100007,
VirtualRoomNotification = 100008
}
		}

    public static partial class RelationshipDB
  {
 public enum RelationshipKind
{
Friendship,
Subscription
}
	}

		public static partial class MeowiiImporter
	{
 private enum RoomAccessibility
 {
	Private = 0,     Public = 1,
Unlisted = 2,
Dev_only = 3,
        Dev_Unlisted = 4
    }
  }
        }

  namespace Mocha2023.Controllers
 {
public partial class APIController
 {
	private enum RelationshipFlag
    {
        Ignored, 	Muted,
Favorited
    }
}

  public partial class LegacyLeaderboardController
  {
    private enum LeaderboardResult {
 Success = 0,
        InvalidStat = 1,
    RedisConnectionError = 2
}
        }
 }

  namespace Mocha2023
        {
  public partial class Program
		{
        private enum PlayerDataToClear
	{         Visits,
        Favorites,
        Cheers
}
        }
    }
