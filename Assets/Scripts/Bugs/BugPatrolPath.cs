using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugPatrolPath : MonoBehaviour
{ 
    public float speed;
    public float rayDist;
    private bool isMovingLeft;
    [SerializeField] Transform groundDeduct; 

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundHit = Physics2D.Raycast(groundDeduct.position, Vector2.down, rayDist);

        if(groundHit.collider == false)
        {
            if(isMovingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                isMovingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isMovingLeft = true;
            }
        }
    }

}
