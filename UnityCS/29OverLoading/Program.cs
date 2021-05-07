using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    public enum DMGTYPE
    {
        DMG,
        FIREDMG,
        ICEDMG,
    }

    private int AttDef = 5;
    private int FireDef = 5;
    private int IceDef = 5;
    private int HP = 100;

    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }

    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.DMG:
                _Damage -= AttDef;
                break;

            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;

            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;

            default:
                break;
        }

        Damage(_Damage);
    }
}

namespace _29OverLoading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Damage(100, Player.DMGTYPE.FIREDMG);
        }
    }
}