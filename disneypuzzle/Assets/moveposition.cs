using UnityEngine;

public class moveposition : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangicpozisyonu;
    
    GameObject[] kutu_dizisi;
    Manager manager;
    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangicpozisyonu = transform.position;

        kutu_dizisi = GameObject.FindGameObjectsWithTag("boxarray");
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }


    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in kutu_dizisi)
            {
                if (kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        manager.SayiArttýr();
                        this.enabled = false;
                    }
                    else
                    {
                        transform.position = baslangicpozisyonu;
                    }
                }
            }
        }
    }
}

