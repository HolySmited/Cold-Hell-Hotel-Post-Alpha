using UnityEngine;
using System.Collections;

//Controls the movement of the AI
public class LivingMovement : MonoBehaviour {

    //Counters for different states the AI may be put into
    private float patrolTimer;
    private float investigateTimer;
    private float startledTimer;
    private float animTimer;

    //The time the AI will  be in his respective states
    private float currentWaitTime;
    private float animWaitTime;

    //References to components on the AI's object
    private NavMeshAgent nav;
    private LivingAnimation anim;
    private LivingSettings settings;

    //Variables used for controling the pathing of the NPC, and switching between Paths
    private Transform[] patrolPoints;
    private WaypointSettings waypointSet;
    private int pathIndex;
    private int wayPointIndex;

    // Initializes the movement via settings.
    void Start() {
        nav = GetComponent<NavMeshAgent>();
        settings = GetComponent<LivingSettings>();
        anim = GetComponent<LivingAnimation>();

        pathIndex = 0;
        patrolPoints = settings.paths[pathIndex].patrolPoints;
        waypointSet = patrolPoints[wayPointIndex].GetComponent<WaypointSettings>();
        nav.speed = settings.patrolSpeed;
        animWaitTime = 5f;
    }

    // Determines what the AI will do during this frame
    void Update() {

		if(settings.dead == false)
	        if (settings.patrol)
	            Patrolling();
	        else {
				print (settings.fearState);
	            NotPatrolling();
	        }
		else
			Extra_Calm();
    }

    // -------------------- INDIVIDUAL STATE METHODS BASED UPON CURRENT STATE-----------------------------


    //Determines what the AI will do when not patrolling based off of state
    void NotPatrolling() {
        switch (settings.fearState) {
            case LivingSettings.FearState.startled:
                Startled();
                break;
            case LivingSettings.FearState.extra_calm:
				print (settings.fearState + " hi ");
				Extra_Calm();

                break;
            default:
                if (settings.interact)
                    Interact();
                else
                    Investigate();
                break;
        }
    }

	void Extra_Calm(){
		animWaitTime = 3.583f;
		print (animTimer);
		animTimer += Time.deltaTime;
		if(animTimer >= animWaitTime){
			print ("Extra Calm");
			anim.PauseAnim();
		}
	}

    //Interact script to turn objects back on
    void Interact() {
        nav.speed = settings.patrolSpeed;
        if (nav.remainingDistance < nav.stoppingDistance) {
            investigateTimer += Time.deltaTime;
            anim.StartGenericAnim(settings.interactPoint.animationPlay);
            if (investigateTimer >= currentWaitTime) {
                anim.EndGenericAnim(settings.interactPoint.animationPlay);
                animTimer += Time.deltaTime;
                if (animTimer >= animWaitTime) {
                    settings.interactee.GetComponent<InteractableObject>().specialInteract(null);
                    settings.patrol = true;
                    investigateTimer = 0;
                    animTimer = 0;
                    settings.interact = false;
                    settings.interactee = null;
                    settings.interactPoint = null;
                }
            }
        } else {
            investigateTimer = 0;
        }

    }

    //Checks if the investigation is over, resets to patrol when it is.
    void Investigate() {
        nav.speed = settings.patrolSpeed;
        if (nav.remainingDistance < nav.stoppingDistance) {
            investigateTimer += Time.deltaTime;
            anim.StartGenericAnim(3);
            if (investigateTimer >= currentWaitTime) {
                anim.EndGenericAnim(3);
                investigateTimer = 0;
                settings.patrol = true;
            }
        } else {
            investigateTimer = 0;
        }
    }

    //Checks if the NPC is no logner startled, resets to patroling when it is
    void Startled() {
        startledTimer += Time.deltaTime;
        //nav.speed = 0;
        if (startledTimer >= currentWaitTime) {
            nav.speed = settings.patrolSpeed;
            startledTimer = 0;
            settings.patrol = true;
            settings.CheckFear();
            settings.fear = 30;
            anim.EndGenericAnim(1);
        }
    }

