using System.Collections;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public GameObject launchPoint;

    private void Awake() {
        Transform launchpointTrans = transform.Find("LaunchPoint");
        launchPoint = launchpointTrans.gameObject;
        launchPoint.SetActive(false);
    }

    void OnMouseEnter () {
        // print("Slingshot: OnMouseEnter()");
        launchPoint.SetActive(true);
	}
	
	void OnMouseExit () {
        // print("Slingshot:OnMouseeExit()");
        launchPoint.SetActive(false);
	}
}
