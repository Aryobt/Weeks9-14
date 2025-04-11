using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;
using System.Threading;

public class MonsterBig : MonoBehaviour
{

    public GameObject MonsterGrowth;//the monster that want to grow

    public Button growButton;//refrence the button to make the monster bigger

    // Start is called before the first frame update
    void Start()
    {
       // growButton.onClick.AddListener(GrowMonster);//adding a listiner to the growth button
    }

    public void GrowMonster()
    {
        //MonsterGrowth.transform.localScale *= 1;//increse the size of the monsters
       // Vector3 smtg = MonsterGrowth.transform.localScale;//increse the size of the monsters
        // smtg.x *= 1;
        // smtg.y *= 1;
        //MonsterGrowth.transform.localScale = smtg;//monsters transform.local scale in equal to smtg
       // Debug.Log("Bigmonsters");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
