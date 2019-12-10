using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightCreate : MonoBehaviour
{
    [SerializeField] private Light2D _light = null;
    [SerializeField] private Transform parent = null;
    int i = 1;
    
    // Update is called once per frame
    void Update()
    {
        i++;
        if (i % 10 == 0) {
            Create();
        }
    }
    private void Create() {
      var obj=  Instantiate(_light, new Vector3(0f, 0.0f, 0.0f), Quaternion.identity,parent) as Light2D;
        float r = UnityEngine.Random.Range(0.0f, 1.0f);
        float g = UnityEngine.Random.Range(0.0f, 1.0f);
        float b = UnityEngine.Random.Range(0.0f, 1.0f);
        obj.color = new Color(r,g,b);
        float x = UnityEngine.Random.Range(-3,3);
        float y = UnityEngine.Random.Range(1, 3);
        obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y),ForceMode2D.Impulse);
        obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y),ForceMode2D.Impulse);
    }
}
