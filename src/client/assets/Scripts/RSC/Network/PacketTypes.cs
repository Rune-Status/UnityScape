namespace Assets.RSC.Network
{
	public enum ClientPacketTypes
	{
		PING = 5,

		PRAYER_OFF = 23,
		PRAYER_ON = 22,

		WALK_TO = 6,
		WALK_TO_DIRECT = 7,


		TALK_OPTION = 17,

		ACTION_ON_OBJECT1 = 74,
		ACTION_ON_OBJECT2 = 73,
		ACTION_ON_OBJECT3 = 177,

		ACTION_ON_OBJECT4 = 55,
		ACTION_ON_OBJECT5 = 16,
		ACTION_ON_OBJECT6 = 57,

		EQUIP_OR_USE = 4,
		CHANGE_COMBAT_STYLE = 64,

		// CHAT
		SEND_CHAT = 9,
		SEND_RRIVATE_MESSAGE = 175,

		SEND_CAPTCHA = 70,

		LOGOUT = 76,
		APPEARANCE_CHANGE = 13,

		DUEL_SETTINGS = 52,
		DUEL_CANCEL = 42, // ??
		DUEL_CANCEL2 = 51,
		DUEL_ACCEPT2 = 49,

		TRADE_CANCEL = 41,
		TRADE_ACCEPT2 = 40,
		TRADE_ACCEPT1 = 39,

		EXCEPTION = 3,

		LOGIN_USER = 75,
		LOGIN_INIT = 2
	}

	public enum ServerPacketTypes
	{

		PLAY_SOUND = 11,

		// First thing set on login
		SET_SERVER_INDEX = 131,
		// Attack, def, str, hits, etc..
		SET_SKILLS = 180,
		// Attack power, armour etc
		SET_EQUIPMENT_STATUS = 177,
		// PrayerId : [ON|OFF]
		SET_PRAYER = 209,
		SET_COMBAT_STYLE = 129,
		SET_FATIGUE = 126,
		SET_SLEEP_IMAGE = 206,
		SET_DUEL_SETTINGS = 198,
		SET_INVENTORY_ITEMS = 114,
		// Loops through all quests
		// Sets them to Completed: TRUE|FALSE
		SET_QUEST_STATUS_ALL = 241,
		// Set a specific quest status
		SET_QUEST_STATUS = 242,
		SET_QUEST_POINTS = 243,
		// Not sure if this is still  used.

		PLAYERS_ONLINE = 202,


		SHOW_CHARACTER_CUSTOMIZATION = 207,
		SHOW_TRADE_WINDOW = 4,
		SHOW_TRADE_CONFIRM = 251,
		SHOW_DUEL_WINDOW = 229,
		SHOW_SHOP_WINDOW = 253,
		SHOW_BANK_WINDOW = 93,
		SHOW_QUESTION_MENU = 223,
		SHOW_SERVER_MESSAGE = 148,
		SHOW_SERVER_MESSAGE_TOP = 64,

		HIDE_QUESTION_MENU = 127,
		HIDE_BANK_WINDOW = 171,
		HIDE_SHOP_WINDOW = 220,
		HIDE_DUEL_WINDOW = 160,
		HIDE_SLEEPING_WINDOW = 39,

		/*Update packets */
		NPC_POS_UPDATE = 77,
		NPC_STATE_UPDATE = 190,

		GAMEOBJECT_POS_UPDATE = 27,

		PLAYER_POS_UPDATE = 145,
		PLAYER_APPEARANCE_UPDATE = 58,
		PLAYER_EQUIPMENT_UPDATE = 62,
		PLAYER_USERNAME_UPDATE = 61,
		PLAYER_COMBAT_UPDATE = 57,
		PLAYER_HITS_UPDATE = 56,
		PLAYER_CHATMESSAGES_UPDATE = 55,
		PLAYER_BUBBLE_UPDATE = 54,

		ITEM_POS_UPDATE = 109,


		DISPLAY_MESSAGE = 49,

		// This is a string message from raw bytes. 
		// Direct from the client the parsing is: new String(data, 1, length - 1)
		SERVER_NOTIFICATION = 224,

		RECIEVE_PRIVATE_MESSAGE = 170,
	}
}