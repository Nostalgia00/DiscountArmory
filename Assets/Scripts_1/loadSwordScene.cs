using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class loadSwordScene : MonoBehaviour
	{
		Camera m_MainCamera;
		// Use this for initialization
		 void Start () {	 
		 } 

		void Update(){

		}

		void OnMouseDown(){
			 SceneManager.LoadScene("SwordScene", LoadSceneMode.Single);
		}

		

}
