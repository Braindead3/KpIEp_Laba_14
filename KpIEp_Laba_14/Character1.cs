using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpIEp_Laba_14
{
    class Character1
    {
        public delegate void HitHandler(string mes);
        public event HitHandler HitNotify;
        public int life = 135;
        int damage;
        bool freze=false;
        public Random random;

        public int Damage
        {
            get
            {
                return random.Next(5, 8);
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
                return random.Next(1, 101)<=40?true:false;
            }
            set
            {
                freze = value;
            }
        }

        public void Hit(Character2 character2)
        {
            if (Freze==true)
            {
                HitNotify?.Invoke("Застынь.(чар1)");
                character2.Freze = true;
            }
            else
            {
                character2.Freze = false;
            }
            if (character2.life>0)
            {
                character2.life -= Damage;
            }
        }

        public void Dead()
        {
            HitNotify?.Invoke("Черектер1 умер.");
        }

    }
}
