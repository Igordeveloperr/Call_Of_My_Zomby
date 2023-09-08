using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform goal;
   private int i;
   private float min;
   private UnityEngine.AI.NavMeshAgent agent;
   public Animator animator; 
   private void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // Указаие точки назначения
        
   }
   
   
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Timer.kils +=1; 
            Timer.points +=100;
        }
    }
    private void FixedUpdate() 
    {   
      agent.destination = goal.position;    
    }

}
