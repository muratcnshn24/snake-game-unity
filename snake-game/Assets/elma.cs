using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class elma : MonoBehaviour
{
    public TextMeshProUGUI skor_txt;
    int skor = 0;
    hareket kuyruk_olustur;

    private void Start()
    {
        kuyruk_olustur = GameObject.Find("bas").GetComponent<hareket>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bas")
        {
            skor += 10;
            skor_txt.text = "SKOR " + skor;
            koordinat_degistir();
            kuyruk_olustur.kuyruk_arttir();
        }

        if (other.gameObject.tag == "kuyruk")
        {
            koordinat_degistir();
        }
    }

    void koordinat_degistir()
    {
        float x_deger = Random.Range(-12.1f, 12.1f);
        float z_deger = Random.Range(-2.0f, 8.0f);

        // Set Y-coordinate to a specific value (e.g., 0.5f)
        float y_deger = 0.5f;

        transform.position = new Vector3(x_deger, y_deger, z_deger);
    }
}


