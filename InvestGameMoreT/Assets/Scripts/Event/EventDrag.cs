using UnityEngine;
using UnityEngine.EventSystems;

public class EventDrag : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] private DragAndDrop _dragAndDrop;
    public void Awake()
    {
        //_dragAndDrop = gameObject.GetComponent<DragAndDrop>();
        //Debug.Log($"01)         _dragAndDrop {_dragAndDrop}");    
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log($"1/OnPointerUp{ eventData.used}");
        //if ((eventData) && eventData.pointerPress.tag == "Coin")
        if (!_dragAndDrop.drADr)
        {
            Debug.Log($"1)         tag {eventData.pointerPress.tag}");
            BeganTouch();
        }
    }
    void BeganTouch()//При первом обнаружении касания, если выбран нужный объект
    {
        //Debug.Log($"2)         bool {_dragAndDrop.drADr}");
        _dragAndDrop.drADr=true;        
        _dragAndDrop.coinDAD= gameObject;       
        _dragAndDrop.rigid= gameObject.GetComponent<Rigidbody2D>();   
        _dragAndDrop.SetDrag();        
        _dragAndDrop.startPose= gameObject.transform.position;
        //Debug.Log($"3)         rigid {_dragAndDrop.rigid}");

    }

}
