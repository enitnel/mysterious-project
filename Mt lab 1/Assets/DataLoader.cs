using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour
{

	public string[] items;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW itemsData = new WWW("http://localhost/lti_/ItemsData.php");
   		yield return itemsData;
   		string itemsDataString = itemsData.text;
   		print (itemsDataString);
   		items = itemsDataString.Split(';');
   		print(GetDataValue(items[0], "stamina_lvl:"));
	}
	string GetDataValue(string data, string index)
	{
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;
	}
}
