using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour
{

    private Vector3 _origin;

	// Use this for initialization
	void Start ()
	{
	    _origin = GetComponent<Rigidbody>().position;

	}
	
	// Update is called once per frame
	void Update () {
        var offset = new Vector3(0, 0, Mathf.Sin(Time.time));
        this.GetComponent<Rigidbody>().MovePosition(_origin + offset);
	
	}
}
