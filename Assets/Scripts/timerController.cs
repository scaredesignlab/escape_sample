using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerController : MonoBehaviour
{
    public TextMesh textMesh;
    float timer;
    anmtest anm;
    GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        //textMesh = gameObject.AddComponent<TextMesh>();
        textMesh.anchor = TextAnchor.LowerCenter;
        textMesh.alignment = TextAlignment.Center;
        door = GameObject.Find("Door");
        anm = door.GetComponent<anmtest>();
        textMesh.characterSize = 0.5f;
        timer = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //if(anm.anmbool == true)
        //{
        //    textMesh.text = string.Format("条件をクリアしました",timer);
        //    return;
        //}
        if (timer < 0) timer = 0;
        textMesh.text = string.Format("{0:000.0}", timer);
        if (timer <= 0)
        {
            //Application.LoadLevel("FailureScene");
        }
    }
}
