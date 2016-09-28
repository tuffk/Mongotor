using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour
{
    public static float _spdMult = 1f;
    private int frames = 0;
    //protected Animator anim;
    public GameObject _cindy;
    Vector3 jump = new Vector3(0.0f, 300.0f, 0.0f);
    Vector3 jump2 = new Vector3(0.0f, 100.0f, 0.0f);
    bool InAir = false;
    public Quaternion kuz;
    public Vector3 sharmuta;
    public Quaternion debug;
    private Rigidbody rigido;

	private Transform m_Cam;                  // A reference to the main camera in the scenes transform
	private Vector3 m_CamForward;  

	GameObject hit_obj;
	private float maxRange = 1000f;
	private bool hit_b;

	public Rigidbody projectile;
	public float speed = 20;


	public float pickupRange = 20.0f;
	public float holdRange = 2.0f;
	bool holdingObject = false;
	GameObject heldObject;


    // Use this for initialization
    void Start()
    {
        kuz = this.transform.rotation;
        sharmuta = this.transform.position;

		if (Camera.main != null)
		{
			m_Cam = Camera.main.transform;
		}
		else
		{
			Debug.LogWarning(
				"Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
			// we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
		}
        //rigido = this.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.tag == "Untagged")
            InAir = false;
    }

    void OnCollisionExit(Collision otro)
    {
        InAir = true;
    }
    void mekai()
    {
        this.transform.position = sharmuta;
        this.transform.rotation = kuz;
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        debug = this.transform.rotation;
        if (this.transform.rotation.z > 0.2f || this.transform.rotation.z < -0.2f)
        {
            mekai();
        }
        if (_cindy.CompareTag("raptor"))
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && InAir == false)
            {
                _cindy.GetComponent<Rigidbody>().AddForce(jump2);
                print("deberia saltar, hacia adelante");
                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = true;
                Raptor_Control._cindyAvanza = false;
                //InAir = true;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow))
            {
                //anim.Stop();
                //anim.CrossFade("Look_right", 0.2f);
                transform.Rotate(new Vector3(0f, 5f, 0f));
                //transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                print("Deberia ver a la derecha");
                Raptor_Control._rotaCindyDerecha = true;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow))
            {
                //transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                //anim.Stop();
                //anim.CrossFade("Look_left", 0.2f);
                print("Deberia ver a la izquierda");
                transform.Rotate(new Vector3(0f, -5f, 0f));
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = true;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = false;
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                //anim.Stop();
                //anim.CrossFade("Run", 0.2f);
                //anim.CrossFade("Look_right", 0.2f);
                transform.Rotate(new Vector3(0f, 1.5f, 0f));
                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                print("Deberia ver a la derecha mientras corre");

                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = true;
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                print("Deberia ver a la izquierda mientras corre");
                //anim.Stop();
                //anim.CrossFade("Run", 0.2f);
                //anim.CrossFade("Look_left", 0.2f);
                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                transform.Rotate(new Vector3(0f, -1.5f, 0f));
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = true;
            }
            else if (Input.GetKey(KeyCode.S) && InAir == false)
            {
                _cindy.GetComponent<Rigidbody>().AddForce(jump);
                print("deberia saltar");
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = true;
                Raptor_Control._cindyAvanza = false;

            }
            else if (Input.GetKey(KeyCode.W))
            {
                //anim.Stop();
                //anim.CrossFade("Run", 0.2f);
                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = true;
            }
            else
            {
                Raptor_Control._rotaCindyDerecha = false;
                Raptor_Control._rotaCindyIzquierda = false;
                Raptor_Control._cindySalta = false;
                Raptor_Control._cindyAvanza = false;
            }

            if (_spdMult != 1)
            {
                frames++;
                if (frames >= 14000)
                {
                    _spdMult = 1f;
                    frames = 0;
                }
            } //esto hace al multiplicador de velocidad temporal
        }

		//disparar
		Vector3 targetPoint = new Vector3();
		RaycastHit hit = new RaycastHit();

		if (!holdingObject) {
			if (Physics.Raycast (m_Cam.position, m_Cam.forward, out hit, maxRange)) {

				targetPoint = hit.point;
				hit_obj = hit.transform.gameObject;
				//hitR = hit.collider.GetComponent<Renderer> ();
				hit_b = true;
				hit_obj.GetComponent<Renderer> ().material.color = Color.red;

			} else {
				if (hit_b) {
					hit_obj.GetComponent<Renderer> ().material.color = Color.white;
					hit_b = false;
				}
				targetPoint = m_Cam.position + (m_Cam.forward * maxRange);
			}
		}

		if (Input.GetButtonDown("Fire1"))
		{
			fire (projectile, targetPoint);
			/*Vector3 headP = transform.position + new Vector3 (0f, 1.0f, 0f);
				Rigidbody instantiatedProjectile = Instantiate(projectile,
					headP,
					transform.rotation)
					as Rigidbody;

				instantiatedProjectile.transform.LookAt (targetPoint);
				Vector3 direction = (headP - targetPoint).normalized;
				Debug.Log (direction);
				instantiatedProjectile.velocity = instantiatedProjectile.transform.forward * speed;	*/
		}

		float radius = new float();
		Debug.Log (Input.GetKey (KeyCode.E) && pickupRange > Vector3.Distance(transform.position, targetPoint));
		if (Input.GetKeyDown (KeyCode.E) && pickupRange > Vector3.Distance (transform.position, targetPoint)) {
			if (!holdingObject) {
				radius = Vector3.Distance(hit_obj.transform.position,targetPoint);
				hit_obj.GetComponent<Rigidbody> ().isKinematic = true;
				holdingObject = true;
			}
			else {
				holdingObject = false;
				hit_obj.transform.parent = null;
				hit_obj.GetComponent<Rigidbody> ().isKinematic = false;
			}
		}
		if (holdingObject) {

			hit_obj.transform.parent = transform.parent;
			Vector3 newPos = transform.position + transform.forward * (holdRange + radius);
			newPos.y += 1.0f;
			hit_obj.transform.position = newPos;

		}
    }

	private void fire (Rigidbody projectile, Vector3 targetPoint){
		Vector3 headP = transform.position + new Vector3 (0f, 1.0f, 0f);
		Rigidbody instantiatedProjectile = Instantiate(projectile,
			headP,
			transform.rotation)
			as Rigidbody;

		instantiatedProjectile.transform.LookAt (targetPoint);
		Vector3 direction = (headP - targetPoint).normalized;
		Debug.Log (direction);
		instantiatedProjectile.velocity = instantiatedProjectile.transform.forward * speed;	
	}


}
//        else if (_cindy.CompareTag("raptor2"))
//        {

