using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIJoyStick : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Image _background;
    [SerializeField] private Image _handler;

    private Vector2 _touchPosition;
    private float _joystickRadius;
    private Vector2 _moveDir;


    void Start()
    {
        _joystickRadius = _background.gameObject.GetComponent<RectTransform>().sizeDelta.x / 2;
    }

    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _background.gameObject.SetActive(true);
        _handler.gameObject.SetActive(true);
        _background.transform.position = eventData.position; ;
        _handler.transform.position = eventData.position;
        _touchPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _background.gameObject.SetActive(false);
        _handler.gameObject.SetActive(false);
        _handler.transform.position = _touchPosition;
        _moveDir = Vector2.zero;
        _player.GetComponent<ControllerPlayer>().MoveDir = _moveDir;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 touchDir = eventData.position - _touchPosition;

        float moveDist = Mathf.Min(touchDir.magnitude, _joystickRadius);
        _moveDir = touchDir.normalized;

        Vector2 newPosition =_touchPosition + _moveDir * moveDist;
        _handler.transform.position = newPosition;

        _player.GetComponent<ControllerPlayer>().MoveDir = _moveDir;
    }
}
