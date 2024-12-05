using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public GameObject targetObject;
    public GameObject[] allObjectsWithTag;
    void Start()
    {

        allObjectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");
    }

    public void DoDamage()
    {
        GameObject nearestObject = allObjectsWithTag[0];
        float distanceToNearest = Vector3.Distance(targetObject.transform.position, nearestObject.transform.position);

        for (int i = 1; i < allObjectsWithTag.Length; i++)
        {
            float distanceToCurrent = Vector3.Distance(targetObject.transform.position, allObjectsWithTag[i].transform.position);

            if (distanceToCurrent < distanceToNearest)
            {
                nearestObject = allObjectsWithTag[i];
                distanceToCurrent = distanceToNearest;
                EnemyAttack.instance.enemyHealth = EnemyAttack.instance.enemyHealth - 15;
            }

            foreach (GameObject g in allObjectsWithTag)
            {
                  
                g.transform.localScale = 1f * Vector3.one;
            }
        }

    }
    
}

