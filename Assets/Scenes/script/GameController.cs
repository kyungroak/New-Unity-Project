using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject medicalKitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeMedicalKit", 0f, 1f);
        InvokeRepeating("MakeBullet", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeBullet()
    {
        GameObject bullet;

        float switchValue = Random.value;
        float xValue = Random.Range(-100f, 100f);
        float yValue = Random.Range(-100f, 100f);


        if (switchValue > 0.5f)
        {
            if (Random.value > 0.5f)
            {
                bullet = Instantiate(bulletPrefab, new Vector3(-100f, yValue, 0f), Quaternion.identity);
            }
            else
            {
                bullet = Instantiate(bulletPrefab, new Vector3(100f, yValue, 0f), Quaternion.identity);
            }

        }
        else
        {
            if (Random.value > 0.5f)
            {
                bullet = Instantiate(bulletPrefab, new Vector3(xValue, -100f, 0f), Quaternion.identity);
            }
            else
            {
                bullet = Instantiate(bulletPrefab, new Vector3(xValue, 100f, 0f), Quaternion.identity);
            }
        }
    }

    void MakeMedicalKit()
    {
        GameObject medicalKit;

        float switchValue = Random.value;
        float xValue = Random.Range(-100f, 100f);
        float yValue = Random.Range(-100f, 100f);


        if (switchValue > 0.5f)
        {
            if (Random.value > 0.5f)
            {
                medicalKit = Instantiate(medicalKitPrefab, new Vector3(-100f, yValue, 0f), Quaternion.identity);
            }
            else
            {
                medicalKit = Instantiate(medicalKitPrefab, new Vector3(100f, yValue, 0f), Quaternion.identity);
            }

        }
        else
        {
            if (Random.value > 0.5f)
            {
                medicalKit = Instantiate(medicalKitPrefab, new Vector3(xValue, -100f, 0f), Quaternion.identity);
            }
            else
            {
                medicalKit = Instantiate(medicalKitPrefab, new Vector3(xValue, 100f, 0f), Quaternion.identity);
            }
        }
    }
}
