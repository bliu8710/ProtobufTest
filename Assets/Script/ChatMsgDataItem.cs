using UnityEngine;
using System.Collections;
using ProtoBuf;

[ProtoContract]
public class ChatMsgDataItem
{
	[ProtoMember(1)]
	public string msg;
}
