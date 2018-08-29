using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        //일정시간 지나면 게임오브젝트 삭제  
        Destroy(gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);	
	}
}