//            if (Input.GetKey(KeyCode.D))
//            {
//                transform.Rotate(new Vector3(0f, 1.5f, 0f));
//                //transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));

//                Raptor_Control._rotaCindyDerecha = true;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = false;
//            }
//            else if (Input.GetKey(KeyCode.A))
//            {
//                //transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
//                transform.Rotate(new Vector3(0f, -1.5f, 0f));
//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = true;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = false;
//            }
//            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
//            {
//                transform.Rotate(new Vector3(0f, 1.5f, 0f));
//                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));

//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = true;
//            }
//            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
//            {
//                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
//                transform.Rotate(new Vector3(0f, -1.5f, 0f));
//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = true;
//            }
//            else if (Input.GetKey(KeyCode.S) && InAir == false)
//            {
//                _cindy.GetComponent<Rigidbody>().AddForce(jump);
//                print("deberia saltar");
//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = true;
//                Raptor_Control._cindyAvanza = false;

//            }
//            else if (Input.GetKey(KeyCode.W))
//            {
//                transform.Translate(new Vector3(0f, 0f, 1f * _spdMult));
//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = true;
//            }
//            else
//            {
//                Raptor_Control._rotaCindyDerecha = false;
//                Raptor_Control._rotaCindyIzquierda = false;
//                Raptor_Control._cindySalta = false;
//                Raptor_Control._cindyAvanza = false;
//            }

//            if (_spdMult != 1)
//            {
//                frames++;
//                if (frames >= 14000)
//                {
//                    _spdMult = 1f;
//                    frames = 0;
//                }
//            } //esto hace al multiplicador de velocidad temporal
//        }
