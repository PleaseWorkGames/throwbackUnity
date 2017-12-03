using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject targetDungeon;

    // Use this for initialization
    void Start() {
        updateTarget(targetDungeon);
    }

    // Update is called once per frame
    void Update() {

    }

    public void updateTarget(GameObject newTarget)
    {
        this.targetDungeon = newTarget;
        this.transform.SetPositionAndRotation(new Vector3(targetDungeon.transform.position.x,targetDungeon.transform.position.y,this.transform.position.z),this.transform.rotation);
    }
}
