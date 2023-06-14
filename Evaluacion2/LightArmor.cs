﻿namespace Evaluacion2;

public class LightArmor : Armor
{
    public LightArmor(string name, float defense, float weight) : base(name, defense, weight)
    {
    }
    
    public override float MitigateDamage(float damage)
    {
        float mitigatedDamage = damage - defense - weight;
        if (mitigatedDamage <= damage * 0.2f)
        {
            mitigatedDamage = damage * 0.2f;
        }
        

        return mitigatedDamage;
    }
}