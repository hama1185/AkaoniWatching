using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerStatus : MonoBehaviour
{
    public static Vector3 position{get;set;}
    public static Quaternion quaternion{get;set;}
    public static float angleY{get;set;}
    public static float mind{get;set;}
    public static float relax{get;set;}
    GameObject cameraAdjuster;
    GameObject cam;
    // Start is called before the first frame update
    void Start(){
        cameraAdjuster = this.transform.GetChild(0).gameObject;
        cam = this.transform.GetChild(0).GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update(){
        this.transform.position = position;
        this.transform.rotation = Quaternion.Euler(0.0f, angleY, 0.0f);
        cameraAdjuster.transform.rotation = Quaternion.Euler(0.0f, -angleY, 0.0f);
        cam.transform.rotation = quaternion;

    }
}
