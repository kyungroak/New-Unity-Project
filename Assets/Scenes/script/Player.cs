using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float scaleSpeed = 0.05f;
    Vector3 mousePos, transPos, targetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButton(0))
        {
            speed = 20f;            
        } 
        else
        {
            speed = 10f;
        }

        CalTargetPos();
        MoveToTarget();
        MoveToTargetCamera();

        
    }

    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);
    }

    void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }

    void MoveToTargetCamera()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "bullet(Clone)")
        {
            Debug.Log("bullet");
            transform.localScale = new Vector3(transform.localScale.x - (3.5f * scaleSpeed), transform.localScale.y - (2f * scaleSpeed), 0);
        } else if(collider.gameObject.name == "MedicalKit(Clone)")
        {
            Debug.Log("MedicalKit");
            transform.localScale = new Vector3(transform.localScale.x + (3.5f * scaleSpeed), transform.localScale.y + (2f * scaleSpeed), 0);
        }
        
        

        Destroy(collider.gameObject);
    }
}
