﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSHealthAPI.Models
{
    public class ActivityResponse
    {
        public List<RunResponse> runActivites { get; set; }
        public List<BikeResponse> bikeActivities { get; set; }
        public List<FreePlayResponse> freePlayActivites { get; set; }
        public List<GuidedWorkoutResponse> guidedWorkoutActivities { get; set; }

        public List<GolfResponse> golfActivities { get; set; }
        public List<SleepResponse> sleepActivities { get; set; }


        public abstract class AbstractActivityResponse
        {
            public string activityType { get; set; }
            public string id { get; set; }
            public string userId { get; set; }
            public DateTime startTime { get; set; }
            public DateTime endTime { get; set; }
            public DateTime dayId { get; set; }
            public DateTime createdTime { get; set; }
            public string createdBy { get; set; }
            public string name { get; set; }
            public string duration { get; set; }
            public string period { get; set; }
            public int averageHeartRate { get; set; }
            public int peakHeartRate { get; set; }
            public int lowestHeartRate { get; set; }
            public int totalCalories { get; set; }
        }
        public class RunResponse : DistanceResponse
        {
            public string pausedDuration { get; set; }
            public long? splitDistance { get; set; }      
            
        }

        public class BikeResponse : DistanceResponse
        {
            public long splitDistance { get; set; }
        }

        public class FreePlayResponse : AbstractActivityResponse
        {
            public string pausedDuration { get; set; }
            public long? splitDistance { get; set; }
        }

        public class GuidedWorkoutResponse : AbstractActivityResponse
        {
            public int? cyclesPerformed { get; set; }
            public int? roundsPerformed { get; set; }
            public int? repetitionsPerformed { get; set; }
            public string workoutPlanId { get; set; }
        }

        public class GolfResponse : AbstractActivityResponse
        {
            public int? totalStepCount { get; set; }
            public int? totalDistanceWalked { get; set; }
            public int? parOrBetterCount { get; set; }
            public int? longestDriveDistance { get; set; }
            public int? longestStrokeDistance { get; set; }
        }

        public class SleepResponse : AbstractActivityResponse
        {
            public string awakeDuration { get; set; }
            public string sleepDuration { get; set; }
            public int? numberOfWakeups { get; set; }
            public string fallAsleepDuration { get; set; }
            public int? sleepEfficiencyPercentage { get; set; }
            public string totalRestlessSleepDuration { get; set; }
            public string totalRestfulSleepDuration { get; set; }
            public int? restingHeartRate { get; set; }
            public DateTime fallAsleepTime { get; set; }
            public DateTime wakeupTime { get; set; }
        }

        public abstract class DistanceResponse : PerformanceResponse
        {
            public long totalDistance { get; set; }
            public long totalDistanceOnFoot { get; set; }

            public long? actualDistance { get; set; }
            public int? altitudeGain { get; set; }
            public int? altitudeLoss { get; set; }
            public int? maxAltitude { get; set; }
            public int? minAltitude { get; set; }

            public long? waypointDistance { get; set; }
            public int? speed { get; set; }
            public int? pace { get; set; }
            public int? overallPace { get; set; }
        }

        public abstract class PerformanceResponse : AbstractActivityResponse
        {
            public int finishHeartRate { get; set; }
            public int recoveryHeartRateAt1Minute { get; set; }
            public int recoveryHeartRateAt2Minutes { get; set; }

            public int? underAerobic { get; set; }
            public int? aerobic { get; set; }
            public int? anaerobic { get; set; }
            public int? fitnessZone { get; set; }
            public int? healthyHeart { get; set; }
            public int? redline { get; set; }
            public int? overRedline { get; set; }
        }
    }
}