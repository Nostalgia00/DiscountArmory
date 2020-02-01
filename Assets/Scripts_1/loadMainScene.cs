using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class loadMainScene : MonoBehaviour
	{
		Camera m_MainCamera;
		// Use this for initialization
		 void Start () {
		 	m_MainCamera = Camera.main;		 
		 } 

		void Update(){

		}

		void OnMouseDown(){
			 SceneManager.LoadScene("main", LoadSceneMode.Single);			 
		}

		

}
