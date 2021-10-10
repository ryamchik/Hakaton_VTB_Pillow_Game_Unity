using UnityEngine;
using UnityEngine.EventSystems;
public class EventDrop : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private DragAndDrop _dragAndDrop;   
    //GoldScr _goldScr;
    //BondsScr _bondsScr;
    //StockScr _stockScr;
    //AddingCoin _adding;
    //DepositScr _depositScr;
    private void Awake()
    {
        //_depositScr = gameObject.GetComponent<DepositScr>();
        //_goldScr = gameObject.GetComponent<GoldScr>();
        //_bondsScr = gameObject.GetComponent<BondsScr>();
        //_stockScr = gameObject.GetComponent<StockScr>();
        //_adding = gameObject.GetComponent<AddingCoin>();
        //_dragAndDrop = gameObject.GetComponent<DragAndDrop>();
        //Debug.Log($"000000003)         _dragAndDrop {_dragAndDrop}");
    }
    public void OnPointerClick(PointerEventData eventData) 
    {  Debug.Log($"3/OnPointerDown{ eventData.used}");  }
    public void OnPointerClick()
    {
        Debug.Log($"6)         _dragAndDrop.drADr {_dragAndDrop.drADr}");
        
        if (_dragAndDrop.drADr)
        {
            Debug.Log($"7)         _dragAndDrop.coinDAD {_dragAndDrop.coinDAD}");
            if (_dragAndDrop.coinDAD)
            {
                Debug.Log($"8)         _dragAndDrop.coinDAD.transform.position {_dragAndDrop.coinDAD.transform.position}");    
                _dragAndDrop.coinDAD.transform.position = _dragAndDrop.startPose;
                _dragAndDrop.coinDAD = null;
            }
            _dragAndDrop.drADr = false;
            _dragAndDrop.SetFree();
        }
    }
}
