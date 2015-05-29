using UnityEngine;
using System.Collections;

public class SingletonUse : MonoBehaviour
{

	// Use this for initialization
	void Start () {

        SingletonTest ins = SingletonTest.Instance;

        Debug.Log(ins.t);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
