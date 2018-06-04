using UnityEngine;

public class UiScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RetryBtn()
	{
		Application.LoadLevel("fd");
	}

	public void MenuBtn()
	{
		Application.LoadLevel ("Menu");
	}

	public void StartBtn()
	{
		Application.LoadLevel ("fd");
	}

	public void QuitBtn()
	{
		Application.Quit ();
	}
}
