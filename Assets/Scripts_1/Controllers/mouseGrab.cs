using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class mouseGrab : MonoBehaviour
	{
		// Use this for initialization
		 void Start () {
		 
		 } 

		bool isPicked;

		void Update(){

			if(Input.GetMouseButtonUp(0)){

				isPicked = false;

			}

			if(isPicked == true){

		    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     		transform.position = (pos);

			}



		}

		void OnMouseDown(){
			isPicked = true;
		}

		

}
