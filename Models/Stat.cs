using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("stats")]
public partial class Stat : ModelBase
{
    [Column("crash_total")] public int CrashTotal { get; set; }

    [Column("crash_regular")] public int CrashRegular { get; set; }

    [Column("crash_eye")] public int CrashEye { get; set; }

    [Column("crash_ghost")] public int CrashGhost { get; set; }

    [Column("crash_sticky")] public int CrashSticky { get; set; }

    [Column("distance_arms_up")] public float DistanceArmsUp { get; set; }

    [Column("distance_braking")] public float DistanceBraking { get; set; }

    [Column("distance_grounded")] public float DistanceGrounded { get; set; }

    [Column("distance_in_air")] public float DistanceInAir { get; set; }

    [Column("distance_on_no_wheels")] public float DistanceOnNoWheels { get; set; }

    [Column("distance_on_one_wheel")] public float DistanceOnOneWheel { get; set; }

    [Column("distance_on_two_wheels")] public float DistanceOnTwoWheels { get; set; }

    [Column("distance_on_three_wheels")] public float DistanceOnThreeWheels { get; set; }

    [Column("distance_on_four_wheels")] public float DistanceOnFourWheels { get; set; }

    [Column("distance_ragdoll")] public float DistanceRagdoll { get; set; }

    [Column("distance_with_no_wheels")] public float DistanceWithNoWheels { get; set; }

    [Column("distance_with_one_wheel")] public float DistanceWithOneWheel { get; set; }

    [Column("distance_with_two_wheels")] public float DistanceWithTwoWheels { get; set; }

    [Column("distance_with_three_wheels")] public float DistanceWithThreeWheels { get; set; }

    [Column("distance_with_four_wheels")] public float DistanceWithFourWheels { get; set; }

    [Column("distance_on_regular")] public float DistanceOnRegular { get; set; }

    [Column("distance_on_grass")] public float DistanceOnGrass { get; set; }

    [Column("distance_on_ice")] public float DistanceOnIce { get; set; }

    [Column("time_arms_up")] public float TimeArmsUp { get; set; }

    [Column("time_braking")] public float TimeBraking { get; set; }

    [Column("time_grounded")] public float TimeGrounded { get; set; }

    [Column("time_in_air")] public float TimeInAir { get; set; }

    [Column("time_on_no_wheels")] public float TimeOnNoWheels { get; set; }

    [Column("time_on_one_wheel")] public float TimeOnOneWheel { get; set; }

    [Column("time_on_two_wheels")] public float TimeOnTwoWheels { get; set; }

    [Column("time_on_three_wheels")] public float TimeOnThreeWheels { get; set; }

    [Column("time_on_four_wheels")] public float TimeOnFourWheels { get; set; }

    [Column("time_ragdoll")] public float TimeRagdoll { get; set; }

    [Column("time_with_no_wheels")] public float TimeWithNoWheels { get; set; }

    [Column("time_with_one_wheel")] public float TimeWithOneWheel { get; set; }

    [Column("time_with_two_wheels")] public float TimeWithTwoWheels { get; set; }

    [Column("time_with_three_wheels")] public float TimeWithThreeWheels { get; set; }

    [Column("time_with_four_wheels")] public float TimeWithFourWheels { get; set; }

    [Column("time_on_regular")] public float TimeOnRegular { get; set; }

    [Column("time_on_grass")] public float TimeOnGrass { get; set; }

    [Column("time_on_ice")] public float TimeOnIce { get; set; }

    [Column("times_started")] public int TimesStarted { get; set; }

    [Column("times_finished")] public int TimesFinished { get; set; }

    [Column("wheels_broken")] public int WheelsBroken { get; set; }

    [Column("checkpoints_crossed")] public int CheckpointsCrossed { get; set; }

    [Column("user")] public int User { get; set; }

    [Column("month")] public int Month { get; set; }

    [Column("year")] public int Year { get; set; }

    [ForeignKey("User")]
    [InverseProperty("Stats")]
    public virtual User UserNavigation { get; set; } = null!;
}
