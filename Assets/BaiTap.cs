using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap : MonoBehaviour
{
    int a = 3, b = 5, c = 11, d = 23;
    float trungBinhCong;

    int x = 3, y = 5, z = 9, h = 6, chuViTG, dienTichTG;// h la chieu cao tu dinh den canh day z

    const float PI = 3.14f;
    int duongKinh = 10;
    float chuViHT, dienTichHT;

    int s = 20, t = 5;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        //Tinh trung binh cong 4 so tu nhien
        trungBinhCong = (float)(a + b + c + d) / 4;
        Debug.Log("Trung binh cong cua 4 so " + a + "," + b + "," + c + "," + d + " la : " + trungBinhCong);

        //Tinh chu vi va dien tich tam giac
        if (a + b > c && a + c > b && b + c > a)
        {
            chuViTG = x + y + z;
            Debug.Log("Chu vi tam giac co 3 canh " + x + y + x + " la : " + chuViTG);
        }
        else Debug.Log("Day khong phai la tam giac");
        dienTichTG = z * h / 2;
        Debug.Log("Dien tich tam giac co canh day " + z + " va chieu cao " + h + " la : " + dienTichTG);

        //Tinh chu vi va dien tich hinh tron
        chuViHT = duongKinh * PI;
        dienTichHT = duongKinh * duongKinh * PI / 4;
        Debug.Log("Chu vi va dien tich hinh tron co duong kinh bang " + duongKinh + " lan luot la : " + chuViHT + " va " + dienTichHT);

        //Tinh van toc
        v = (float)s / t;
        Debug.Log("Van toc khi di tren quang duong " + s + " km trong thoi gian " + t + " phut la " + v + "km/phut");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
