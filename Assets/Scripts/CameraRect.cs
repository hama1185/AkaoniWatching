using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraRect : MonoBehaviour
{
    public Text xCheck;
    public Text yCheck;
    Camera UpCamera;
    Camera VillagerCamera;
    Camera OgreCamera;
    bool switchFlag;

    // Start is called before the first frame update
    void Start(){
        switchFlag = false;
        UpCamera = GameObject.Find("UpCamera").GetComponent<Camera>();//0,0,0.6,1
        VillagerCamera = GameObject.Find("Villager").transform.GetChild(0).GetComponent<Camera>();//0.6,0,0.4,0.5
        OgreCamera = GameObject.Find("Ogre").transform.GetChild(0).GetComponent<Camera>();//0.6,0.5,0.4,0.5
    }

    // Update is called once per frame
    void Update(){
        if(Application.isEditor){
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePosition = Input.mousePosition;
                xCheck.text = mousePosition.x.ToString();
                yCheck.text = mousePosition.y.ToString();
                // UpCamera.rect  = new Rect(UpCamera.rect.x, UpCamera.rect.y, UpCamera.rect.width - 0.1f, UpCamera.rect.height);
            }
        }
        else{
            if(Input.touchCount > 0 ){
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = touch.position;
                xCheck.text = touchPosition.x.ToString();
                yCheck.text = touchPosition.y.ToString();
            }
        }

    }
}
