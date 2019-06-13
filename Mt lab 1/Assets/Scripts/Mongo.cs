using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;  
using MongoDB.Driver.GridFS;  
using MongoDB.Driver.Linq;

public class Mongo : MonoBehaviour
{
    string connectionString = "mongodb://localhost:27017";
    // Start is called before the first frame update
    void Start()
    {
        var client = new MongoClient(connectionString);
	    var server = client.GetServer(); 
	    var database = server.GetDatabase("gamedb");
	    var collectionPerson = database.GetCollection("PERSON");
        var collectionPlot = database.GetCollection("PLOT");
        var collectionNotes = database.GetCollection("NOTES");

	    Debug.Log ("ESTABLISHED CONNECTION");
        // Debug.Log("First row: \n" + collection.find({}, {person_id : 3}).ToString());
        foreach (var document in collectionPerson.FindOne()) {
	        Debug.Log ("First string PERSON: \n" + document);
        }
        foreach (var document in collectionPlot.FindOne()) {
	        Debug.Log ("First string PLOT: \n" + document);
        }
        
        foreach (var document in collectionNotes.FindOne()) {
	        Debug.Log ("First string NOTES: \n" + document);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


