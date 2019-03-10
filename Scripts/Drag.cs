using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent; 
        this.transform.SetParent(this.transform.parent.parent);
        Debug.Log("OnBeginDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("Mouse" + eventData.position);

        this.transform.position = eventData.position;
        //Debug.Log( "Event" + Input.mousePosition);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent( parentToReturnTo );
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }



}
