using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour {

	public void Load (string n){

		SceneManager.LoadScene (n);
	}
}
