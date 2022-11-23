using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moveEyes : MonoBehaviour
{
    
    public Rigidbody2D rbEyes;
    public Rigidbody2D rbPlayer;
    Vector2 offset;



    private void Start()
    {
        offset = rbEyes.position - rbPlayer.position;
    }

    void Update()
    {

        Vector3 targetDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = (Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg) - 90; 
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        rbEyes.position = rbPlayer.position + offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
