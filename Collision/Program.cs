using System;

namespace Collision
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject blueGhost = new GameObject(42, 42);
            GameObject yellowGhost = new GameObject(10, 25);
            blueGhost.Collision(yellowGhost);
            Console.WriteLine(Convert.ToString((blueGhost.velocityX, blueGhost.velocityY, 
            yellowGhost.velocityX, yellowGhost.velocityY)));
        }
    }

    public class GameObject
    {

        public float velocityX;
        public float velocityY;
        public GameObject(float velocityX, float velocityY)
        {
            this.velocityX = velocityX;
            this.velocityY = velocityY;
        }

        public virtual void Collision(GameObject HitObj)
        {
            float temp;

            //swapping the values i.e.collision
            temp = this.velocityX;
            this.velocityX = HitObj.velocityX;
            HitObj.velocityX = temp;

            temp = this.velocityY;
            this.velocityY = HitObj.velocityY;
            HitObj.velocityY = temp;
        }

    }

    public class Ghost : GameObject
    {
        public Ghost(float velocityX, float velocityY) : base(velocityX, velocityY)
        { }
        public override void Collision(GameObject HitObj)
        {   //only ghosts collide
            if (HitObj is Ghost)
            {
                base.Collision(HitObj);
            }

        }
    }



}
