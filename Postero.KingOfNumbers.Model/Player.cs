using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postero.KingOfNumbers.Model
{
    public class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private Hand leftHand;
        public Hand LeftHand
        {
            get { return leftHand; }
        }

        private Hand rightHand;
        public Hand RightHand
        {
            get { return rightHand; }
        }

        public Player(string name)
        {
            this.name = name;
            leftHand = new Hand();
            rightHand = new Hand();
        }

        public bool Hit(Model.Player target, int from, int to) // from or to = 1 left | from or to = 2 right
        {
            if (from == 1 && !this.leftHand.Dead)
            {
                if (to == 1 && !target.leftHand.Dead)
                {
                    int used = target.leftHand.UsedFingers + this.leftHand.UsedFingers;
                    target.leftHand = new Hand(used);
                    return true;
                }
                else if (to == 2 && !target.rightHand.Dead)
                {
                    int used = target.rightHand.UsedFingers + this.leftHand.UsedFingers;
                    target.rightHand = new Hand(used);
                    return true;
                }
            }
            else if (from == 2 && !this.rightHand.Dead)
            {
                if (to == 1 && !target.leftHand.Dead)
                {
                    int used = target.leftHand.UsedFingers + this.rightHand.UsedFingers;
                    target.leftHand = new Hand(used);
                    return true;
                }
                else if (to == 2 && !target.rightHand.Dead)
                {
                    int used = target.rightHand.UsedFingers + this.rightHand.UsedFingers;
                    target.rightHand = new Hand(used);
                    return true;
                }
            }
            return false;
        }

        public bool Split(int target) // target = 1 left | target = 2 right
        {
            if (target == 1)
            {
                if (leftHand.UsedFingers % 2 == 0 && rightHand.Dead)
                {
                    int used = leftHand.UsedFingers / 2;

                    leftHand = new Hand(used);

                    rightHand = new Hand(used);

                    return true;
                }
            }
            else if (target == 2)
            {
                if (rightHand.UsedFingers % 2 == 0 && leftHand.Dead)
                {
                    int used = rightHand.UsedFingers / 2;

                    leftHand = new Hand(used);

                    rightHand = new Hand(used);

                    return true;
                }
            }
            return false;
        }

        public bool IsAlive()
        {
            if (leftHand.Dead && rightHand.Dead)
            {
                return false;
            }
            return true;
        }
    }
}
