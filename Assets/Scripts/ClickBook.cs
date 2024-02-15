using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour
{
    public GameObject mathBookObject;
    public GameObject mathBook;
    public GameObject mathQuestion2;

    public GameObject historyBookObject;
    public GameObject historyBook;
    public GameObject historyQuestion2;

    public GameObject scienceBookObject;
    public GameObject scienceBook;
    public GameObject scienceQuestion2;

    public GameObject englishBookObject;
    public GameObject englishBook;
    public GameObject englishQuestion2;

    public GameObject musicBookObject;
    public GameObject musicBook;
    public GameObject musicQuestion2;

    public GameObject geographyBookObject;
    public GameObject geographyBook;
    public GameObject geographyQuestion2;

    // Update is called once per frame
    void Update()
    {
        //MATHBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (mathBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                mathBook.SetActive(true);
                mathQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
        //HISTORYBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (historyBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                historyBook.SetActive(true);
                historyQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
        //SCIENCEBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (scienceBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                scienceBook.SetActive(true);
                scienceQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
        //ENGLISHBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (englishBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                englishBook.SetActive(true);
                englishQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
        //MUSICBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (musicBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                musicBook.SetActive(true);
                musicQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
        //GEOGRAPHYBOOK
        if (Input.GetMouseButtonDown(0))
        {
            if (geographyBookObject == GetClickedObject(out RaycastHit hit))
            {
                print("clicked/touched!");
                geographyBook.SetActive(true);
                geographyQuestion2.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
    }

    GameObject GetClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject()) { target = hit.collider.gameObject; }
        }
        return target;
    }
    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(ped, results);
        return results.Count > 0;
    }
}