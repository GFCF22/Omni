using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool Panel;
    public GameObject Objeto;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData)
    {

        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }
        if (Panel)
        {
            Objeto.SetActive(true);
        }



    }
}
