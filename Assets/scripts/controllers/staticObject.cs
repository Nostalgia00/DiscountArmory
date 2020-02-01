using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class staticObject : MonoBehaviour
{
		bool isOverLapping;
		// Use this for initialization
		 void Start () {
		 
		 } 

		void Update(){

			if(isOverLapping){
				Debug.Log("Touching");
			}

		}

		///ADD RIGID BODY
		void OnCollisionEnter2D (Collision2D coll) {
		//void OnTriggerEnter2D(Collider2D other){
	     	//if (other.name == "CoinSprite") {	            
	             isOverLapping = true;
	             Debug.Log("Touching");
	 
	     	//}
		}


}
