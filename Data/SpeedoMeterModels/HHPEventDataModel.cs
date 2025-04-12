using EventDataAnalyzer_HHP.ApplicationSpecifics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDataAnalyzer_HHP.Data.RawData
{
    public class HHPeventDataModel
    {

        /// <summary>
        /// If the Date & Time are seperate then the same must be formatted in the Excel
        /// </summary>
        /// 

        public Boolean IsPressuresInPSI { get; set; }
        public DateTime EventDateTime { get; set; }
        public float Speed { get; set; }
        /// <summary>
        /// Distance Travelled (Not the Cumulative travel)
        /// </summary>
        public int DistanceTravelled { get; set; }
        public float TEBE { get; set; }
        public float PowerKW { get; set; }
        public float BPpressure { get; set; }
        public float BCpressure { get; set; }
        public String TL24 { get; set; }
        public Boolean IsGFenabled { get; set; }
        public string ReverserPosition { get; set; }
       
        public String ThrottlePosition { get; set; }
        public Boolean IsHorn { get; set; }
        public Boolean IsHLshorthoodBurning { get; set; }
        public Boolean IsHLlonghoodBurning { get; set; }
        public Boolean IsPCSenabled { get; set; }
        public Boolean IsPenaltyBrakeApplied { get; set; }
        public String STGBCL { get; set; }
        public Boolean IsMomoryFreezed { get; set; }
        public String EventCode { get; set; }


    }


    }
