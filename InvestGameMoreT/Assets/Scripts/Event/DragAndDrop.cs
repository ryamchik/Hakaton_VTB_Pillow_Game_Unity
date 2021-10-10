using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{
    //..............................................................................................
    //tag: Coin, deposit, gold, bonds, stosk    
    public bool drADr = false;
    public GameObject coinDAD;
    public Rigidbody2D rigid;

    public Vector3 startPose;
    public void SetDrag()
    {
        rigid.gravityScale = 0;
    }
    public void SetFree()
    {
        rigid.gravityScale = 0.02f;
    }
    //..............................................................................................
    //private void Update()
    //{
    //    if (drADr)
    //    {
    //        coinDAD.transform.position=
    //    }
    //}    
        //void OnMouseDown()
    //{

    //}
    //void OnMouseUp()
    //{

    //}

    //public bool drADr = false;
    //GameObject lookObject;
    ////tag: Coin, deposit, gold, bonds, stosk


    //[SerializeField] private Camera cam;
    //[SerializeField] private float speedDrop;

    //private bool touched = false;
    //private Vector3 instantStartPos;


    //private Vector3 dis;
    //private float posX;
    //private float posY;
    //private GameObject toDrag;
    //private Rigidbody toDragRigidbody;


    //private Vector3 touchStartPos;    DepositScr _depositScr;
    //GoldScr _goldScr;
    //BondsScr _bondsScr;
    //StockScr _stockScr;
    //AddingCoin _adding;
    //private void Awake()
    //{
    //    _depositScr = gameObject.GetComponent<DepositScr>();
    //    _goldScr = gameObject.GetComponent<GoldScr>();
    //    _bondsScr = gameObject.GetComponent<BondsScr>();
    //    _stockScr = gameObject.GetComponent<StockScr>();
    //    _adding = gameObject.GetComponent<AddingCoin>();
    //    Debug.Log(gameObject);
    //}
    //public void OnPointerDown(PointerEventData eventData)
    //  {
    //        if ((eventData != null) && eventData.pointerPress.tag == "Coin")
    //        {
    //            BeganTouch(eventData.pointerPress);
    //        }
    //  }
    //    void BeganTouch(GameObject toDrag)//При первом обнаружении касания, если выбран нужный объект
    //    {
    //        touchStartPos = toDrag.transform.position;
    //        instantStartPos = toDrag.transform.position;
    //        toDragRigidbody = toDrag.GetComponent<Rigidbody>();
    //        dis = cam.WorldToScreenPoint(instantStartPos);
    //        posX = Input.GetTouch(0).position.x - dis.x;
    //        posY = Input.GetTouch(0).position.y - dis.y;
    //        SetDrag(toDragRigidbody);
    //        touched = true;
    //    }


    //    public void DragAD(GameObject obj)
    //    {
    //        if (!drADr)
    //        {
    //            lookObject = obj;
    //            drADr = true;
    //        }
    //    }
    //    void Update()
    //    {
    //        if ((Input.touchCount != 1) || (!drADr))//Проверка на наличие прикосновения ??
    //        {
    //            return;
    //        }
    //        Touch touch = Input.touches[0];
    //        Vector3 pos = touch.position;
    //        if (touch.phase == TouchPhase.Moved)
    //        {
    //            Vector2 v2 = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
    //            lookObject.transform.position = v2;
    //        }
    //    }

    ////tag: Coin, deposit, gold, bonds, stosk
    //[SerializeField] private Camera cam;
    //[SerializeField] private float speedDrop;
    //DepositScr _depositScr;
    //GoldScr _goldScr;
    //BondsScr _bondsScr;
    //StockScr _stockScr;
    //AddingCoin _adding;
    //private bool touched = false;
    //private Vector3 instantStartPos;
    //private Vector3 touchStartPos;

    //private Vector3 dis;
    //private float posX;
    //private float posY;
    //private GameObject toDrag;
    //private Rigidbody toDragRigidbody;
    //Ray ray;
    //RaycastHit hit;
    //private void Awake()
    //{
    //    _depositScr = gameObject.GetComponent<DepositScr>();
    //    _goldScr = gameObject.GetComponent<GoldScr>();
    //    _bondsScr = gameObject.GetComponent<BondsScr>();
    //    _stockScr = gameObject.GetComponent<StockScr>();
    //    _adding = gameObject.GetComponent<AddingCoin>();
    //    Debug.Log(gameObject);
    //}
    //void Update()
    //{
    //    if (Input.touchCount != 1)//Проверка на наличие прикосновения ?? >0
    //    {
    //        touched = false;
    //        if (toDragRigidbody)
    //        {
    //            SetFree(toDragRigidbody);
    //        }
    //        return;
    //    }
    //    AnaliseTouches();
    //}
    //void AnaliseTouches()
    //{
    //    Touch touch = Input.touches[0];
    //    Vector3 pos = touch.position;
    //    switch (touch.phase)
    //    {
    //        case TouchPhase.Began:      //При первом обнаружении касания
    //            RaycastHit hit;
    //            Ray ray = cam.ScreenPointToRay(pos);
    //            Debug.DrawRay(cam.ScreenPointToRay(pos).origin, cam.ScreenPointToRay(pos).direction * 1000, Color.red);
    //            Debug.Log($"origin {cam.ScreenPointToRay(pos).origin}, direction {cam.ScreenPointToRay(pos).direction}");
    //            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Coin")
    //            {
    //                Debug.Log("///////////////////////////////1");

    //                //BeganTouch(hit.transform);
    //            }

    //            break;

    //        case TouchPhase.Moved:      //Является ли прикосновение движущимся прикосновением
    //            if (touched)            //проверить наличие выбранного объекта
    //            {
    //                MovedTouch();
    //            }
    //            break;
    //        case TouchPhase.Ended:      //прикосновение закончилось
    //            {
    //                if (touched)        //проверить наличие выбранного объекта
    //                {
    //                    ray = cam.ScreenPointToRay(pos);
    //                    if (Physics.Raycast(ray, out RaycastHit fit))
    //                    {
    //                        EndedTouch(fit.collider.tag);
    //                    }
    //                }
    //            }
    //            break;
    //        case TouchPhase.Canceled:
    //            goto case TouchPhase.Ended;
    //    }
    //}
    //void BeganTouch()//При первом обнаружении касания, если выбран нужный объект
    //{
    //    touchStartPos = toDrag.transform.position;
    //    instantStartPos = toDrag.transform.position;
    //    toDragRigidbody = toDrag.GetComponent<Rigidbody>();
    //    dis = cam.WorldToScreenPoint(instantStartPos);
    //    posX = Input.GetTouch(0).position.x - dis.x;
    //    posY = Input.GetTouch(0).position.y - dis.y;
    //    SetDrag(toDragRigidbody);
    //    touched = true;
    //}
    //void MovedTouch()//Передвигающееся прикосновение
    //{
    //    float posXNow = Input.GetTouch(0).position.x - posX;
    //    float posYNow = Input.GetTouch(0).position.y - posY;
    //    Vector3 curPos = new Vector3(posXNow, posYNow, dis.z);
    //    Vector3 worldPos = cam.ScreenToWorldPoint(curPos) - instantStartPos;
    //    worldPos.z = 0.0f;
    //    toDragRigidbody.velocity = worldPos / (Time.deltaTime * speedDrop);
    //    instantStartPos = toDrag.transform.position;
    //}
    //void EndedTouch(string tag)            ////проверка куда попал объект
    //{
    //    switch (tag)    //tag: Coin, deposit, gold, bonds, stosk
    //    {
    //        case "deposit":
    //            {
    //                _adding.Add(ref _depositScr.DepositCoin);
    //            }
    //            break;
    //        case "gold":
    //            {
    //                _adding.Add(ref _goldScr.GoldCoin);
    //            }
    //            break;
    //        case "bonds":
    //            {
    //                _adding.Add(ref _bondsScr.BondCoin);
    //            }
    //            break;
    //        case "stosk":
    //            {
    //                _adding.Add(ref _stockScr.StockCoin);
    //            }
    //            break;
    //        default:
    //            touched = false;
    //            hit.transform.position = touchStartPos;
    //            instantStartPos = new Vector3(0.0f, 0.0f, 0.0f);
    //            SetFree(toDragRigidbody);
    //            break;
    //    }
    //}
    //private void SetDrag(Rigidbody rb)
    //{
    //    rb.useGravity = false;
    //}
    //private void SetFree(Rigidbody rb)
    //{
    //    rb.useGravity = true;
    //}

}