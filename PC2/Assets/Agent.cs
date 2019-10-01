using UnityEngine;

public class Agent : SBAgent
{
    public Transform target;
    public Transform target2;

    void Start()
    {
        maxSpeed = 10f;
        maxSteer = 1f;
        target2 = GameObject.Find("Target2").transform;
    }

    void Update()
    {
        //velocity += SteeringBehaviours.InsideCircle(this,target,target2,3); esto de aqui hace que funcione el circulo
        velocity += SteeringBehaviours.InsideRectangle(this, target, target2, 2, 2);// esto hace que funcione el cuadrado


        transform.position += velocity * Time.deltaTime;
    }
}
