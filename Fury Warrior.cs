using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Midgard;
using Midgard.API.Engine;

public class Template : Simulation
{
    // Define your spells, buffs, and debuffs here
    #region Spells
    //private Spell? Example => Player?.Spell(123);

    //private Buff? ExampleBuff => Player?.Buff(123);

    //private Debuff? ExampleDebuff => Player?.Debuff(123);


    private Spell? Execute => Player?.Spell(163201);
    private Spell? Heroic Throw => Player?.Spell(57755);
    private Spell? Impending Victory => Player?.Spell(202168);
    private Spell? TR => Player?.Spell(384318);
    private Spell? Whirlwind => Player?.Spell(1680);
    private Spell? Whirlwind => Player?.Spell(190411);
    private Spell? SpearofBastion => Player?.Spell(376079);
    private Spell? Bloodthirst => Player?.Spell(23881);
    private Spell? OdynsFury => Player?.Spell(385059);
    private Spell? RB => Player?.Spell(85288);
    private Spell? Rampage => Player?.Spell(184367);
    private Spell? Ravager => Player?.Spell(228920);
    private Spell? Slam => Player.Spell(1464)


    private Buff? Avatar => Player?.Buff(107574);
    private Buff? Recklessness => Player?.Buff(1719);
    private Buff? Enrage => Player?.Buff(184361);


    #endregion

    public override void Initialization()
    {
        Config.FocusMacros = new List<int> { };
        Config.MouseoverMacros = new List<int> { };
        Config.CursorMacros = new List<int> { };
        Config.ReticleMacros = new List<int> { };
        Config.TotemIds = new List<int> { };

        Config.EnableFocusTargeting = true;

        // Monitors gameplay for new game spells to add to the database for future use
        Config.SpellCollectionMode = true;
    }

    public override void MacroCreation()
    {
        // Create all special macros here!
        /* Example
         * 
         * CreateManualMacro("player", "WWMH", $"/cast [@none] {WindfuryWeapon?.LocalizedName}" + "\\n/use 16");
         * 
         */
    }

public override void CombatAction()
{

}

public override void OutOfCombatAction()
{

}
}