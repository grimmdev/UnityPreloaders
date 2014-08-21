using UnityEngine;
using System.Collections;

public class TestAnimation : MonoBehaviour {

	// we use the animator for this
	private Animator thisAnimator;

	// Use this for initialization
	void Awake ()
	{
		thisAnimator = this.GetComponent<Animator> ();
		// make sure we have the animator..
		if (thisAnimator != null)
		{
			// since the game loaded, do a fake loading thing!
			StartCoroutine (FakeLoading (Mathf.Infinity));
		}
	}

	// pretends to load something.. by using a simple counter
	IEnumerator FakeLoading(float time){
		// this begins to play the animation
		thisAnimator.SetBool ("Play", true);
		// this is our counter or timer
		yield return new WaitForSeconds(time);
		// now we stop the animation, because now is when it's loaded stuff!
		thisAnimator.SetBool ("Play", false);
	}
}
