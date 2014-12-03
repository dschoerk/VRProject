using UnityEngine;
using System.Collections;

public class InstrumentScript : MonoBehaviour {

	public bool active = false;
	public AudioSource source;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (source == null)
			return;

		if (active && !source.isPlaying) 
			source.Play();
		else if(!active && source.isPlaying)
			source.Pause();
	}
}
