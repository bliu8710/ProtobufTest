using UnityEngine;
using System.Collections.Generic;
using ProtoBuf;

[ProtoContract]
public class UserData
{
	[ProtoMember(1)]
	private string name;
	[ProtoMember(2)]
	private int hp;
	[ProtoMember(3)]
	private float exp;
	[ProtoMember(4)]
	private List<ChatMsgDataItem> msgList;

	public UserData()
	{

	}

	public UserData(string name, int hp, float exp)
	{
		this.name = name;
		this.hp = hp;
		this.exp = exp;
		
		ChatMsgDataItem msg = new ChatMsgDataItem
		{
			msg = "binlao_msg_1"
		};

		ChatMsgDataItem msg2 = new ChatMsgDataItem
		{
			msg = "binlao_msg_2"
		};

		this.msgList = new List<ChatMsgDataItem> { msg, msg2 };
	}

	public int GetHP()
	{
		return hp;
	}

	public string GetName()
	{
		return name;
	}

	public string GetMsg()
	{
		return msgList[1].msg;
	}
}
