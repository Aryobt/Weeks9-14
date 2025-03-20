using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week10 : MonoBehaviour
{
    public AnimationCurve Batmovement;
    public float BatSpeed = 1f;
    

    Coroutine BatGrow;
    IEnumerator GetBigger;

    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        BatGrow = StartCoroutine(GrowTheBat());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private IEnumerator GrowTheBat()
    {
        while (true)
        {
          GetBigger = MakeTheBatBig();
            yield return StartCoroutine(GetBigger);
        }

    }
    private IEnumerator MakeTheBatBig()
    {
        transform.localScale = Vector2.one * Batmovement.Evaluate(t);


        t += Time.deltaTime;
        yield return null;
    }

    public void StopGrowth()
    {
        if (BatGrow != null)
        {
            StopCoroutine(BatGrow);
        }
        if (BatGrow != null)
        {
            StopCoroutine(GetBigger);
        }

    }

}
