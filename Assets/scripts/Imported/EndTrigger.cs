using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManagerer gameManager;

	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}

}
