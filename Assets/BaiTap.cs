using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap : MonoBehaviour
{
    /*int a = 3, b = 5, c = 11, d = 23;
    float trungBinhCong;

    int x = 3, y = 5, z = 9, h = 6, chuViTG, dienTichTG;// h la chieu cao tu dinh den canh day z

    const float PI = 3.14f;
    int duongKinh = 10;
    float chuViHT, dienTichHT;

    int s = 20, t = 5;
    float v;

    int m = 8, n = 2;

    int i = 3, j = 7, k;
    */
    // Start is called before the first frame update
    void Start()
    {
        /*
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

        // Bai tap if else
        if (m + n > 10)
        {
            Debug.Log("Hieu cua m va n la " + (m - n));
        } else if (m + n > 7)
        {
            Debug.Log("Tich cua m va n la " + (m * n));
        }
        else Debug.Log("Thuong cua m va n la " + ((float)m / n));

        //BT swich case
        switch (k)
        {
            case 1: Debug.Log("Tong cua i, j, k la " + (i + j + k));
                break;
            case 2: Debug.Log("Gia tri (i + j) * k la " + ((i + j) * k));
                break;
            case 4: Debug.Log("Gia tri cua (i * j) - (i + j) la " + ((i*j) - (i + j)));
                break;
            case 0: Debug.Log("Gia tri  cua (i * j * k) + k - i la " + ((i * j * k) + k - i));
                break;
            default:Debug.Log("Khong co phep toan nao toa man");
                break;

        }*/
        TinhTongChan(20);
        Debug.Log(TinhTongChanTVGT(20));
        TinhTongLe(20);
        Debug.Log(TinhTongLeTVGT(20));
        TinhTong(20);
        Debug.Log(TinhTongTVGT(20));
        TimSoNguyenTo(20);
        Debug.Log(TimSoNguyenToTVGT(20));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TinhTongChan(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i+=2)
        {
            sum += i;
            if (n % 2 == 0)
            {
                if (i == n) Debug.Log($"Tong cua cac so chan cua day so co so lon nhat la {n} bang {sum}");
            }else
            {
                if (i == n - 1) Debug.Log($"Tong cua cac so chan cua day so co so lon nhat la {n} bang {sum}");
            }
        }
    }
    int TinhTongChanTVGT(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i += 2)
        {
            sum += i;
        }
        return sum;
    }
    void TinhTongLe(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i += 2)
        {
            sum += i;
            if (n % 2 == 0)
            {
                if (i == n - 1) Debug.Log($"Tong cua cac so chan cua day so co so lon nhat la {n} bang {sum}");
            }
            else
            {
                if (i == n) Debug.Log($"Tong cua cac so chan cua day so co so lon nhat la {n} bang {sum}");
            }
        }
    }
    int TinhTongLeTVGT(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i += 2)
        {
            sum += i;
        }
        return sum;
    }
    void TinhTong(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
            if (i == n) Debug.Log($"Tong so cua day so co so lon nhat la {n} bang {sum}");
        }
    }
    int TinhTongTVGT(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
    void TimSoNguyenTo(int n)
    {
        string str = "";
        for (int i = 0; i <= n; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    sum++;
                }
            }
            if (sum == 2)
            {
                str += i + " ";
            }
        }
        Debug.Log($"Cac so nguyen to trong day so co so lon nhat bang {n} la {str}");
    }
    string TimSoNguyenToTVGT(int n)
    {
        string str = "";
        for (int i = 0; i <= n; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    sum++;
                }
            }
            if (sum == 2)
            {
                str += i + " ";
            }
        }
        return str;
    }
}
