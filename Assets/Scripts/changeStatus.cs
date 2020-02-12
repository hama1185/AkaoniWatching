using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeStatus : MonoBehaviour
{
    Slider villagerMindSlider;
    Slider villagerRelaxSlider;
    Slider ogreMindSlider;
    Slider ogreRelaxSlider;
    // Start is called before the first frame update
    void Start(){
        villagerMindSlider = GameObject.Find("Canvas").transform.Find("villagerMindSlider").GetComponent<Slider>();
        villagerRelaxSlider = GameObject.Find("Canvas").transform.Find("villagerRelaxSlider").GetComponent<Slider>();
        ogreMindSlider = GameObject.Find("Canvas").transform.Find("ogreMindSlider").GetComponent<Slider>();
        ogreRelaxSlider = GameObject.Find("Canvas").transform.Find("ogreRelaxSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update(){
        villagerMindSlider.value = VillagerStatus.mind;
        villagerRelaxSlider.value = VillagerStatus.relax;
        ogreMindSlider.value = OgreStatus.mind;
        ogreRelaxSlider.value = OgreStatus.relax;
    }
}
