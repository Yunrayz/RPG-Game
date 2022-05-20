using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    public Interactable focus;
    public FighterBehaviour target;
    public Spell spell1;
    public Spell spell2;
    public Spell spell3;
    public Spell spell4;
    public int health;

    Camera cam;
    PlayerMotor motor;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                //Move our player to what we hit
                Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                motor.MoveToPoint(hit.point);

                
            }

        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                    FighterBehaviour target = hit.collider.GetComponent<FighterBehaviour>();
                    if (target != null)
                    {
                        SetTarget(target);
                    }
                }
                else
                {
                    //Stop focusing any object
                    RemoveFocus();
                    RemoveTarget();
                }
            }
        }

        if (Input.GetKeyDown("a"))
        {
            if (target != null)
            {
                spell1.Cast(target, this);              
            }
            else
            {
                Debug.Log("There is no target !");
            }
        }
        if (Input.GetKeyDown("z"))
        {
            if (target != null)
            {
                spell2.Cast(target, this);
            }
            else
            {
                Debug.Log("There is no target !");
            }
        }
        if (Input.GetKeyDown("e"))
        {
            if (target != null)
            {
                spell3.Cast(target, this);
            }
            else
            {
                Debug.Log("There is no target !");
            }
        }
        if (Input.GetKeyDown("r"))
        {
            if (target != null)
            {
                spell4.Cast(target, this);
            }
            else
            {
                Debug.Log("There is no target !");
            }
        }
    }

    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
        focus.isFocused();
    }

    void RemoveFocus ()
    {
        focus.isNotFocused();
        focus = null;
    }

    void SetTarget(FighterBehaviour newTarget)
    {
        target = newTarget;
    }

    void RemoveTarget()
    {
        target = null;
    }
}
