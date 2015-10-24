using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class MonoMain : MonoBehaviour
{
	// Use this for initialization
	void Start () {

		UserData user = new UserData("binlao", 1, 10.4f);

		var stream = new MemoryStream();
		ProtoBuf.Serializer.Serialize<UserData>(stream, user);
		string userStr = Convert.ToBase64String(stream.ToArray());
		stream.Close();
		
		var m = new MemoryStream(Convert.FromBase64String(userStr));
		UserData data = ProtoBuf.Serializer.Deserialize<UserData>(m);

		Debug.Log(data.GetName() + " " + data.GetMsg());

		return;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