    //AIs current method for patrolling a specific area
    void Patrolling() {
		if(settings.fear >=60){
			nav.speed = settings.terrifiedSpeed;
		}
		float delayTime = 1;//waypointSet.delay;
        if (nav.remainingDistance < nav.stoppingDistance) {
            patrolTimer += Time.deltaTime;
            StartPointAnimation();
            //nav.speed = 0;
            if (patrolTimer >= delayTime - currentWaitTime) {
                EndPointAnimation();
                if (waypointSet.animationPlay != 0) {
                    animTimer += Time.deltaTime;
                    if (animTimer > animWaitTime)
                        TransitionWaypoint();
                } else {
                    TransitionWaypoint();
                }
            }
        } else {
            patrolTimer = 0;
        }
        nav.destination = patrolPoints[wayPointIndex].position;
    }


    //----------------------------------METHODS FOR TRANSITIONING STATES AND PATHS------------------------

    //Breaks the AI out of the current interaction
    public void Break(){
		if(settings.dead == false){
	        settings.patrol = true;
	        investigateTimer = 0;
	        animTimer = 0;
	        if (settings.interact)
	        {
	            settings.interact = false;
	            settings.interactee = null;
	            settings.interactPoint = null;
	        }
		}

    }

    //changes the destination of the navmesh
    public void SetNavDestination(Vector3 dest){
		nav.SetDestination (dest);
	}

	//sets the wait time the AI will be in it's current state
	public void SetCurrentWaitTime(float newTime){
		currentWaitTime = newTime;
	}

	//Transitions to the next path. Prints statment upon ending the final path.
	public void TransitionPath(){
		wayPointIndex = 0;
		pathIndex++;
		if (pathIndex >= settings.paths.Length)
			print ("You didn't lose");
		else {
			patrolPoints = settings.paths [pathIndex].patrolPoints;
			if (settings.paths [pathIndex].randomPoints) {
				patrolPoints = ShuffleArray<Transform> (patrolPoints);
			}
		}
	}

	//Transitions to a specific path, doesn't change should the name not be in there
	public void TransitionPath(string name){
		wayPointIndex = 0;
		for (int i = 0; i < settings.paths.Length; i++) {
			if(settings.paths[i].name == name){
				pathIndex = i;
				patrolPoints = settings.paths[pathIndex].patrolPoints;
				if(settings.paths[pathIndex].randomPoints){
					patrolPoints = ShuffleArray<Transform>(patrolPoints);
				}
			}
		}
	}

	//Transitions to the next waypoint upon finishing at the current one
	void TransitionWaypoint(){
		animTimer = 0f;
		if (wayPointIndex == patrolPoints.Length - 1) {
			if(settings.paths[pathIndex].transistionOnEnd)
				TransitionPath();
			if(settings.paths[pathIndex].randomPoints)
				TransitionPath(settings.paths[pathIndex].name);
			wayPointIndex = 0;
		} else {
			wayPointIndex ++;
		}
		waypointSet = patrolPoints [wayPointIndex].GetComponent<WaypointSettings> ();
		if (waypointSet.randomDelay) {
			waypointSet.delay = Random.Range(waypointSet.minRand, waypointSet.maxRand);
		}
		nav.speed = settings.patrolSpeed;
		patrolTimer = 0;
	}

	public void PausePatrol(){
		settings.patrol = false;
		nav.speed = 0;
	}



	public void EndPointAnimation(){
		if (waypointSet.specialAnim) {
			anim.EndWaypointAnim (waypointSet.animationPlay);
		} else {
			anim.EndGenericAnim (waypointSet.animationPlay);
		}
	}

	public void StartPointAnimation(){
		if (waypointSet.specialAnim) {
			anim.StartWaypointAnim (waypointSet.animationPlay);
		} else {
			anim.StartGenericAnim (waypointSet.animationPlay);
		}
	}

	public T[] ShuffleArray<T>(T[] arr){
		for (int i = arr.Length - 1; i > 0; i--) {
			int r = Random.Range(0, i);
			T tmp = arr[i];
			arr[i] = arr[r];
			arr[r] = tmp;
		}
		return arr;
	}
}
