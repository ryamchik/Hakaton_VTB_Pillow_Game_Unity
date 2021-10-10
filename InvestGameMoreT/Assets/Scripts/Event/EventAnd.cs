using UnityEngine;
using UnityEngine.EventSystems;
public class EventAnd : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private DragAndDrop _dragAndDrop; 
    void Awake()
    {
        //_dragAndDrop = gameObject.GetComponent<DragAndDrop>();
        //Debug.Log($"000000002)         _dragAndDrop {_dragAndDrop}");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"2/OnPointerDown{ eventData.used}");
        Debug.Log($"4)        _dragAndDrop.drADr {_dragAndDrop.drADr}");

        if (_dragAndDrop.drADr)
        {
        Debug.Log($"5)         transform.position { _dragAndDrop.coinDAD.transform.position}");
            Debug.Log($"/////////////6)         transform.position { eventData.position}");
            Vector3 v3 = eventData.pressPosition;
            v3.z = 0;
            _dragAndDrop.coinDAD.transform.position = v3;
        }
    }

}
