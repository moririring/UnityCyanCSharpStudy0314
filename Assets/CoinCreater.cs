using UnityEngine;
using System.Collections;

public class CoinCreater : MonoBehaviour {

	public GameObject CoinGameObject = new GameObject();
    public float Speed = 7.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
            var offset = new Vector3(Mathf.Sin(Time.time) * Speed, 0, 0);
            Instantiate(CoinGameObject, transform.position + offset, transform.rotation);
		}
	}
}
