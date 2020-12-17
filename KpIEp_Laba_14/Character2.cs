using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpIEp_Laba_14
{
    class Character2
    {
        public delegate void HitHandler(string mes);
        public event HitHandler HitNotify;
        public int life = 150;
        int damage;
        bool freze=false;
        public Random random;

        public int Damage
        {
            get
            {
                return random.Next(5, 16);
            }
            set
            {
                damage = value;
            }
        }

        public bool Freze
        {
            get
            {
                return random.Next(1, 101) <= 5 ? true : false;
            }
            set
            {
                freze = value;
            }
        }

        public void Hit(Character1 character1)
        {
            if (Freze == true)
            {
                HitNotify?.Invoke("Застынь.(чар2)");
                character1.Freze = true;
            }
            else
            {
                character1.Freze = false;
            }
            if (character1.life > 0)
            {
                character1.life -= Damage;
            }
        }

        public void Dead()
        {
            HitNotify?.Invoke("Черектер2 умер.");
        }
    }
}
