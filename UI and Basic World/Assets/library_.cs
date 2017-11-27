using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class library_ : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//what's the most generic, fundamental type in C#? Is there a way to pass in an unspecified type as a parameter?

//	public void 
}

/*

Constructors for gameObject:
file:///D:/Documentation/en/ScriptReference/GameObject-ctor.html

Public Methods:
	AddComponent:
		 	SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
	BroadcastMessage, SendMessage, SendMessageUpwards: 
			The receiving method can choose to ignore the argument by having zero parameters. 
			If options is set to SendMessageOptions. RequireReceiver an error is printed if 
			the message is not picked up by any component.	
	CompareTag
	GetComponent, GetComponent(s)InChildren, GetComponent(s)InParent:
			HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;
        	if (hinge != null)
            	hinge.useSpring = false;
 	SetActive:
    		gameObject.SetActive(boolean);
 StaticMethods:
 	CreatePrimitive: Creates a game object with a primitive mesh renderer and appropriate collider.	
 			GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
 			plane.transform.position = new Vector3(0, 0.5F, 0);
 	Find, FindWithTag: finds and returns GameObject by name
 			public GameObject Hand...
 			void Example(){
 				hand = GameObject.Find("Hand");
        		hand = GameObject.Find("/Hand");
        		hand = GameObject.Find("/Monster/Arm/Hand");
        		hand = GameObject.Find("Monster/Arm/Hand");
        	}
    FindGameObjectsWithTag:
    	public GameObject respawnPrefab;
    	public GameObject[] respawns;
    	void Example(){
			respawns = GameObject.FindGamesWithTag("Respawn");
			foreach(GameObject respawn in respawns){
				Instantiate(respawnPrefab, respawn.transform.position, respawn.position.rotation);
			}
		}
Inherited Properties: .name returns the name of the GameOBject
Inherited Public Methods: GetInstanceID, ToString (returns name of object)
Inherited Static Methods: Destroy, 
	DontDestroyOnLoad(keep when loading new scene), 
	FindObjectOfType(return first active, loaded object of Type type),
	FindObjectsOfType(return list of all active active, loaded objects of Type type),
	Instantiate - returns a clone of object original:

		GameObject prefab;
		public void someFn(){
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
		}

			or 
		GameObject prefab;
		public void someFn(){
		for (int i = 0; i < 10; i++) << ten clones
      		Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}

	
	Transform
		SphereCollider sc = gameObject.AddComponent (typeof(SphereCollider)) as SphereCollider;
		transform.localScale += new Vector3(1.1F, 0, 0);
*/


/*
Transform
	..........
	properties
	^^^^^^^^^^
	.localScale:
			SphereCollider sc = gameObject.AddComponent (typeof(SphereCollider)) as SphereCollider;
			transform.localScale += new Vector3(1.1F, 0, 0);





Properties for gameObject:
	gameObject.SetActive(boolean);
print(gameObject.activeSelf);
print(gameObject.isStatic); //editor only
gameObject.layer=2;
//print(gameObject.Scene)? or gameObject.Scene = x;
gameObject.tag = "tagname";
gameObject.transform.Translate(1,1,1);

file:///D:/Documentation/en/ScriptReference/Transform.html
Position, rotation and scale of an object.

Every object in a scene has a Transform. It's used to store and manipulate 
the position, rotation and scale of the object. Every Transform can have a parent, 
which allows you to apply position, rotation and scale hierarchically. 
This is the hierarchy seen in the Hierarchy pane. They also support enumerators 
so you can loop through children using:

foreach (Transform child in transform) {
	child.position += Vector3.up * 10.0F;
}


*/