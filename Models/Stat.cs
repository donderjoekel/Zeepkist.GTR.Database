using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("stats")]
public partial class Stat : ModelBase
{
    [Attr] [Column("crash_total")] public int CrashTotal { get; set; }
    [Attr] [Column("crash_regular")] public int CrashRegular { get; set; }
    [Attr] [Column("crash_eye")] public int CrashEye { get; set; }
    [Attr] [Column("crash_ghost")] public int CrashGhost { get; set; }
    [Attr] [Column("crash_sticky")] public int CrashSticky { get; set; }
    [Attr] [Column("distance_arms_up")] public float DistanceArmsUp { get; set; }
    [Attr] [Column("distance_braking")] public float DistanceBraking { get; set; }
    [Attr] [Column("distance_grounded")] public float DistanceGrounded { get; set; }
    [Attr] [Column("distance_in_air")] public float DistanceInAir { get; set; }

    [Attr]
    [Column("distance_on_no_wheels")]
    public float DistanceOnNoWheels { get; set; }

    [Attr]
    [Column("distance_on_one_wheel")]
    public float DistanceOnOneWheel { get; set; }

    [Attr]
    [Column("distance_on_two_wheels")]
    public float DistanceOnTwoWheels { get; set; }

    [Attr]
    [Column("distance_on_three_wheels")]
    public float DistanceOnThreeWheels { get; set; }

    [Attr]
    [Column("distance_on_four_wheels")]
    public float DistanceOnFourWheels { get; set; }

    [Attr] [Column("distance_ragdoll")] public float DistanceRagdoll { get; set; }

    [Attr]
    [Column("distance_with_no_wheels")]
    public float DistanceWithNoWheels { get; set; }

    [Attr]
    [Column("distance_with_one_wheel")]
    public float DistanceWithOneWheel { get; set; }

    [Attr]
    [Column("distance_with_two_wheels")]
    public float DistanceWithTwoWheels { get; set; }

    [Attr]
    [Column("distance_with_three_wheels")]
    public float DistanceWithThreeWheels { get; set; }

    [Attr]
    [Column("distance_with_four_wheels")]
    public float DistanceWithFourWheels { get; set; }

    [Attr] [Column("distance_on_regular")] public float DistanceOnRegular { get; set; }
    [Attr] [Column("distance_on_grass")] public float DistanceOnGrass { get; set; }
    [Attr] [Column("distance_on_ice")] public float DistanceOnIce { get; set; }
    [Attr] [Column("time_arms_up")] public float TimeArmsUp { get; set; }
    [Attr] [Column("time_braking")] public float TimeBraking { get; set; }
    [Attr] [Column("time_grounded")] public float TimeGrounded { get; set; }
    [Attr] [Column("time_in_air")] public float TimeInAir { get; set; }
    [Attr] [Column("time_on_no_wheels")] public float TimeOnNoWheels { get; set; }
    [Attr] [Column("time_on_one_wheel")] public float TimeOnOneWheel { get; set; }
    [Attr] [Column("time_on_two_wheels")] public float TimeOnTwoWheels { get; set; }

    [Attr]
    [Column("time_on_three_wheels")]
    public float TimeOnThreeWheels { get; set; }

    [Attr] [Column("time_on_four_wheels")] public float TimeOnFourWheels { get; set; }
    [Attr] [Column("time_ragdoll")] public float TimeRagdoll { get; set; }
    [Attr] [Column("time_with_no_wheels")] public float TimeWithNoWheels { get; set; }
    [Attr] [Column("time_with_one_wheel")] public float TimeWithOneWheel { get; set; }

    [Attr]
    [Column("time_with_two_wheels")]
    public float TimeWithTwoWheels { get; set; }

    [Attr]
    [Column("time_with_three_wheels")]
    public float TimeWithThreeWheels { get; set; }

    [Attr]
    [Column("time_with_four_wheels")]
    public float TimeWithFourWheels { get; set; }

    [Attr] [Column("time_on_regular")] public float TimeOnRegular { get; set; }
    [Attr] [Column("time_on_grass")] public float TimeOnGrass { get; set; }
    [Attr] [Column("time_on_ice")] public float TimeOnIce { get; set; }
    [Attr] [Column("times_started")] public int TimesStarted { get; set; }
    [Attr] [Column("times_finished")] public int TimesFinished { get; set; }
    [Attr] [Column("wheels_broken")] public int WheelsBroken { get; set; }
    [Attr] [Column("checkpoints_crossed")] public int CheckpointsCrossed { get; set; }

    [Attr(PublicName = "userId")]
    [Column("user")]
    public int User { get; set; }

    [Attr] [Column("month")] public int Month { get; set; }
    [Attr] [Column("year")] public int Year { get; set; }

    [ForeignKey("User")]
    [InverseProperty("Stats")]
    [HasOne(PublicName = "user")]
    public virtual User UserNavigation { get; set; } = null!;
}
