using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraRect : MonoBehaviour
{
    float height;
    float width;
    public Text xCheck;
    public Text yCheck;

    public Text left;
    public Text rightUP;
    public Text rightDOWN;

    Camera UpCamera;
    Camera VillagerCamera;
    Camera OgreCamera;

    Dictionary<int, string> dict = new Dictionary<int, string>(){
        {0, "UpCamera"},
        {1, "OgreCamera"},
        {2, "VillagerCamera"}
    };

    // Start is called before the first frame update
    void Start(){
        UpCamera = GameObject.Find("UpCamera").GetComponent<Camera>();//0,0,0.6,1
        VillagerCamera = GameObject.Find("Villager").transform.GetChild(0).GetComponent<Camera>();//0.6,0,0.4,0.5
        OgreCamera = GameObject.Find("Ogre").transform.GetChild(0).GetComponent<Camera>();//0.6,0.5,0.4,0.5
    }

    // Update is called once per frame
    void Update(){
        width = Screen.width;
        height = Screen.height;
        if(Application.isEditor){
            if(Input.GetMouseButtonUp(0)){
                Vector3 mousePosition = Input.mousePosition;

                string swapName;
                if(mousePosition.x >= width / 2){
                    if(mousePosition.y >= (height / 2) + 20){//右上
                        if(dict[0] == "UpCamera"){
                            UpCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                            rightUP.text = "上空図";
                        }
                        else if(dict[0] == "OgreCamera"){
                            OgreCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                            rightUP.text = "鬼視点";
                        }
                        else if(dict[0] == "VillagerCamera"){
                            VillagerCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                            rightUP.text = "村人視点";
                        }

                        if(dict[1] == "UpCamera"){
                            UpCamera.rect  = new Rect(0, 0, 0.6f, 1);
                            left.text = "上空図";
                        }
                        else if(dict[1] == "OgreCamera"){
                            OgreCamera.rect  = new Rect(0, 0, 0.6f, 1);
                            left.text = "鬼視点";
                        }
                        else if(dict[1] == "VillagerCamera"){
                            VillagerCamera.rect  = new Rect(0, 0, 0.6f, 1);
                            left.text = "村人視点";
                        }

                        swapName = dict[0];
                        dict[0] = dict[1];
                        dict[1] = swapName;
                            
                        }
                        if(mousePosition.y <= (height / 2) - 30){//右下
                            if(dict[0] == "UpCamera"){
                                UpCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "上空図";
                            }
                            else if(dict[0] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "鬼視点";
                            }
                            else if(dict[0] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "村人視点";
                            }

                            if(dict[2] == "UpCamera"){
                                UpCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "上空図";
                            }
                            else if(dict[2] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "鬼視点";
                            }
                            else if(dict[2] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "村人視点";
                            }
                            swapName = dict[0];
                            dict[0] = dict[2];
                            dict[2] = swapName;
                            
                        }
                    }
                    xCheck.text = width.ToString();
                    yCheck.text = height.ToString();
                // UpCamera.rect  = new Rect(UpCamera.rect.x, UpCamera.rect.y, UpCamera.rect.width - 0.1f, UpCamera.rect.height);
            }
        }
        else{
            if(Input.touchCount > 0 ){
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = touch.position;

                if(touch.phase == TouchPhase.Ended){
                    string swapName;
                    if(touchPosition.x >= width / 2){
                        if(touchPosition.y >= (height / 2) + 20){//右上
                            if(dict[0] == "UpCamera"){
                                UpCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                                rightUP.text = "上空図";
                            }
                            else if(dict[0] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                                rightUP.text = "鬼視点";
                            }
                            else if(dict[0] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0.6f, 0.5f, 0.4f, 0.5f);
                                rightUP.text = "村人視点";
                            }

                            if(dict[1] == "UpCamera"){
                                UpCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "上空図";
                            }
                            else if(dict[1] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "鬼視点";
                            }
                            else if(dict[1] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "村人視点";
                            }

                            swapName = dict[0];
                            dict[0] = dict[1];
                            dict[1] = swapName;
                            
                        }
                        if(touchPosition.y <= (height / 2) - 30){//右下
                            if(dict[0] == "UpCamera"){
                                UpCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "上空図";
                            }
                            else if(dict[0] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "鬼視点";
                            }
                            else if(dict[0] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0.6f, 0, 0.4f, 0.5f);
                                rightDOWN.text = "村人視点";
                            }

                            if(dict[2] == "UpCamera"){
                                UpCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "上空図";
                            }
                            else if(dict[2] == "OgreCamera"){
                                OgreCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "鬼視点";
                            }
                            else if(dict[2] == "VillagerCamera"){
                                VillagerCamera.rect  = new Rect(0, 0, 0.6f, 1);
                                left.text = "村人視点";
                            }
                            swapName = dict[0];
                            dict[0] = dict[2];
                            dict[2] = swapName;
                            
                        }
                    }
                    xCheck.text = width.ToString();
                    yCheck.text = height.ToString();
                }
                
            }
        }

    }
}
