using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManagement : MonoBehaviour {

	public Text text; 
	public static int existingChars;
	public static int savedChars;

	// Use this for initialization
	void Awake () {
		existingChars = 0;
		savedChars = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "" + existingChars + "/" + savedChars;
	}
}
