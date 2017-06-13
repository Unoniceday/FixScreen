using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSprite : MonoBehaviour {

    
    private void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        //攝影機垂直單位*2 = 全高，默認是5，因此這裡=10
        //假設螢幕是1920x1080 ， 螢幕上每格的單位就會是108pixel (1080/10)
        //然後寬度就會是17.7格 
        float cameraHeight = Camera.main.orthographicSize * 2;
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;

        //算出寬高去選取縮放哪一邊
        Vector2 scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        { 
            scale *= cameraSize.x / spriteSize.x;
        }
        else
        { 
            scale *= cameraSize.y / spriteSize.y;
        }

        //將圖片置中，並改變為設置的大小
        transform.position = Vector2.zero; 
        transform.localScale = scale;
    }
   
}
