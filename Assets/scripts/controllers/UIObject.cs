using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class UIObject : MonoBehaviour
{
		public GameObject TitleUI;
		void Awake()
		{
		DontDestroyOnLoad(TitleUI);
		} 


}
