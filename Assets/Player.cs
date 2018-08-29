using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //5.3 이상 버전에서 현재 씬을 불러오는 방법

public class Player : MonoBehaviour {

    public float jumpPower;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);    
        }
	}

    private void OnCollisionExit(Collision collision)
    {
        //5.3 이전 버전에서 현재 씬을 불러오는 방법
        //Application.LoadLevel(Application.loadedLevel);
        //5.3 이상 버전에서 현재 씬을 불러오는 방법
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
