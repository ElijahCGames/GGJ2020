public class Jump : MonoBehavior {

  private float jumpSpeed = 5;
  private Rigidbody rigidbody;
  private bool onGround = true;
  private const int MAX_JUMP = 2;
  private int currentJump = 0;
  
  void Start () {
      rigidBody = GetComponent<Rigidbody>();
  }
  
  void Update () {
      if(Input.GetKeyDown("space") && (onGround || MAX_JUMP > currentJump )) 
      {
        rigidBody.AddForce(Vector3.up*, jumpSpeed, ForceMode.Impulse);
        onGround = false;
        currentJump++;
      }
      
    }
    void onCollisionEnter(Collision collision)
    {
        onGround = true;
        currentJump = 0;
    }
 }
 
