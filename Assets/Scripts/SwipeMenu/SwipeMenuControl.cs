using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMenuControl : MonoBehaviour
{
    [SerializeField] GameObject scroller;
    private float scrollPos = 0;
    private float[] pos;


    private void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }
        if (Input.GetMouseButton(0))
        {
            scrollPos = scroller.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if(scrollPos < pos[i] + (distance/ 2) && scrollPos > pos[i] - (distance / 2))
                {
                    scroller.GetComponent<Scrollbar>().value = Mathf.Lerp(scroller.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }

        for (int i = 0; i < pos.Length; i++)
        {
            if(scrollPos < pos[i] + (distance/ 2) && scrollPos > pos[i] - (distance / 2))
            {
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(6f, 3.4f), 0.1f);
                for (int a = 0; a < pos.Length; a++)
                {
                    if( a != i)
                    {
                        transform.GetChild(a).localScale = Vector2.Lerp(transform.GetChild(a).localScale, new Vector2(1f, 1f), 0.1f);

                    }
                }
            }
        }
    }
}
