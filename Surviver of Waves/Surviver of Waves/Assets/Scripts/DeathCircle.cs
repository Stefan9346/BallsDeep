using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathCircle : MonoBehaviour {

    public Transform circleScaleSave;
    public GameObject circleUp;


    private float timeBetweenShrink;


    public void Start()
    {
        timeBetweenShrink = 10f;
        circleScaleSave = this.GetComponent<Transform>();
        
    }


    public void Update()
    {
    
        
            if (timeBetweenShrink <= 0 && circleScaleSave.localScale.x >=50)
            {
                circleScaleSave.localScale -= new Vector3(0.015f, 0.015f, 0);
                timeBetweenShrink = 0.01f;
            }
            else
            {
                timeBetweenShrink -= Time.deltaTime;
            }
        

    }

    public void ChangeCircleSize(float resizeAmount)
    {
        circleScaleSave.localScale.Set(resizeAmount, resizeAmount, 0);
    }


}
