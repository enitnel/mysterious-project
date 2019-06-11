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
	}
}
