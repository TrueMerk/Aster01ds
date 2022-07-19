using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var unitType = other.GetComponent<IUnit>();
        var myUnitType = this.GetComponent<IUnit>();
        var _shooter = other.GetComponent<ShooterSpawnType>();
        if (unitType !=null)
        {
            if ( myUnitType.UnitType != unitType.UnitType) 
            {
                if (_shooter != null)
                {
                    
                }
                else
                {
                    this.gameObject.SetActive(false);
                }
               
            }
        }
      
    }  
}
